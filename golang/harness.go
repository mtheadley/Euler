package main

import (
	"fmt"
	"os"
	"problems"
)

func main() {

	problemNumber := "ALL"

	if len(os.Args) == 2 {
		problemNumber = os.Args[1]
	}

	// fmt.Println("Arg Number: ", problemNumber)

	if problemNumber == "ALL" {
		fmt.Println("Problem  1 :: ", problems.Problem001())
		fmt.Println("Problem  2 :: ", problems.Problem002())
		fmt.Println("Problem  3 :: ", problems.Problem003())
		fmt.Println("Problem  4 :: ", problems.Problem004())
		fmt.Println("Problem  5 :: ", problems.Problem005())
		fmt.Println("Problem  6 :: ", problems.Problem006())
		fmt.Println("Problem  7 :: ", problems.Problem007())
		fmt.Println("Problem  8 :: ", problems.Problem008())
		fmt.Println("Problem  9 :: ", problems.Problem009())
		fmt.Println("Problem 10 :: ", problems.Problem010())
		fmt.Println("Problem 11 :: ", problems.Problem012())
		fmt.Println("Problem 12 :: ", problems.Problem011())
	} else {
		fmt.Println("Problem 15 :: ", problems.Problem015())
	}
}
