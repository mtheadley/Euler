package problems

import (
	"euler_math"
	"fmt"
)

func Problem006() string {
	count := 100
	soSquare := euler_math.SumOfSquares(count)
	soSums := euler_math.SquareOfSums(count)

	// fmt.Println("Sum of squares: ", soSquare)
	// fmt.Println("Square of sums: ", soSums)

	return fmt.Sprintf("Difference: %d", soSums-soSquare)
}

func sumOfSquares(count int) int {
	sum := 0
	for i := 1; i <= count; i++ {
		sum += i * i
	}

	return sum
}

func squareOfSums(count int) int {
	sum := 0

	for i := 1; i <= count; i++ {
		sum += i
	}

	return sum * sum
}
