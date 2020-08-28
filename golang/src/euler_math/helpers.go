package euler_math

import (
	"fmt"
	"intersect"
	"math"
	"utils"
)

func GetAllFactors(value int) []int {
	var result []int

	var sqrt = int(math.Ceil(math.Sqrt(float64(value))))

	for i := 1; i < sqrt; i++ {
		if value%i == 0.0 {
			result = append(result, i)
			result = append(result, value/i)
		}
	}

	if sqrt*sqrt == value {
		result = append(result, sqrt)
	}

	return result
}

func LeastCommonMultiple(num1 int, num2 int) int {
	fmt.Println("LCM: ", num1, num2)
	return (num1 * num2) / GreatestCommonDivisor(num1, num2)
}

func GreatestCommonDivisor(num1 int, num2 int) int {
	factors1 := GetAllFactors(num1)
	factors2 := GetAllFactors(num2)
	max := 0

	fmt.Println("*****")
	fmt.Println("GCM: ", num1, num2)
	fmt.Println("Factors 1: ", fmt.Sprintf("%v\n", factors1))
	fmt.Println("Factors 2: ", fmt.Sprintf("%v\n", factors2))

	if commonFactors, ok := intersect.Sorted(factors1, factors2).([]int); ok {
		fmt.Println("Slice: " + fmt.Sprintf("%v\n", commonFactors))
		fmt.Println("max: ", utils.Max(commonFactors))
		max = utils.Max(commonFactors)
	} else {
		fmt.Println("Uh-oh ", commonFactors)
	}
	fmt.Println("*****")

	return max
}

func GetSpecificFactors(max int, factor int) []int {
	var result []int
	for i := 0; i < max; i++ {
		if i%factor == 0 {
			result = append(result, i)
		}
	}

	return result
}

func GetPrimeFactors(value int) []int {
	var primeFactors []int

	var factors = GetAllFactors(value)

	for _, i := range factors {
		if IsPrime(i) {
			primeFactors = append(primeFactors, i)
		}
	}

	return primeFactors
}

func IsPrime(value int) bool {
	var factors = GetAllFactors(value)

	if len(factors) == 2 {
		return true
	}

	return false
}

func SumOfSquares(count int) int {
	sum := 0
	for i := 1; i <= count; i++ {
		sum += i * i
	}

	return sum
}

func SquareOfSums(count int) int {
	sum := 0

	for i := 1; i <= count; i++ {
		sum += i
	}

	return sum * sum
}

func Factorial(n uint64) (result uint64) {
	if n > 0 {
		result = n * Factorial(n-1)
		return result
	}
	return 1
}
