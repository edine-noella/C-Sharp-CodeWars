namespace C_Sharp_CodeWars;

public class Kyu7
{
    public static string CountingInAmazon(int number)
    {
        string result;
        string[] counting = { "anane", "adak" };
        if (number == 1)
        {
            result = counting[0];
        }
        else if (number % 2 == 0)
        {
            result = string.Join(" ", Enumerable.Repeat(counting[1], number / 2));
        }
        else
        {
            result = string.Join(" ", Enumerable.Repeat(counting[1], number / 2));
            result += $" {counting[0]}";
        }
        return result;
    }

    public static int SumOddNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i += 2)
        {
            sum += i;
        }
        return sum;
    }

    public static void CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }
        Console.WriteLine($"Number of vowels in {str} is {count}");
    }

    public static char GetMiddle(string s)
    {
        int length = s.Length;
        if (length % 2 == 0)
        {
            return s[length / 2 - 1];
        }
        else
        {
            return s[length / 2];
        }
    }

        public static int AddUniqueNumbers(int[] numbers)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers); // Use HashSet to store unique numbers
        int sum = 0;
        foreach (int number in uniqueNumbers)
        {
            sum += number;
        }
        return sum;
    }

      public static int[] SquareEveryNumber(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= numbers[i];
        }
        return numbers;
    }

}