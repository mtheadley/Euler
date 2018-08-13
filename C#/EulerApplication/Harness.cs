using EulerQuestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace EulerApplication
{
    public partial class Harness : Form
    {
        private readonly IEnumerable<Type> _problems = null;

		public Harness()
		{
			InitializeComponent();

			var type = typeof (IProblem);
			_problems = AppDomain.CurrentDomain.GetAssemblies().ToList()
				.SelectMany(s => s.GetTypes())
				.Where(p => type.IsAssignableFrom(p) && p.IsClass);

			_problems.ToList().ForEach(p => BuildListView(Activator.CreateInstance(p) as IProblem));
		}

	    private void _executeButton_Click(object sender, EventArgs e)
        {
            if (this._questionListView.SelectedItems.Count > 0)
            {
                var prob = this._questionListView.SelectedItems[0].Tag as IProblem;

                if (prob != null)
                {
                    var p = new BackgroundWorkerParams
                    {
                        MethodName = (_sampleCheckBox.Checked) ? "Sample" : "Question",
                        Problem = prob,
                        ListIndex = this._questionListView.SelectedIndices[0]
                    };

                    _backgroundWorker.RunWorkerAsync(p);
                }
            }
            else
            {
                MessageBox.Show("Select an item in the list.", "Message");
            }
        }

		private void BuildListView(IProblem problem)
		{
            var lvi = new ListViewItem(new string[] { problem.GetType().Name, problem.Name }, 0, Color.Blue, Color.White, new Font("Arial", 8))
				          {Tag = problem};

			this._questionListView.Items.Add(lvi);
		}

		private void ReplaceResult(int index, IResult result, IProblem prob)
		{
			this._questionListView.BeginUpdate();

			var lvi =
				new ListViewItem(
					new string[] {prob.GetType().Name, result.Name, result.Answer.ToString(), result.GivenAnswer.ToString(), result.TimeTaken.TotalSeconds.ToString()},
					0, (result.GivenAnswer.Equals(result.Answer)) ? Color.Green : Color.Red, Color.White, new Font("Arial", 8));

			lvi.Tag = prob;

			this._questionListView.Items.RemoveAt(index);
			this._questionListView.Items.Insert(index, lvi);
			this._questionListView.EndUpdate();
		}

	    private void AddResult(IResult result)
        {
            var lvi = new ListViewItem(new string[] { result.Name, result.Answer.ToString(), result.GivenAnswer.ToString(), result.TimeTaken.TotalSeconds.ToString() },
				0, (result.GivenAnswer.Equals(result.Answer)) ? Color.Green : Color.Red, Color.White, new Font("Arial", 8));

            this._questionListView.Items.Add(lvi);
        }

		private void _executeAllButton_Click(object sender, EventArgs e)
		{
			for (var index = 0; index < this._questionListView.Items.Count; index++)
			{
                var prob = this._questionListView.Items[index].Tag as IProblem;

                if (prob != null)
                {
                    var p = new BackgroundWorkerParams
                    {
                        MethodName = (_sampleCheckBox.Checked) ? "Sample" : "Question",
                        Problem = prob,
                        ListIndex = index
                    };

                    var bw = new BackgroundWorker();

                    bw.WorkerReportsProgress = true;
                    bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
                    bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this._backgroundWorker_ProgressChanged);
                    bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
                    
                    bw.RunWorkerAsync(p);
                }
			}
		}

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var args = e.Argument as BackgroundWorkerParams;

            if (args != null)
            {
                IResult result = null;

                ((BackgroundWorker)sender).ReportProgress(0, "Beginning work: " + args.Problem.Name);

                if(args.MethodName == "Sample")
                {
                    result = args.Problem.Sample();
                }
                else
                {
                    result = args.Problem.Question();
                }

                ((BackgroundWorker)sender).ReportProgress(0, "Completed work: " + args.Problem.Name);
                e.Result = new BackgroundWorkerResults { ListIndex = args.ListIndex, Problem = args.Problem, Result = result };
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            var args = e.Result as BackgroundWorkerResults;

            if (args != null)
            {
                ReplaceResult(args.ListIndex, args.Result, args.Problem);
            }
        }

        private void _backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _resultsRichTextBox.Text += e.UserState.ToString() + Environment.NewLine;

            _resultsRichTextBox.SelectionStart = _resultsRichTextBox.Text.Length;
            _resultsRichTextBox.ScrollToCaret();
        }

		private void _questionListView_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.Control && ((e.KeyValue == (int)'c') || (e.KeyValue == (int)'C')))
			{
				var lvi = this._questionListView.SelectedItems[0];

				Clipboard.SetText(lvi.SubItems[2].Text);
			}
		}
    }

    class BackgroundWorkerParams
    {
        public string MethodName { get; set; }
        public IProblem Problem { get; set; }
        public int ListIndex { get; set; }
    }

     class BackgroundWorkerResults
    {
        public int ListIndex { get; set; }
        public IProblem Problem { get; set; }
        public IResult Result { get; set; }
    }
}
