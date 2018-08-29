package problems

import (
	"euler_math"
	"fmt"
	"utils"
)

func Problem005() string {
	getPrimes(12)
	return "SLACKER 2"
}

// func getPrimes(value int) map[int]int {
func getPrimes(value int) {
	primes := euler_math.GetPrimeFactors(value)

	fmt.Println(utils.PrintSlice(primes))
}
