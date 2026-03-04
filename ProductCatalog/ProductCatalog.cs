
using System;
using System.Drawing;

class Product
{
    public string Name {  get; set; }
    public int Price { get; set; }

    public override string ToString() => $"{Name} - \\{Price:N0}";

    public virtual void GetDescription() => Console.WriteLine($"기본 설명");
}

class Electronics : Product
{
    public int Warranty { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" (보증: {Warranty}개월)";
    }

    public override void GetDescription()
    {
        Console.WriteLine($"  -> 전자기기입니다. 취급에 주의하세요.");
    }
}

class Clothing : Product
{
    public char Size { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" (사이즈: {Size})";
    }

    public override void GetDescription()
    {
        Console.WriteLine($"  -> 의류입니다. 세탁 방법을 확인하세요.");
    }
}

class Food : Product
{
    public string ExpirationDate { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" (유통기한: {ExpirationDate})";
    }

    public override void GetDescription()
    {
        Console.WriteLine($"  -> 식품입니다. 냉장 보관하세요.");
    }
}