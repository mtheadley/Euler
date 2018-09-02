package problems

import (
	"fmt"
	"math"
)

func Problem009() string {
	return fmt.Sprintf("%d", crunchNumber(1000))
}

func crunchNumber(sum int) int {
	for a := 1; a <= sum; a++ {
		for b := 1; b <= sum; b++ {
			c2 := (a * a) + (b * b)

			c := math.Sqrt(float64(c2))

			// fmt.Printf("a: %d b: %d c: %d c2:%d\n", a, b, int(c), c2)
			if int(math.Ceil(c)) == int(math.Floor(c)) && a < b && b < c2 {
				// fmt.Printf(" :: sum :: %d\n", a+b+int(c))
				if a+b+int(c) == sum {
					return (a * b * int(c))
				}
			}
		}
	}

	return 0
}
