package problems

import (
	"bytes"
	"fmt"
	"io/ioutil"
)

func Problem008() string {
	dat, err := ioutil.ReadFile("./data/info008.txt")
	check(err)
	return fmt.Sprintf(string(dat))
}

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
