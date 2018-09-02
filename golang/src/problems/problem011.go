package problems

import (
	"fmt"
)

func Problem011() string {
	/*
		dat, err := ioutil.ReadFile("./data/info008.txt")
		check(err)

		// fmt.Println(singleLine)

		var total int64 = 1
		length := 13

		for _, singleLine := range lines {
			for i := 0; i <= len(singleLine)-length; i++ {
				if sumOfChar(singleLine, i, i+length) > total {
					total = sumOfChar(singleLine, i, i+length)
				}
			}
		}

		lines := buildLines(dat)

		var total int64 = 1
		length := 13

		for _, singleLine := range lines {
			for i := 0; i <= len(singleLine)-length; i++ {
				if sumOfChar(singleLine, i, i+length) > total {
					total = sumOfChar(singleLine, i, i+length)
					topLine = singleLine
					slice = singleLine[i : i+length]
				}
			}
		}

		fmt.Println(total)
	*/

	return fmt.Sprintf("NOT DONE")
}

/*
func check(e error) {
	if e != nil {
		panic(e)
	}
}

func buildLines(fileContents []byte) []string {
	newLine := []byte{'\n'}
	individualLines := bytes.Split(fileContents, newLine)
	var results []string

	for _, i := range individualLines {
		results = append(results, string(i))
	}

	return results
}

func sumOfChar(line string, start int, end int) int64 {
	var total int64 = 1

	b := line[start:end]

	for _, i := range b {
		total *= int64(int(i) - '0')
	}

	return total
}
*/
