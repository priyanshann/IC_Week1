// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;



try
{
    var square = new Square(10);
    square.SetArea(2);

    Console.WriteLine("The area is " + square.GetArea());

    var circle = new Circle();

    ShapeColourHelper.AddColour(circle);
    ShapeColourHelper.AddColour(square);
    //Console.WriteLine(square.Colour);
    ShapeColourHelper.ChangeColour(square);
    //Console.WriteLine(square.Colour);
    //Console.ReadLine();
    if(circle.Colour is not null)
    {
        Console.WriteLine(circle.Colour);

    }    
    if(square.Colour is not null)
    {
        Console.WriteLine(square.Colour);   
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}









