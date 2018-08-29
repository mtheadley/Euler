package problems

import "fmt"

func Problem002() string {
	return fmt.Sprintf("Total: %d", fibbo(4000000))
}

func fibbo(termToStopOn int) int {
	sum := 0
	result := 0
	prevNum := 0
	currentNum := 1

	for {
		if result%2 == 0 {
			sum += result
		} else {
			sum += 0
		}

		result = prevNum + currentNum
		prevNum = currentNum
		currentNum = result

		if sum >= termToStopOn {
			break
		}
	}

	return sum
}
