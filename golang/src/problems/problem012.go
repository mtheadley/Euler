package problems

import (
	"euler_math"
	"fmt"
)

func Problem012() string {
	// counter := 0
	return fmt.Sprintf("%d", doWork(500))
}

func doWork(numOfDivisors int) int {
	index := 0
	for {
		index += 1
		triagNumber := calcTriangleNumber(index)
		factors := euler_math.GetAllFactors(triagNumber)

		if len(factors) >= numOfDivisors {
			return triagNumber
		}
	}

}

func calcTriangleNumber(count int) int {
	total := 0

	for i := 1; i <= count; i++ {
		total += i
	}

	return total
}
