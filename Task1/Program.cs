 var rectangle = new Rectangle();
Console.Write("Enter width: ");
rectangle.Width = int.Parse(Console.ReadLine());

Console.Write("Enter height: ");
rectangle.Height = int.Parse(Console.ReadLine());
//rectangle.Color = "Red"; 
Console.WriteLine();

Console.WriteLine("Area= "+rectangle.GetArea());
Console.WriteLine("Perimetr= "+rectangle.GetPerimetr());
