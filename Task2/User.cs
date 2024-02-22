 class User
{
    public string FirstName; 
    public string LastName;
    public string UserName;
    public string Password;
    public bool IsLoggedIN;
     public void Login(string userName, string password) 
    {
        if (userName==UserName && password==Password)
        {
            Console.WriteLine("Пользователь успешно зарегистрирован"); 
            IsLoggedIN = true;
        }
        else
        {
            Console.WriteLine("Ваш пароль или имя пользователя неверны");
        }
    } 
    public void Logout() 
    { 
        IsLoggedIN=false;
    }
    public void GetFullInfo() 
    {
        
        Console.WriteLine($"{FirstName} {LastName} {IsLoggedIN}");
    }
}