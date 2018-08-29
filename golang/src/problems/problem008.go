package problems

import (
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
