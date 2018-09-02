package problems

import (
	"euler_math"
)

func Problem005() string {
	//return fmt.Sprintf("%d", determineSmallestMultiple(10))
	return "NOPE"
}

func determineSmallestMultiple(highestNumber int) int {
	num1 := 1
	num2 := 0
	for i := 1; i <= highestNumber; i++ {
		num2 = i

		//fmt.Println("LCM: ", euler_math.LeastCommonMultiple(num1, num2), num1, num2)
		num1 = euler_math.LeastCommonMultiple(num1, num2)
	}

	return num1
}
