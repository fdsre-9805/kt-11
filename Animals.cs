using System;

namespace Zoo
{
    public class Lion : IAnimal
    {
        public string Name => "Лев";
        public void MakeSound() => Console.WriteLine("Рычит");
    }

    public class Dog : ITrainable
    {
        public string Name => "Собака";
        public void MakeSound() => Console.WriteLine("Гав");
        public string Train() => "Собака научилась сидеть";
    }

    public class Dolphin : ITrainable
    {
        public string Name => "Дельфин";
        public void MakeSound() => Console.WriteLine("Щёлкает");
        public string Train() => "Дельфин научился прыгать через кольцо";
    }
}
