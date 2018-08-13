package main

import (
	"euler_math"
	"fmt"
)

func main() {
	fmt.Println("Total: ", euler_math.GetPrimeFactors(600851475143))
}

func printSlice(s []int) {
	fmt.Printf("len=%d cap=%d %v\n", len(s), cap(s), s)
}
