namespace C_Sharp_CodeWars;

public class Kyu8 {
    
    public static int FinalGrade(int exam, int projects)
    {
        int  finalGrade = 0;
        
        if (exam > 90 && projects > 10)
        {
            finalGrade = 100;
        } else if (exam > 75 && projects >= 5)
        {
            finalGrade = 90;
        }else if (exam > 50 && projects >= 2)
        {
            finalGrade = 75;
        }
        else
        {
            finalGrade = 0;
        }
            
        return finalGrade;
    }

    public static string reverseString(string str)
    {
        char[] words=  str.Reverse().ToArray(); //reverse returns an IEnumerable generic type
        return string.Join("", words);
        
    }

    public static string Capitalize(string str)
    {
        return str.Substring(0, 1).ToUpper() + str.Substring(1);
    }
    
}