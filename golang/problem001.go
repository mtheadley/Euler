package main

import (
	"euler_math"
	"fmt"
)

func main() {
	maxItem := 1000

	factorsOfThreePrime := euler_math.GetSpecificFactors(maxItem, 3)
	factorsOfFivePrime := euler_math.GetSpecificFactors(maxItem, 5)

	comboArrayPrime := mergeArray(factorsOfThreePrime, factorsOfFivePrime)

	comboPrime := sum(comboArrayPrime)

	fmt.Println("SUM: ", comboPrime)
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

func determineFactors2(max int, factor int) []int {
	var result []int
	for i := 0; i < max; i++ {
		if i%factor == 0 {
			result = append(result, i)
		}
	}

	return result
}

func sum(items []int) int {
	total := 0

	for _, i := range items {
		total += i
	}

	return total
}

func printSlice(s []int) {
	fmt.Printf("len=%d cap=%d %v\n", len(s), cap(s), s)
}
