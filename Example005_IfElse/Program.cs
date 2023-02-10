Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower == "Маша")
{
    Console.Write("Это же Маша! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
};
