namespace LinearSearch;

public class Program
{
    static void Main(string[] args)
    {
        var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(LinearSearchFunction(arr, 23));
    }

    public static int LinearSearchFunction(int[] arr, int valSearch)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == valSearch)
            {
                return i; // Topilganda indeksni darhol qaytaramiz
            }
        }
        return -1; // Agar topilmasa, -1 qaytariladi
    }
}
