using System;

class Program
{
    static void Main()
    {
        Console.Write("?? Matn kiriting: ");
        string input = Console.ReadLine().ToLower().Replace(" ", ""); // Katta-kichik farqsiz, bo'sh joylarni olib tashlaymiz
        
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        if (input == reversed)
            Console.WriteLine("? Bu matn PALINDROM!");
        else
            Console.WriteLine("? Bu matn palindrom EMAS!");
    }
}
