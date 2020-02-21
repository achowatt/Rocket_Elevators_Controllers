class Elevator:
    def fillRequestList(self):
        requestList = []
        for x in range(0, self.numFloors):
            requestList.append(False)
        return requestList

    def __init__(self,id,numberOfFloor):
        self.id = id
        self.numFloors = numberOfFloor
        self.status = 'IDLE'
        self.currentFloor = 1
        self.requestList = self.fillRequestList()

    