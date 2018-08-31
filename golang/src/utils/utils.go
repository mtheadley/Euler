package utils

func Max(v []int) int {
	max := 0

	for _, e := range v {
		if e > max {
			max = e
		}
	}

	return max
}
