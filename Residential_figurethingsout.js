class Elevator {
    constructor(id, numberOfFloors) {
        this.id = id
        this.status = 'IDLE' //'UP','DOWN','MAINTENANCE'; 
        this.currentFloor = 1 //floor 1-10
        this.requestList = Array(numberOfFloors).fill(false) //todo list[array]
    }

    //methods
    requestFloor(floor) {
        if (floor === undefined || !Number.isInteger(floor)) {
            console.error('Error: floor must be a number')
            return
        } else if (floor > this.requestList.length || floor < 1) {
            console.error(`Error: floor ${floor} does not exist`)
            return
        }

        this.requestList[floor - 1] = true
    }

    showButtons() {
        this.requestList.forEach((status, index) => {
            console.log(`${index + 1}: ${status ? 'ON' : 'OFF'}`)
        })
        console.log('\n')
    }

    moveElevator(floor) {
                if (this.currentFloor < floor){
                    this.status = 'UP'
                    while (this.currentFloor < floor) {
                        this.currentFloor++;
                        this.requestList[floor-1] = false;
                    }
                    this.status = 'IDLE'
                } else if (this.currentFloor > floor) {
                    this.status ='DOWN'
                    while (this.currentFloor < floor) {
                        this.currentFloor--;
                        this.requestList[floor-1] = false;
                    }
                    this.status = 'IDLE'
                }
    }
    
    
}

class Controller {
    constructor(numberOfElevators, numberOfFloors) {
        this.elevators = []
        for (let i = 0; i < numberOfElevators; i++) {
            this.elevators.push(new Elevator(i, numberOfFloors))
        }
    }

    //methods 
    requestElevator(direction, floor) {
        if (floor === undefined || !Number.isInteger(floor)) {
            console.error('Error: floor must be a number')
            return
        } else if (floor > this.numberOfFloors || floor < 1) {
            console.error(`Error: floor ${floor} does not exist`)
            return
        } else if (floor === 1 && direction === 'DOWN') {
            console.error(`Error: You can't go down from first floor!`)
            return
        } else if (floor === this.numberOfFloors && direction === 'UP') {
            console.error(`Error: You can't go up from ${this.numberOfFloors}`)
        } else {
            const id = this.selectElevator(direction, floor)
            this.elevators[id].requestFloor(floor)
            this.elevators[id].moveElevator(floor)
        }
    }

    selectElevator(direction, floor) {
        let selectedElevatorId = null

        // step 1: find available elevators = this.elevators
        const availableElevators = this.elevators.filter((elevator) => elevator.status !== 'MAINTENANCE')

        // step 2: choose the closest elevator (if it's moving towards the call button)
        //upElevators
        const upElevators = availableElevators.filter(elevator => {
            return elevator.status === 'UP' && elevator.currentFloor <= floor
        })

        //downElevators
        const downElevators = availableElevators.filter(elevator => {
            return elevator.status === 'DOWN' && elevator.currentFloor >= floor
        })

        let difference = 999
        upElevators.forEach(elevator => {
            if (floor - elevator.currentFloor < difference) {
                difference = floor - elevator.currentFloor
                selectedElevatorId = elevator.id 
            }
        })
        
        downElevators.forEach(elevator=>{
            if (elevator.currentFloor - floor < difference) {
                difference = floor - elevator.currentFloor
                selectedElevatorId = elevator.id
            }
        })

        // step 3: choose the closest idle elevator
        //idleElevators
        const idleElevators = availableElevators.filter((elevator) => elevator.status === 'IDLE')
        idleElevators.forEach(elevator=>{
            if (Math.abs(elevator.currentFloor - floor) < difference) {
                difference = floor - elevator.currentFloor
                selectedElevatorId = elevator.id
            }
        })

        // step 4: choose the elevator with last item on requestList that's closest to request floor
        //upElevators_  *not on the way as button*
        const upElevators_ = availableElevators.filter(elevator=>{
            return elevator.status === 'UP' && elevator.currentFloor > floor
        })

        //downElevators_ *not on the way as button*
        const downElevators_ = availableElevators.filter(elevator=>{
            return elevator.status === 'DOWN' && elevator.currentFloor < floor
        })

        var index;
        upElevators_.forEach(elevator=>{
            for (var x = 0; x < elevator.requestList.length; x++)
            {   if (elevator.requestList[x] === true) {
                    index = x;
                }
            
                if (Math.abs((x + 1) - floor) < difference) {
                    difference = floor - elevator.currentFloor
                    selectedElevatorId = elevator.id
                }
            }
            
        })

        downElevators_.forEach(elevator=>{
            for (var x = 0; x < elevator.requestList.length; x++)
            {   if (elevator.requestList[x] === true) {
                    index = x;
                    break;
                }
                if (Math.abs((x + 1) - floor) < difference) {
                    difference = floor - elevator.currentFloor
                    selectedElevatorId = elevator.id
                }
            }
        })

        // return selected elevator
        return selectedElevatorId
    }
}

const residentialController = new Controller(2, 10)

// modify one elevator to be in maintenance
residentialController.elevators[0].currentFloor = 1
residentialController.elevators[0].status = 'IDLE'

residentialController.elevators[1].status = 'IDLE'
residentialController.elevators[1].currentFloor = 1

console.log(residentialController.elevators)
//show elevator currentFloor
console.log('---after call---')
residentialController.requestElevator('DOWN', 10)
residentialController.requestElevator('UP',2)

console.log(residentialController.elevators)

// press floorRequestButtons
                // add to elevator requestList
                //elevator moves according to requestList
                
// EXTRA: press open/close door            
