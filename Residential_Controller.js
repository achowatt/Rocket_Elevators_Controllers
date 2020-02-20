//TURN ON POWER
var init = prompt("Type 1 to initialize: ")
while (init !== "1") {
    init = prompt("Press 1 now to initialize!")
    if (init ==="1") {
    } else {
        init = prompt("Press 1 to continue!")
    }
}

//Once the user initializes
alert("POWER ON")

// 50% chance of battery of being "low"
var batteryLife = Math.random();
batteryLife = batteryLife * 2;
batteryLife = Math.floor(batteryLife);

if (batteryLife === 0) {
    alert("*RED FLASHING LIGHT* Low Battery!")
    var changeBattery = window.confirm("Do you want to change battery?")
    if (changeBattery) {
        alert("Battery CHANGED!")
    } else {
    alert("Battery CHANGED!")
    init = prompt("Type 1 to initialize: ")
    while (init !== "1") {
        init = prompt("Press 1 now to initialize!")
        if (init ==="1") {
        } else {
        init = prompt("Press 1 to continue!")
        }
    }
        alert("POWER ON")
        alert("Battery FULL")
    }

} else {
    alert("Battery FULL")
}

/*-----------------------------------------------------*/
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

        //idleElevators
        const idleElevators = availableElevators.filter((elevator) => elevator.status === 'IDLE')

        let difference = 999
        upElevators.forEach(elevator => {
            if (floor - elevator.currentFloor < difference) {
                difference = floor - elevator.currentFloor
                selectedElevatorId = elevator.id 
            }
        })
        

        // step 3: choose the closest idle elevator
        // step 4: choose the elevator with last item on requestList that's closest to request floor
        // return selected elevator
        return selectedElevatorId
    }
}

const residentialController = new Controller(2, 10)

// modify one elevator to be in maintenance
residentialController.elevators[0].status = 'UP'
residentialController.elevators[0].currentFloor = 3
residentialController.elevators[1].status = 'UP'

console.log(residentialController.elevators)
console.log('---after call---')

residentialController.requestElevator('UP', 5)

console.log(residentialController.elevators)
// press callButton -> gets floor and direction , find the right elevator to come,
                        //add to elevator requestList
                        //elevator moves according to requestList

// press floorRequestButtons
                // add to elevator requestList
                //elevator moves according to requestList
                
// EXTRA: press open/close door            
