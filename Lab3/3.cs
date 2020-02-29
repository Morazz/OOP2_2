using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teller teller = new Teller();
            Hero hero = new Hero();
            teller.SetCommand(new AttackCommand(hero));
            teller.Attack();

            Console.WriteLine();

            Character character = new Character();
            character.Attack();
            character.Hide();
            character.Rest();

            Console.WriteLine();

            Person J = new Person();
            J.SetName("John");
            J.SetWeapon("Gun");
            Console.WriteLine($"{J.name}:{J.weapon}");

            Memento memento = J.GetState();

            J.SetName("Mike");
            J.SetWeapon("Sword");
            Console.WriteLine($"{J.name}:{J.weapon}");

            J.SetState(memento);
            Console.WriteLine($"{J.name}:{J.weapon}");

            Console.WriteLine();

            Observable observable = new Observable();

            ConcreteObserverA observerA = new ConcreteObserverA();
            observable.RegisterObserver(observerA);

            ConcreteObserverB observerB = new ConcreteObserverB();
            observable.RegisterObserver(observerB);

            observable.DoSomeWork();
            observable.DoSomeWork();

            observable.RemoveObserver(observerA);
            observable.DoSomeWork();

            Console.ReadKey();
        }

   
    }
}
