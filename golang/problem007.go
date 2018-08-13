package main

import (
	"euler_math"
	"fmt"
)

func main() {
	fmt.Println("Value:  ", locatePrimeValue(10001))
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
