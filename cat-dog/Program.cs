using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cat_dog
{
    class Program
    {
	//type Enum for animal
        public enum AnimalEnum { Dog, Cat, Pig, Horse }

        public static void AddAnimalsDictionary(Dictionary<string, AnimalEnum> animal, string[] keyAnimal, AnimalEnum valueAnimal)
        {
            for (int i = 0; i < keyAnimal.Length; i++)
            {
                animal.Add(keyAnimal[i], valueAnimal);
            }
        }
        static void Main(string[] args)
        {
            //var filePath = "D:\\newFile.txt";
            ////string text = "Hello World";
            //string text = "Привет";
            //File.WriteAllText((filePath, text, Encoding..UTF8);

            //Console.Write("Enter numeral system: ");
            //int numearalSystem = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter numeral system: ");
            //string chilso = "ffff"; // число, которое будет переведено 
            //int dec = Convert.ToInt32(chilso, systema); // преобразование в десятичную систему 
            //Console.WriteLine("Число - " + chilso + " основание счисления " + systema + " в десятичной - " + dec);

            Console.Write("Choose an animal - dog, cat, pig or horse: ");
            string valueFromUser = Console.ReadLine();

            Dictionary<string, AnimalEnum> animals = new Dictionary<string, AnimalEnum>();

            string[] initDog = { "dog", "1", "d", "dd", "ddd", "dogg", "chiu-chiu" };
            AddAnimalsDictionary(animals, initDog, AnimalEnum.Dog);

            string[] initCat = { "cat", "2", "c", "cc", "ccc", "catt", "mey-mey" };
            AddAnimalsDictionary(animals, initCat, AnimalEnum.Cat);

            string[] initHorse = { "horse", "3", "h", "hh", "hhh", "horsee", "frfrfr" };
            AddAnimalsDictionary(animals, initHorse, AnimalEnum.Horse);

            string[] initPig = { "pig", "4", "p", "pp", "ppp", "piggg", "ufufuf" };
            AddAnimalsDictionary(animals, initPig, AnimalEnum.Pig);

            string whoThisAnimal = "";

            foreach (KeyValuePair<string, AnimalEnum> keyValue in animals)
            {
                if (keyValue.Key == valueFromUser)
                {
                    whoThisAnimal = Convert.ToString(keyValue.Value);
                }
            }

            switch (whoThisAnimal)
            {
                case "Dog":
                    Dog dog = new Dog();
                    Console.WriteLine(dog.RoarAnimal());
                    break;
                case "Cat":
                    Cat cat = new Cat();
                    Console.WriteLine(cat.RoarAnimal());
                    break;
                case "Horse":
                    Horse horse = new Horse();
                    Console.WriteLine(horse.RoarAnimal());
                    break;
                case "Pig":
                    Pig pig = new Pig();
                    Console.WriteLine(pig.RoarAnimal());
                    break;
                default:
                    Console.WriteLine("Таких животных у нас нет!");
                    break;
            }
        }
    }
}
