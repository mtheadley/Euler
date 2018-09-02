package problems

import (
	"bytes"
	"fmt"
	"io/ioutil"
)

func Problem008() string {
	dat, err := ioutil.ReadFile("./data/info008.txt")
	check(err)

	singleLine := buildOneLine(dat)

	total := 0
	length := 13

	for i := 0; i <= len(singleLine)-length; i++ {
		if sumOfChar(singleLine, i, i+length) > total {
			total = sumOfChar(singleLine, i, i+length)
		}
	}

	return fmt.Sprintf("%d", total)
}

func check(e error) {
	if e != nil {
		panic(e)
	}
}

func buildOneLine(fileContents []byte) string {
	newLine := []byte{'\n'}
	individualLines := bytes.Split(fileContents, newLine)
	var results string

	for _, i := range individualLines {
		results = results + string(i)
	}

	return results
}

func sumOfChar(line string, start int, end int) int {
	total := 1
	slice := line[start:end]

	for _, i := range slice {
		total *= int(i) - '0'
	}

	return total
}
