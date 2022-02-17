namespace selectionsortcsharp{
    
    static void Main(string[] args)
    {
        int[] arr={22,5,98,85,6,14,47,16,3,1,8,23,-67,-9};// n elemanlı bir dizi oluşturduk
        int  temp=0;

        for (int i =0; i<arr.Length;i++)
        {
            for(int j=i; j<arr.Length;j++)
            {
                if(arr[i]>arr[j])
                {
                    temp=arr[j];
                    arr[j]=arr[i];
                    arr[i]=temp;
                }
            }
        }
        foreach( int i in arr)
        {
            Console.Writeline(i);
        }
    }
}



