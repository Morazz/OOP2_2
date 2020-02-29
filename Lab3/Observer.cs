using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab3
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }

    public interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public class Observable : IObservable
    {
        public int State { get; set; }

        private List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer has been registered");
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer has been removed");
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Notifying observers...");
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void DoSomeWork()
        {
            Console.WriteLine("\nDoing important things, please wait...");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.NotifyObservers();
        }
    }

    class ConcreteObserverA : IObserver
    {
        public void Update(IObservable observable)
        {
            if ((observable as Observable).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(IObservable observable)
        {
            if ((observable as Observable).State == 0 || (observable as Observable).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
