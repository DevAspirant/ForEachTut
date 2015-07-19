using System; 

class ForEachTut
{
    public static void Main()
    {
        // Array Defination 1 
        int[] numbersDef1 = new int[5];

        // Array Defination 2
        int[] numbersDef2 = new int [] {0,2,4,8,16 };

        // string array defination 
        string[] names = new string[] {"Falmban", "Ammar","Abdulhalem", "Mohammed" };

        // Devide string 
        string zig = "you can get what you want out of life" + "if you help enough  pepole get what they want";

        char[] charArray = zig.ToCharArray();
        Array.Reverse(charArray);
        


        // Array initlization
        numbersDef1[0] = 1;
        numbersDef1[1] = 2;
        numbersDef1[2] = 3;
        numbersDef1[3] = 4;
        numbersDef1[4] = 5;

        // output 
        Console.WriteLine(numbersDef1[1].ToString());
        Console.WriteLine(numbersDef2[1].ToString());
        Console.WriteLine(numbersDef1.Length);
        Console.WriteLine(numbersDef2.Length);


        // foreach loop 
        foreach (string StrOutput in names)
        {
            Console.WriteLine(StrOutput);
        }

        foreach (char zigChar in charArray)
            Console.Write(zigChar);
    }
}
