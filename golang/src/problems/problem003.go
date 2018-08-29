package problems

import (
	"euler_math"
	"fmt"
)

func Problem003() string {
	return fmt.Sprintf("Factors: %d", euler_math.GetPrimeFactors(600851475143))
}
