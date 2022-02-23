def printFun(test):
    if(test<1):
        return
    else:
        print(test,end=" ")
        printFun(test-1)#statement2
        print(test,end=" ")
        return
#Driver code
test=4
printFun(test)