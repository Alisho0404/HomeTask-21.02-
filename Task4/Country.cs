class Country
{
    private string _name;
    private string _capital; 
    private int _population; 
    private string _officialLanguage;

    public Country(string name, string capital, int population, string officialLanguage)
    {
        _name = name;
        _capital = capital;
        _population = population;
        _officialLanguage = officialLanguage;
    }
    public void GetCountry(string country)
    {
        _name=country;
    } 
    public string GetCountryName()
    {
        return _name;
    }
    public void SetCapital(string capital)
    {
        _capital=capital;
    } 
    
    public string GetCapital()
    {
        return _capital;        
    } 
    
    public void SetPopulation(int population)
    {
        _population = population;
    } 
    
    public int GetPopulation()
    {
        if (_population == 0) throw new Exception("0");

        return _population;
    } 
    
    public void SetOficialLanguage(string language)
    {
        _officialLanguage = language;
    }
    
    public string GetOficialLanguage()
    {
        return _officialLanguage;
    }
}