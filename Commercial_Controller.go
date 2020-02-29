package main

import (
	"fmt"
)

/*****************************************/
type Elevator struct {
	ID, CurrentFloor int
	Status           string
	Door             string
	RequestList      []int
}

/*****************************************/
type Column struct {
	ID, NumberOfFloors int
	El                 []Elevator
}

func main() {
	fmt.Println("Commercial Building || ROCKET ELEVATORS")
	fmt.Println("My four columns and their elevators:")
	col1 := Column{
		ID:             0,
		NumberOfFloors: 7,
		El: []Elevator{
			{
				ID: 0, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 1, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 2, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 3, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 5, Status: "IDLE", CurrentFloor: 1,
			},
		},
	}
	fmt.Println(col1)

	col2 := Column{
		ID:             1,
		NumberOfFloors: 21,
		El: []Elevator{
			{
				ID: 0, Status: "IDLE", CurrentFloor: 1, RequestList: []int{},
			},
			{
				ID: 1, Status: "IDLE", CurrentFloor: 1, RequestList: []int{},
			},
			{
				ID: 2, Status: "IDLE", CurrentFloor: 1, RequestList: []int{},
			},
			{
				ID: 3, Status: "IDLE", CurrentFloor: 1, RequestList: []int{},
			},
			{
				ID: 5, Status: "IDLE", CurrentFloor: 1, RequestList: []int{},
			},
		},
	}
	fmt.Println(col2)
	col3 := Column{
		ID:             2,
		NumberOfFloors: 21,
		El: []Elevator{
			{
				ID: 0, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 1, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 2, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 3, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 5, Status: "IDLE", CurrentFloor: 1,
			},
		},
	}
	fmt.Println(col3)

	col4 := Column{
		ID:             3,
		NumberOfFloors: 21,
		El: []Elevator{
			{
				ID: 0, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 1, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 2, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 3, Status: "IDLE", CurrentFloor: 1,
			},
			{
				ID: 5, Status: "IDLE", CurrentFloor: 1,
			},
		},
	}
	fmt.Println(col4)

}
