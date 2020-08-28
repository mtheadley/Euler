package problems

import (
	"euler_math"
	"fmt"
)

func Problem015() string {
	// counter := 0
	// (40)
	// (20)
	//40 choose 20 :: combinatorics
	//https://www.hackmath.net/en/calculator/combinations-and-permutations?n=40&k=20&order=0&repeat=0
	// findFactorial(40)
	return fmt.Sprintf("%v", combo(40))
	// return fmt.Sprintf("%v", findPaths(35))
}

func findPaths(size uint64) uint64 {
	output := euler_math.Factorial(size) / (euler_math.Factorial(size/2) * euler_math.Factorial(size/2))

	return output
}

func findFactorial(value uint64) {
	fact := euler_math.Factorial(value)

	fmt.Printf("%v", fact)
}

func combo(value uint64) uint64 {
	top := euler_math.Factorial(value)
	bottom := euler_math.Factorial(value/2) * euler_math.Factorial(value/2)
	fmt.Printf("40! :: %v\n\n", top)
	fmt.Printf("20! * 20! :: %v\n\n", bottom)

	return top / bottom
}
