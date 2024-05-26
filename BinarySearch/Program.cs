namespace BinarySearch;

public class Program
{
    static void Main(string[] args)
    {
        var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(BinarySearchFunction(arr, 9));
    }

    public static int BinarySearchFunction(int[] arr, int valSearch)
    {
        int startIndx = 0;
        int endIndx = arr.Length - 1;
        while (startIndx <= endIndx)
        {
            int mediumIndx = startIndx + (endIndx - startIndx) / 2;
            if (arr[mediumIndx] == valSearch)
            {
                return mediumIndx;
            }
            else if (arr[mediumIndx] > valSearch)
            {
                endIndx = mediumIndx - 1;
            }
            else
            {
                startIndx = mediumIndx + 1;
            }
        }
        return -1; 
    }

}
