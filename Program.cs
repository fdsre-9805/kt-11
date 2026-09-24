using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal> { new Lion(), new Dog(), new Dolphin() };

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.MakeSound();

                if (animal is ITrainable trainable)
                    Console.WriteLine(trainable.Train());

                Console.WriteLine();
            }
        }
    }
}
