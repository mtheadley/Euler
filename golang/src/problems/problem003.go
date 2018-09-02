package problems

import (
	"euler_math"
	"fmt"
	"utils"
)

func Problem003() string {
	return fmt.Sprintf("%d", utils.Max(euler_math.GetPrimeFactors(600851475143)))
}
