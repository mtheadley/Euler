package problems

import (
	"euler_math"
	"fmt"
)

func Problem010() string {
	return fmt.Sprintf("%d", sumOfPrimes(2000000))
}

func sumOfPrimes(number int) int {
	total := 0
	for i := 1; i <= number; i++ {
		if euler_math.IsPrime(i) {
			total += i
		}
	}

	return total
}
