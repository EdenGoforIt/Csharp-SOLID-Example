var rec = new Rectangle(3, 4);
var square = new Square(3);
Console.WriteLine("Rectangle: {0}", rec.Area().ToString()); //😀😀Okay, makes sense
Console.WriteLine("Square: {0}", square.Area().ToString()); //😀😀 now square is happy


public abstract class Shape
{
    public abstract int Area();
}

public class Rectangle : Shape
{
    private int _height { get; set; }
    private int _width { get; set; }

    public Rectangle(int height, int width) : base()
    {
        this._height = height;
        this._width = width;
    } 

    public override int Area()
    {
        return _height * this._width;
    }
}
public class Square : Shape
{
    private int _side;
    public Square(int side) : base()
    {
        this._side = side;
    }
    public override int Area()
    {
        return _side * _side;
    }
}


// internal class Rectangle
// {
//     private int _height { get; set; }
//     private int _width { get; set; }
//     internal Rectangle(int height, int width)
//     {
//         this._height = height;
//         this._width = width;
//     } 

//     internal int Area => this._height * this._width;
// }
// internal class Square : Rectangle
// {
//     internal Square(int height, int width):base( height,  width)
//     {

//     }
// }