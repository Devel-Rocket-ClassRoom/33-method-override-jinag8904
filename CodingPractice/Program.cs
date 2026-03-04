using System;
using System.Reflection.Emit;

// 1-1.
{
    new Parent().Work();
    new Child().Work();
}
Console.WriteLine();

// 1-2.
{
    Animal a = new Animal();
    Animal c = new Cat();

    a.Eat();
    c.Eat();
}
Console.WriteLine();

// 2.
{
    Child2 c = new();
    Parent2 c2 = new Child2();

    c.Say();
    c.Run();
    c.Walk();

    Console.WriteLine();

    c2.Say();
    c2.Run();
    c2.Walk();
}
Console.WriteLine();

// 3-1.
{
    Calculator c = new();
    c.Add(1, 2);
    c.Add(1.0, 3.0);
    c.Add(1, 2, 3);
}
Console.WriteLine();

// 3-2.
{
    Animal3 a = new();
    Animal3 d = new Dog3();
    Animal3 c = new Cat3();

    a.Speak();
    d.Speak();
    c.Speak();
}
Console.WriteLine();

// 4-1.
{
    Parent4_1 c = new Child4_1();
    c.Greet();
}
Console.WriteLine();

// 4-2.
{
    Parent4_2 p = new();
    Parent4_2 c = new Child4_2();
    Parent4_2 g = new GrandChild();

    p.Work();
    c.Work();
    g.Work();
}
Console.WriteLine();

// 5.
{
    Parent5 p = new();
    Child5 c = new Child5();
    GrandChild5 g = new GrandChild5();

    p.Work();
    c.Work();
    g.Play();
}
Console.WriteLine();

// 6-1.
{
    Person p = new();
    Console.WriteLine(p);
    Console.WriteLine(p.ToString());
}
Console.WriteLine();

// 6-2.
{
    Person6 p = new();
    Console.WriteLine(p);
}
Console.WriteLine();

// 6-3.
{
    Character c1 = new("용사", 10, 100);
    Character c2 = new("마법사", 8, 70);

    Console.WriteLine(c1);
    Console.WriteLine(c2);
}
Console.WriteLine();

// 7-1.
{
    Character7 c1 = new Warrior { Name = "전사", AttackPower = 50 };
    Character7 c2 = new Mage { Name = "마법사", AttackPower = 30 };
    Character7 c3 = new Archer { Name = "궁수", AttackPower = 40 };

    Console.WriteLine(c1);
    Console.WriteLine(c2);
    Console.WriteLine(c3);

    c1.Attack();
    c2.Attack();
    c3.Attack();
}
Console.WriteLine();

// 7-2.
{
    Character7[] characters =
    {
        new Warrior { Name = "전사", AttackPower = 50 },
        new Mage { Name = "마법사", AttackPower = 30 },
        new Archer { Name = "궁수", AttackPower = 40 }
    };

    foreach (Character7 character in characters)
    {
        character.Attack();
    }
}
Console.WriteLine();

// 7-1.
class Character7
{
    public string Name;
    public int AttackPower;

    public virtual void Attack() => Console.WriteLine($"{Name}(이)가 공격합니다");
    
    public override string ToString() => $"[{Name}] 공격력: {AttackPower}";
}

class Warrior : Character7
{
    public override void Attack() => Console.WriteLine($"{Name}(이)가 칼로 베어냅니다. 데미지: {AttackPower}");
}

class Mage : Character7
{
    public override void Attack() => Console.WriteLine($"{Name}(이)가 파이어볼을 시전합니다. 데미지: {AttackPower * 2}");
}

class Archer : Character7
{
    public override void Attack() => Console.WriteLine($"{Name}(이)가 화살을 쏩니다. 데미지: {AttackPower}");
}

// 6-3.
class Character
{
    public string Name;
    public int Level;
    public int Health;

    public Character(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public override string ToString() => $"[{Name}] Lv.{Level} HP:{Health}";
}

// 6-2.
class Person6
{
    public string Name = "박용준";

    public override string ToString() => $"[Person 클래스: {Name}]";
}

// 6-1.
class Person
{
    public string Name;
}

// 5.
class Parent5
{
    public virtual void Work() => Console.WriteLine("프로그래머");
}

class Child5 : Parent5
{
    public sealed override void Work() => base.Work();
}

class GrandChild5 : Child5
{
    public void Play()
    {
        base.Work();
        Console.WriteLine("프로게이머");
    }
}

// 4-2.
class Parent4_2
{
    public virtual void Work() => Console.WriteLine("프로그래머");
}

class Child4_2 : Parent4_2
{
    public override void Work() => base.Work();
}

class GrandChild : Child4_2
{
    public override void Work() => Console.WriteLine("프로게이머");
}

// 4-1.
class Parent4_1
{
    public virtual void Greet() => Console.WriteLine("안녕하세요");
}

class Child4_1 : Parent4_1
{
    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다");
    }
}

// 3-2.
class Animal3
{
    public virtual void Speak() => Console.WriteLine("동물이 소리를 낸다");
}

class Dog3 : Animal3
{
    public override void Speak() => Console.WriteLine("멍멍");
}

class Cat3 : Animal3
{
    public override void Speak() => Console.WriteLine("야옹");
}

// 3-1.
class Calculator
{
    public void Add(int a, int b) => Console.WriteLine(a + b);
    public void Add(double a, double b) => Console.WriteLine(a + b);
    public void Add(int a, int b, int c) => Console.WriteLine(a + b + c);
}

// 2.
class Parent2
{
    public void Say() => Console.WriteLine("부모_안녕하세요");
    public void Run() => Console.WriteLine("부모_달리다");
    public virtual void Walk() => Console.WriteLine("부모_걷다"); 
}

class Child2 : Parent2
{
    public new void Say() => Console.WriteLine("자식_안녕하세요");
    public new void Run() => Console.WriteLine("자식_달리다");
    public override void Walk() => Console.WriteLine("자식_걷다");
}

// 1-2.
class Animal
{
    virtual public void Eat() => Console.WriteLine("Animal Eat");
}

class Cat : Animal
{
    public override void Eat() => Console.WriteLine("Cat Eat");
}

// 1-1.
class Parent
{
    virtual public void Work() => Console.WriteLine("프로그래머");
}

class Child : Parent
{
    public override void Work() => Console.WriteLine("프로게이머");
}