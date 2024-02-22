class Rectangle
{
    public int Width;
    public int Height;
    public string Color;
    public int GetArea()
    {
        return Width * Height;
    }
    public int GetPerimetr()
    {
        return 2*(Width+Height);
    }
}