package utils

import "fmt"

func PrintSlice(s []int) string {
	return fmt.Sprintf("len=%d cap=%d %v\n", len(s), cap(s), s)
}
