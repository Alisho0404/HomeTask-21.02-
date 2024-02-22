 var user = new User()
{
    UserName = "Alex",
    Password = "softclub",
    LastName = "Sholangarov",
    FirstName="Alisho"

};
Console.Write("Enter first name: ");
string firstName=Console.ReadLine();
Console.Write("Enter password: ");
string password=Console.ReadLine();
Console.WriteLine();
user.Login(firstName, password);
user.GetFullInfo();