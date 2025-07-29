using System;

namespace DesignPatternsDemo
{
    // Singleton Pattern
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance => _instance;

        public void ShowMessage() => Console.WriteLine("Singleton instance invoked.");
    }

    // Factory Pattern
    public interface IProduct
    {
        void Display();
    }

    public class ConcreteProductA : IProduct
    {
        public void Display() => Console.WriteLine("ConcreteProductA created.");
    }

    public class ConcreteProductB : IProduct
    {
        public void Display() => Console.WriteLine("ConcreteProductB created.");
    }

    public class ProductFactory
    {
        public static IProduct CreateProduct(string type)
        {
            return type switch
            {
                "A" => new ConcreteProductA(),
                "B" => new ConcreteProductB(),
                _ => throw new ArgumentException("Invalid product type")
            };
        }
    }

    // Strategy Pattern
    public interface IStrategy
    {
        void Execute();
    }

    public class StrategyA : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing Strategy A.");
    }

    public class StrategyB : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing Strategy B.");
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy) => _strategy = strategy;

        public void SetStrategy(IStrategy strategy) => _strategy = strategy;

        public void ExecuteStrategy() => _strategy.Execute();
    }

    // Observer Pattern
    public interface IObserver
    {
        void Update(string message);
    }

    public class ConcreteObserver : IObserver
    {
        private readonly string _name;

        public ConcreteObserver(string name) => _name = name;

        public void Update(string message) => Console.WriteLine($"{_name} received: {message}");
    }

    public class Subject
    {
        private readonly List<IObserver> _observers = new();

        public void Attach(IObserver observer) => _observers.Add(observer);

        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    // Demo
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton Pattern
            Singleton.Instance.ShowMessage();

            // Factory Pattern
            IProduct productA = ProductFactory.CreateProduct("A");
            productA.Display();

            IProduct productB = ProductFactory.CreateProduct("B");
            productB.Display();

            // Strategy Pattern
            Context context = new Context(new StrategyA());
            context.ExecuteStrategy();

            context.SetStrategy(new StrategyB());
            context.ExecuteStrategy();

            // Observer Pattern
            Subject subject = new Subject();
            IObserver observer1 = new ConcreteObserver("Observer 1");
            IObserver observer2 = new ConcreteObserver("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.Notify("Event 1 occurred.");
            subject.Detach(observer1);
            subject.Notify("Event 2 occurred.");
        }
    }
}
