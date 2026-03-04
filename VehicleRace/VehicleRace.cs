
using System;

class Vehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public virtual void Move() => Console.WriteLine($"{Name}(이)가 이동합니다. 속도: {Speed}km/h");
}

class Car : Vehicle
{
    public Car()
    {
        Speed = 120;
    }

    public override void Move() => Console.WriteLine($"{Name}(이)가 도로를 달립니다. 속도: {Speed}km/h");
}

class Airplane : Vehicle
{
    public Airplane()
    {
        Speed = 900;
    }
 
    public override void Move() => Console.WriteLine($"{Name}(이)가 하늘을 납니다. 속도: {Speed}km/h");
}

class Boat : Vehicle
{
    public Boat()
    {
        Speed = 60;
    }

    public override void Move() => Console.WriteLine($"{Name}(이)가 바다를 항해합니다. 속도: {Speed}km/h");
}