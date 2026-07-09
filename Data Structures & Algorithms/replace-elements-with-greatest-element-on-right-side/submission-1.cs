public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int count=-1;
        arr[0]=-1;
        for(int i=0;i<arr.Length-1; i++)
        {
            if(arr[i+1]>arr[i])
            {
                count=i;
                while(count>=0)
                {
                    arr[count]=arr[i+1];
                    --count;
                    if(count>=0 && arr[count]>arr[i+1])
                    {
                        break;
                    }
                }
                arr[i+1]=-1;
            }
        }
        //arr[arr.Length-1]=-1;
        return arr;
    }
}