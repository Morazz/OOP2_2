using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class Hero
    {
        public void Attack()
        {
            Console.WriteLine("Attack!");
        }

        public void Rest()
        {
            Console.WriteLine("I need some rest");
        }

        public void Hide()
        {
            Console.WriteLine("In the dark wood...");
        }

        public void Find()
        {
            Console.WriteLine("Maybe I can find something useful...");
        }
    }

    class AttackCommand : ICommand
    {
        Hero hero;

        public AttackCommand(Hero h)
        {
            hero = h;
        }

        public void Execute()
        {
            hero.Attack();
        }

        public void Undo() { }
    }

    class RestCommand : ICommand
    {
        Hero hero;

        public RestCommand(Hero h)
        {
            hero = h;
        }

        public void Execute()
        {
            hero.Rest();
        }

        public void Undo() { }
    }

    class HideCommand : ICommand
    {
        Hero hero;

        public HideCommand(Hero h)
        {
            hero = h;
        }

        public void Execute()
        {
            hero.Hide();
        }

        public void Undo() { }
    }

    class FindCommand : ICommand
    {
        Hero hero;

        public FindCommand(Hero h)
        {
            hero = h;
        }

        public void Execute()
        {
            hero.Find();
        }

        public void Undo() { }
    }

    class Teller
    {
        ICommand command;

        public Teller() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void Attack()
        {
            command.Execute();
        }

        public void Rest()
        {
            command.Execute();
        }

        public void Hide()
        {
            command.Execute();
        }

        public void Find()
        {
            command.Execute();
        }
    }
}
