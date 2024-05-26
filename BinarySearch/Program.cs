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
        int lowIndx = 0;
        int highIndx = arr.Length - 1;
        while (lowIndx <= highIndx)
        {
            int mediumIndx = lowIndx + (highIndx - lowIndx) / 2;
            if (arr[mediumIndx] == valSearch)
            {
                return mediumIndx;
            }
            else if (arr[mediumIndx] > valSearch)
            {
                highIndx = mediumIndx - 1;
            }
            else
            {
                lowIndx = mediumIndx + 1;
            }
        }
        return -1;
    }

}
