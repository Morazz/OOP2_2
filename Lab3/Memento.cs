using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        public string name = "Jake";
        public string weapon = "Gun";

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public Memento GetState()
        {
            var data = $"{name}:{weapon}";
            return new Memento(name, weapon);
        }

        public void SetState(Memento memento)
        {
            this.name = memento.name;
            this.weapon = memento.weapon;
        }
    }

    public class Memento
    {
        public string name { get; private set; }
        public string weapon { get; private set; }

        public Memento(string name, string weapon)
        {
            this.name = name;
            this.weapon = weapon;
        }
    }
}
