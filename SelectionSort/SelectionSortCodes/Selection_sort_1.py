#Selection sort example

def SelSort(arr):
    for i in range (len(arr)):
        min_inndex=i
        for j in range(i+1,len(arr)):
            if arr[min_inndex]>arr[j]:
                min_inndex=j

        if min_inndex !=i:
            arr[min_inndex],arr[i]=arr[i],arr[min_inndex]

array1=[6,8,15,4,7]
SelSort(array1)
print(array1)
