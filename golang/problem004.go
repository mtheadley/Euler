package main

import (
	"fmt"
	"strconv"
	"strings"
)

func main() {
	foundOne := 0
	for i := 9999; i > 1; i-- {
		for j := 9999; j > 1; j-- {
			if isPalindrome(i * j) {
				if i*j > foundOne {
					foundOne = i * j
				}
			}
		}
	}

	fmt.Println(foundOne)
}

func isPalindrome(value int) bool {
	result := strings.Split(strconv.Itoa(value), "")

	//fmt.Println(result)

	if len(result)%2 != 0 {
		return false
	}

	middle := (len(result) / 2) - 1

	for i, j := middle, middle+1; j < len(result); i, j = i-1, j+1 {
		//fmt.Printf("%d : %s :: %d : %s\n", i, result[i], j, result[j])
		if result[i] != result[j] {
			return false
		}
	}

	return true
}
