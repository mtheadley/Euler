package euler_math

import "math"

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
