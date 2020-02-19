class Elevator {
    constructor(numberOfFloors) {
        this.status = 'IDLE';  //idle or moving or opening or closing
        this.available = true; //if it's full/not
        this.currentFloor = 0; //floor 1-10
        this.requestList = Array(numberOfFloors).fill(false); //todo list[array]
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
        } 


    }

    //function chooseElevator ()


    //requestFloorOnChosenElevator()

    //move_elevator()

}


const residentialController = new Controller(2, 10)

console.log(residentialController.elevators[1])
residentialController.requestElevator('DOWN',3)


// press callButton -> gets floor and direction , find the right elevator to come,
                        //add to elevator requestList
                        //elevator moves according to requestList

// press floorRequestButtons
                // add to elevator requestList
                //elevator moves according to requestList
                
// EXTRA: press open/close door            
