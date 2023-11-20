Console.WriteLine("Your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha") // операция tolower переводит все символы строки в нижний регистр
{
    Console.WriteLine("Yess! This is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}