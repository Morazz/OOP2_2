using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Army elf = new Army(new ElfArmy(), 3);
            Console.WriteLine("We have {0} armies!", elf.amount);
            elf.ToAttack();
            elf.ToPanic();

            General general = General.getGeneral();

            Console.WriteLine();

            BigArmyBuilder builder = new BigArmyBuilder();
            King king = new King(builder);
            king.Join();
            ComplexArmy army = builder.getResult();

            Console.WriteLine();

            var MG = new MainGeneral { Name = "Mikhail", Age = 47};
            Console.WriteLine($"Main general: {MG.Name} {MG.Age}");
            var clone = MG.DeepCopy();
            Console.WriteLine($"New general: {clone.Name} {clone.Age}");

            Console.ReadKey();
        }
    }   
}

abstract class Attack
{
    public abstract void DoAttack();
}

abstract class Panic
{
    public abstract void MakePanic();
}

class AgressiveAttack : Attack
{
    public override void DoAttack()
    {
        Console.WriteLine("We attack agressively!");
    }
}

class StealthyAttack : Attack
{
    public override void DoAttack()
    {
        Console.WriteLine("We attack stealthily!");
    }
}

class ReligiousPanic : Panic
{
    public override void MakePanic()
    {
        Console.WriteLine("*Pray hardly*");
    }
}

class SeriousPanic : Panic
{
    public override void MakePanic()
    {
        Console.WriteLine("*Stern faces* We don't panic");
    }
}

class QuietPanic : Panic
{
    public override void MakePanic()
    {
       Console.WriteLine("*Pointless look*");
    }
}

interface ArmyFactory
{
    Attack CreateAttack();
    Panic CreatePanic();
}

class ElfArmy : ArmyFactory
{
    public Attack CreateAttack()
    {
        return new StealthyAttack();
    }

    public Panic CreatePanic()
    {
        return new ReligiousPanic();
    }
}

class VervolfArmy : ArmyFactory
{

    public Attack CreateAttack()
    {
        return new AgressiveAttack();
    }

    public Panic CreatePanic()
    {
        return new SeriousPanic();
    }
}

class HumanArmy : ArmyFactory
{
    public Attack CreateAttack()
    {
        return new AgressiveAttack();
    }

    public Panic CreatePanic()
    {
        return new QuietPanic();
    }
}

class Army
{
    private Attack attack;
    private Panic panic;
    public int amount;

    public Army(ArmyFactory factory, int n)
    {
        attack = factory.CreateAttack();
        panic = factory.CreatePanic();
        amount = n;
    }
  
    public void ToAttack()
    {
        attack.DoAttack();
    }

    public void ToPanic()
    {
        panic.MakePanic();
    }
}

class General
{

    private static General instance;

    private General()
    {
        Console.WriteLine("Your general is here!");
    }

    public static General getGeneral()
    {
        if (instance == null)
            instance = new General();
        return instance;
    }
}

class ComplexArmy
{
    List<object> bigArmy = new List<object>();
    public void Add(object squad)
    {
        bigArmy.Add(squad);
    }
}

interface IBigArmyBuilder
{
    void MakePlan();
    void Exploration();
    void MakeArmy();
    ComplexArmy getResult();
}

class BigArmyBuilder : IBigArmyBuilder
{
    private readonly ComplexArmy _army = new ComplexArmy();

    public void MakePlan()
    {
        Console.WriteLine("Our plan is ready!");
    }
    public void Exploration()
    {
        Console.WriteLine("We need more information!");
    }
    public void MakeArmy()
    {
        Console.WriteLine("We have the biggest army in the world!");
    }

    public ComplexArmy getResult()
    {
        return this._army;
    }
}

class King
{
    BigArmyBuilder builder;
    public King(BigArmyBuilder builder)
    {
        this.builder = builder;
    }
    public void Join()
    {
        builder.Exploration();
        builder.MakePlan();
        builder.MakeArmy();
    }
}

interface IPrototype<T>
{
    T Clone();
}

[Serializable]
public abstract class Prototype<T>: IPrototype<T>
{
    public T Clone()
    {
        return (T)MemberwiseClone();
    }
    public virtual T DeepCopy()
    {
        using (var stream = new MemoryStream())
        {
            var context =
            new StreamingContext(StreamingContextStates.Clone);
            var formatter =
            new BinaryFormatter { Context = context };
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return (T)formatter.Deserialize(stream);
        }

    }
}

[Serializable]
public class MainGeneral : Prototype<MainGeneral>
{
    public string Name { get; set; }
    public int Age { get; set; }
}
