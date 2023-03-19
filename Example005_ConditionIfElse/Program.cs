Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "Дарья")
{
    Console.WriteLine("Ура, это же Дарья");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
