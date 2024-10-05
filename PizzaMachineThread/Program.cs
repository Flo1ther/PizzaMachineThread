using PizzaMachineThread;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

PizzaRobot robot = new PizzaRobot("Маргарита");

Thread pizzaMakingThread = new Thread(robot.MakePizza);

Console.WriteLine("Робот починає процес приготування піци...");
pizzaMakingThread.Start();
pizzaMakingThread.Join();

Console.WriteLine("Процес приготування піци завершено!");
