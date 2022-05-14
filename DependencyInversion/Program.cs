var wrap = new CandyWrap(); 

var candyFactory = new CandyFactory(wrap)
{ 
};

candyFactory.CreateCandy();

var marshmallowWrap = new MarshmallowWrap();

var marshmallowWrapFactory = new CandyFactory(marshmallowWrap)
{
};

marshmallowWrapFactory.CreateCandy();

// public class CandyFactory
// {
//    private CandyWrap _wrap;

//    public CandyFactory(CandyWrap wrap)
//    {
//        _wrap = wrap;
//    }
//    public void CreateCandy()
//    {
//        Console.WriteLine("Shape Candy");
//        Console.WriteLine("Put Flavors"); 
//        _wrap.Tie();
//    }
// }

// public class CandyWrap
// {
//   public void Tie()
//    {
//        Console.WriteLine("Candies have been tied");
//    }
// }

public interface WrapService
{
    void Tie();
}
public class CandyWrap: WrapService
{
    public void Tie()
    {
        Console.WriteLine("Candies have been tied");
    }
}

public class MarshmallowWrap : WrapService
{
    public void Tie()
    {
        Console.WriteLine("Mashmallow have been tied");
    }
}

public class CandyFactory
{
    private WrapService _wrap;

    public CandyFactory(WrapService wrap)
    {
        _wrap = wrap;
    }
    public void CreateCandy()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("Shape Candy");
        Console.WriteLine("Put Flavors");
        _wrap.Tie();
         Console.WriteLine("=====================================");
    }
}
