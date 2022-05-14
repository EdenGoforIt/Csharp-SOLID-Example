// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public interface ICar
{
    void Drive();
}

public interface IAirplane
{
    void Fly();
}

public class Car : ICar
{
    public void Drive()
    { 
    }
}

public class Airplane : IAirplane
{
    public void Fly()
    { 
    }
}



//public interface IVehicle
//{
//    void Fly();
//    void Drive();
//}

////😡😡 Hey I can't fly at the moment!!!
//public class Car : IVehicle
//{
//    public void Fly()
//    {
//    }

//    public void Drive()
//    { 
//    }
//}

////😡😡 Hey I can't drive!!!
//public class Airplane : IVehicle
//{
//    public void Fly()
//    { 
//    }

//    public void Drive()
//    { 
//    }
//}


