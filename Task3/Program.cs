// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l “World” => W r l d 

// void PrintConsonants(string str, int count)
// {
//     if (count == str.Length) return;
//     string vowels = "aouiey";
//     if(char.IsAsciiLetter(str[count]) && !vowels.Contains(char.ToLower(str[count])))
//     {
//         Console.Write(str[count] + " ");
//     }

//     PrintConsonants(str, count + 1);
// }


// Console.WriteLine("Введите строку латинскими буквами");
// string userInput = Console.ReadLine();
// int posStr = 0;
// PrintConsonants(userInput, posStr);

void PrintConsonants(string str)
{
    
        
    if (str.Length == 0) return;
    string vowels = "aouiey";
    if (char.IsAsciiLetter(str[0]) && !vowels.Contains(char.ToLower(str[0])))
    {
        Console.Write(str[0] + " ");
    }

    PrintConsonants(str.Substring(1));
}


Console.WriteLine("Введите строку латинскими буквами");
string userInput = Console.ReadLine();
int posStr = 0;
PrintConsonants(userInput);