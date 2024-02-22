class Author
{
    private string _name;
    private int _age;
    private string _nationality;

    public Author()
    {
        _name = "Alex"; 
        _age = 0;
        _nationality = "Tajik";
    }
    public Author(string name, int age)
    {
        _name = name;
        _age = age;
    }
    public Author(string name, int age, string nationality)
    {
        _name = name;
        _age = age;
        _nationality = nationality;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetAge()
    {
        return _age;
    }
    public string GetNationality()
    {
        return _nationality;
    }
    public void Introduce() 
    {
        Console.WriteLine($"Меня зовут {_name}. Мне {_age} лет. Я из {_nationality}.");
    }
    public void CelebrateBirthday() 
    {
        _age++;
        
    }
}