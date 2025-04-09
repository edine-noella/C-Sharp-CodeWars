// See https://aka.ms/new-console-template for more information

using C_Sharp_CodeWars;

// Console.WriteLine(Kyu8.FinalGrade(90,8));
// Console.WriteLine(Kyu7.CountingInAmazon(3));
// Console.WriteLine(Kyu8.reverseString("edine"));
// Console.WriteLine(Kyu8.Capitalize("edine"));
// Console.WriteLine(Kyu7.SumOddNumbers(5));
// Kyu7.CountVowels("edine noella");
// Console.WriteLine(Kyu7.GetMiddle("edine"));
// Console.WriteLine(Kyu7.AddUniqueNumbers([1, 2, 3, 4, 5, 5]));
int[] squared = Kyu7.SquareEveryNumber([1, 2, 3, 4, 5]);
foreach(int i in squared)
{
    Console.WriteLine(i);
}