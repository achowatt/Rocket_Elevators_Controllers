package main

import "fmt"

func main() {
	a, b := 1, 3
	switch a + b {
	case 1:
		fmt.Println("Sum is 1")
	case 2:
		fmt.Println("Sum is 2")
	case 3:
		fmt.Println("Sum is 3")
	case 4:
		fmt.Println("Sum is 4")
	default:
		fmt.Println("Printing default")
	}
}
