using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Digger digger = new Digger();
            digger.ToDig(12, 21);

            FastDigger Dig = new FastDigger();
            IDigger digAd = new Adapter(Dig);
            digAd.ToDig(14, 3);

            Console.WriteLine();

            IFlower flower = new Flower("Flover 1", "red") { height = 4 };
            flower.ToGrow();

            Console.WriteLine();

            IFlower bigflower = new FullFlower(flower);
            bigflower.ToGrow();

            Console.WriteLine();
            Console.WriteLine();

            var head = new Body { Title = "Head" };
            head.AddComponent(new BodyComponent { Title = "Eye" });
            head.AddComponent(new BodyComponent { Title = "Skull" });

            var body = new Body { Title = "Body" };
            body.AddComponent(new BodyComponent { Title = "Leg" });
            body.AddComponent(new BodyComponent { Title = "Arm" });
            body.AddComponent(new BodyComponent { Title = "Liver" });
            body.AddComponent(new BodyComponent { Title = "Heart" });

            var human = new Body { Title = "Human" };
            human.AddComponent(body);
            human.AddComponent(head);
            human.FindComp();
            var part = human.Find("Arm");
            part.FindComp();

            Console.ReadKey();
        }
    }
    interface IFastDigger
    {
        void FastDig(int x, int y, int speed);
    }

    class FastDigger : IFastDigger
    {
        public void FastDig(int x, int y, int speed)
        {
            Console.WriteLine($"He digs to {x}.{y} with speed {speed}");
        }
    }

    interface IDigger
    {
        void ToDig(int x, int y);
    }

    class Digger : IDigger
    {
        public void ToDig(int x, int y)
        {
            Console.WriteLine($"He digs to {x}.{y}");
        }
    }

    class Adapter : IDigger
    {
        private FastDigger digger = new FastDigger();

        public Adapter(FastDigger d)
        {
            digger = d;
        }

        public void ToDig(int t, int p)
        {
            digger.FastDig(t, p, 11);
        }
    }

    public interface IFlower
    {
        int height { get; set; }
        void ToGrow();
    }

    class Flower : IFlower
    {
        string name, color;
        public int height { get; set; }

        public Flower(string n, string c)
        {
            name = n;
            color = c;
        }

        public void ToGrow()
        {
            Console.WriteLine($"Such a beautiful {color} {name}!");
        }
    }

    public class FlowerDecorator : IFlower
    {
        protected readonly IFlower flower;

        public FlowerDecorator(IFlower flo)
        {
            flower = flo;
        }

        public virtual int height
        {
            get { return flower.height; }
            set { flower.height = value; }
        }

        public virtual void ToGrow()
        {
            flower.ToGrow();
        }
    }

    public class FullFlower : FlowerDecorator
    {
        public FullFlower(IFlower flower) : base(flower)
        {
        }

        public override void ToGrow()
        {
            base.ToGrow();
            Console.Write($"It's very big: {base.height}");
        }
    }

    public interface IComponent
    {
        string Title { get; set; }
        void FindComp();
        IComponent Find(string title);
    }

    public class BodyComponent : IComponent
    {
        public string Title { get; set; }

        public void FindComp()
        {
            Console.Write($"Component founded: {Title} ");
            Console.WriteLine();
        }

        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
    }

    public class Body : IComponent
    {
        private readonly List<IComponent> body = new List<IComponent>();

        public string Title { get; set; }

        public void AddComponent(IComponent component)
        {

            body.Add(component);
        }

        public void FindComp()
        {
            Console.Write($"Element founded: {Title} ");
            Console.WriteLine();
            foreach (var component in body)
            {
                component.FindComp();
            }
            Console.WriteLine();
        }
        public IComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }
            foreach (var component in body)
            {
                var found = component.Find(title);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }
    }
}

