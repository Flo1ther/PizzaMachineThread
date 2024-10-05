using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMachineThread
{
    public class PizzaRobot
    {
        public string PizzaName { get; }

        public PizzaRobot(string pizzaName)
        {
            PizzaName = pizzaName;
        }

        public void KneadDough()
        {
            Console.WriteLine($"Робот починає замішувати тісто для піци \"{PizzaName}\"...");
            Thread.Sleep(2000);
            Console.WriteLine($"Тісто для піци \"{PizzaName}\" готове.");
        }

        public void AddIngredients()
        {
            Console.WriteLine($"Робот додає інгредієнти для піци \"{PizzaName}\"...");
            Thread.Sleep(3000);
            Console.WriteLine($"Інгредієнти для піци \"{PizzaName}\" додані.");
        }

        public void BakePizza()
        {
            Console.WriteLine($"Робот випікає піцу \"{PizzaName}\"...");
            Thread.Sleep(5000);
            Console.WriteLine($"Піца \"{PizzaName}\" готова.");
        }

        public void MakePizza()
        {
            Thread doughThread = new Thread(KneadDough);
            Thread ingredientsThread = new Thread(AddIngredients);
            Thread bakeThread = new Thread(BakePizza);

            doughThread.Start();
            doughThread.Join();

            ingredientsThread.Start();
            ingredientsThread.Join();

            bakeThread.Start();
            bakeThread.Join();

            Console.WriteLine($"Робот завершив приготування піци \"{PizzaName}\"!");
        }
    }

}
