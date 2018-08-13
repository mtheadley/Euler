namespace EulerApplication
{
    partial class Harness
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._executeButton = new System.Windows.Forms.Button();
            this._sampleCheckBox = new System.Windows.Forms.CheckBox();
            this._resultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this._questionListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actualAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeTaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._executeAllButton = new System.Windows.Forms.Button();
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // _executeButton
            // 
            this._executeButton.Location = new System.Drawing.Point(698, 35);
            this._executeButton.Name = "_executeButton";
            this._executeButton.Size = new System.Drawing.Size(75, 23);
            this._executeButton.TabIndex = 1;
            this._executeButton.Text = "Execute";
            this._executeButton.UseVisualStyleBackColor = true;
            this._executeButton.Click += new System.EventHandler(this._executeButton_Click);
            // 
            // _sampleCheckBox
            // 
            this._sampleCheckBox.AutoSize = true;
            this._sampleCheckBox.Location = new System.Drawing.Point(698, 12);
            this._sampleCheckBox.Name = "_sampleCheckBox";
            this._sampleCheckBox.Size = new System.Drawing.Size(61, 17);
            this._sampleCheckBox.TabIndex = 2;
            this._sampleCheckBox.Text = "Sample";
            this._sampleCheckBox.UseVisualStyleBackColor = true;
            // 
            // _resultsRichTextBox
            // 
            this._resultsRichTextBox.Location = new System.Drawing.Point(12, 464);
            this._resultsRichTextBox.Name = "_resultsRichTextBox";
            this._resultsRichTextBox.Size = new System.Drawing.Size(761, 72);
            this._resultsRichTextBox.TabIndex = 3;
            this._resultsRichTextBox.Text = "";
            // 
            // _questionListView
            // 
            this._questionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.title,
            this.answer,
            this.actualAnswer,
            this.timeTaken});
            this._questionListView.FullRowSelect = true;
            this._questionListView.GridLines = true;
            this._questionListView.Location = new System.Drawing.Point(12, 12);
            this._questionListView.MultiSelect = false;
            this._questionListView.Name = "_questionListView";
            this._questionListView.Size = new System.Drawing.Size(680, 446);
            this._questionListView.TabIndex = 4;
            this._questionListView.UseCompatibleStateImageBehavior = false;
            this._questionListView.View = System.Windows.Forms.View.Details;
            this._questionListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this._questionListView_KeyUp);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 90;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 250;
            // 
            // answer
            // 
            this.answer.Text = "Answer";
            this.answer.Width = 90;
            // 
            // actualAnswer
            // 
            this.actualAnswer.Text = "Actual Answer";
            this.actualAnswer.Width = 90;
            // 
            // timeTaken
            // 
            this.timeTaken.Text = "Time Taken (sec)";
            this.timeTaken.Width = 120;
            // 
            // _executeAllButton
            // 
            this._executeAllButton.Location = new System.Drawing.Point(698, 64);
            this._executeAllButton.Name = "_executeAllButton";
            this._executeAllButton.Size = new System.Drawing.Size(75, 23);
            this._executeAllButton.TabIndex = 5;
            this._executeAllButton.Text = "Execute All";
            this._executeAllButton.UseVisualStyleBackColor = true;
            this._executeAllButton.Click += new System.EventHandler(this._executeAllButton_Click);
            // 
            // _backgroundWorker
            // 
            this._backgroundWorker.WorkerReportsProgress = true;
            this._backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this._backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this._backgroundWorker_ProgressChanged);
            this._backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Harness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 548);
            this.Controls.Add(this._executeAllButton);
            this.Controls.Add(this._questionListView);
            this.Controls.Add(this._resultsRichTextBox);
            this.Controls.Add(this._sampleCheckBox);
            this.Controls.Add(this._executeButton);
            this.Name = "Harness";
            this.Text = "Euler Harness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _executeButton;
        private System.Windows.Forms.CheckBox _sampleCheckBox;
        private System.Windows.Forms.RichTextBox _resultsRichTextBox;
        private System.Windows.Forms.ListView _questionListView;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader answer;
        private System.Windows.Forms.ColumnHeader timeTaken;
		private System.Windows.Forms.Button _executeAllButton;
        private System.Windows.Forms.ColumnHeader actualAnswer;
        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.ColumnHeader name;
    }
}

