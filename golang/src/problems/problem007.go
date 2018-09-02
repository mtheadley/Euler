package problems

import (
	"euler_math"
	"fmt"
)

func Problem007() string {
	// return fmt.Sprintf("%f", locatePrimeValue(10001))
	return fmt.Sprintf("NOPE")
}

func locatePrimeValue(value int) int {
	currentPrimeCount := 0
	currentValue := 0
	for i := 0; ; i++ {
		if value == currentPrimeCount {
			return currentValue
		}

		if euler_math.IsPrime(i) {
			currentValue = i
			currentPrimeCount++
		}
	}
}
