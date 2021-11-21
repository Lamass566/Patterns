using System;

namespace FactoryMethod
{
     public abstract class PizzaFactory
     {
        public abstract IPizza FactoryMethod();

        public string PrintInfo()
        {
            var pizza = FactoryMethod();

            var info = $"Вы заказали:--" + pizza.PrintAllInfo();
            return info;
        }
     }
     public class Paperony_PizzaFactory : PizzaFactory
     {
        public override IPizza FactoryMethod()
        {
            return new Paperony();
        }
    }
     public class Paperchilli_PizzaFactory : PizzaFactory
     {
        public override IPizza FactoryMethod()
        {
            return new Paperchilli();
        }
    }
     public interface IPizza
     {
        string Cheese { get; set; }
        string Meat { get; set; }
        string Souses { get; set; }
        string PrintAllInfo();
     }
    public class Paperchilli : IPizza
    {
        public string Cheese { get; set; }
        public string Meat{ get; set; }
        public string Souses { get; set; }
        public string PrintAllInfo()
        {
            var info = $"Паперчили: Сыр-{Cheese}, Мясо-{Meat}, Соус-{Souses}";
            return info;
        }

     }
     public class Paperony : IPizza
     {
        public string Cheese { get; set; }
        public string Meat { get; set; }
        public string Souses { get; set; }
        public string PrintAllInfo()
        {
            var info = $"Паперони: Сыр-{Cheese}, Мясо-{Meat}, Соус-{Souses}";
            return info;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            PizzaFactory pizza = new Paperchilli_PizzaFactory();
            Console.WriteLine(pizza.PrintInfo());
        }
    }
}
