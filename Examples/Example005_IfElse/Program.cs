Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower()=="витя")
{
    Console.WriteLine("Ура! Это же Витя!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}