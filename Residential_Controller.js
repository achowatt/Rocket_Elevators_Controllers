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
    constructor(numberOfFloors) {
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
        this.elevators = Array(numberOfElevators).fill(new Elevator(numberOfFloors))
    }

    //methods 
    requestElevator(direction,floor) {
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
            // step 1: find available elevators = this.elevators
            const availableElevators = this.elevators.filter((elevator) => elevator.status !== 'MAINTENANCE')

            console.log(availableElevators)
        }
    }
}

const residentialController = new Controller(2, 10)

// modify one elevator to be in maintenance
residentialController.elevators[0].status = 'MAINTENANCE';
console.log(residentialController.elevators)

//residentialController.requestElevator('DOWN',3)

// press callButton -> gets floor and direction , find the right elevator to come,
                        //add to elevator requestList
                        //elevator moves according to requestList

// press floorRequestButtons
                // add to elevator requestList
                //elevator moves according to requestList
                
// EXTRA: press open/close door            


