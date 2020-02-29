using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IState
    {
        void Attack(Character character);
        void Hide(Character character);
        void Find(Character character);
        void Rest(Character character);
    }

    public class Character
    {
        public IState State = AttackState.Instance;

        public void Attack()
        {
            State.Attack(this);
        }

        public void Find()
        {
            State.Find(this);
        }

        public void Rest()
        {
            State.Rest(this);
        }

        public void Hide()
        {
            State.Hide(this);
        }
    }

    public class AttackState: IState
    {
        public static readonly AttackState Instance = new AttackState();

        public void Attack(Character character)
        {
            Console.WriteLine("Attack");
        }

        public void Rest(Character character)
        {
            Console.WriteLine("Attack -> Rest");
            character.State = RestState.Instance;
        }

        public void Find(Character character)
        {
            Console.WriteLine("Attack -> Find");
            character.State = FindState.Instance;
        }

        public void Hide(Character character)
        {
            Console.WriteLine("Attck -> Hide");
            character.State = HideState.Instance;
        }
    }

    public class HideState : IState
    {
        public static readonly HideState Instance = new HideState();

        public void Attack(Character character)
        {
            Console.WriteLine("Hide -> Attack");
            character.State = AttackState.Instance;
        }

        public void Rest(Character character)
        {
            Console.WriteLine("Hide -> Rest");
            character.State = RestState.Instance;
        }

        public void Find(Character character)
        {
            Console.WriteLine("Hide -> Find");
            character.State = FindState.Instance;
        }

        public void Hide(Character character)
        {
            Console.WriteLine("Hide");
        }
    }

    public class FindState : IState
    {
        public static readonly FindState Instance = new FindState();

        public void Attack(Character character)
        {
            Console.WriteLine("Find -> Attack");
            character.State = AttackState.Instance;
        }

        public void Rest(Character character)
        {
            Console.WriteLine("Find -> Rest");
            character.State = RestState.Instance;
        }

        public void Find(Character character)
        {
            Console.WriteLine("Find");
        }

        public void Hide(Character character)
        {
            Console.WriteLine("Find -> Hide");
            character.State = HideState.Instance;
        }
    }

    public class RestState : IState
    {
        public static readonly RestState Instance = new RestState();

        public void Attack(Character character)
        {
            Console.WriteLine("Rest -> Attack");
            character.State = AttackState.Instance;
        }

        public void Rest(Character character)
        {
            Console.WriteLine("Rest");
        }

        public void Find(Character character)
        {
            Console.WriteLine("Rest -> Find");
            character.State = FindState.Instance;
        }

        public void Hide(Character character)
        {
            Console.WriteLine("Rest -> Hide");
            character.State = HideState.Instance;
        }
    }
}
