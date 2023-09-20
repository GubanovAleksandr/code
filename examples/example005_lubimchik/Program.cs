Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Саша"
)
{
    Console.WriteLine("Ура это же Саша!");
}
else
{
Console.Write("Привет!,");
Console.Write(username);
}