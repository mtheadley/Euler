package problems

import (
	"euler_math"
	"fmt"
)

func Problem001() string {
	maxItem := 1000

	factorsOfThreePrime := euler_math.GetSpecificFactors(maxItem, 3)
	factorsOfFivePrime := euler_math.GetSpecificFactors(maxItem, 5)

	comboArrayPrime := mergeArray(factorsOfThreePrime, factorsOfFivePrime)

	comboPrime := sum(comboArrayPrime)

	return fmt.Sprintf("Sum: %d", comboPrime)
}

func mergeArray(arrayOne []int, arrayTwo []int) []int {
	result := arrayOne

	for _, i := range arrayTwo {
		if !contains(result, i) {
			result = append(result, i)
		}
	}

	return result

}

func contains(s []int, e int) bool {
	for _, a := range s {
		if a == e {
			return true
		}
	}
	return false
}

func sum(items []int) int {
	total := 0

	for _, i := range items {
		total += i
	}

	return total
}
