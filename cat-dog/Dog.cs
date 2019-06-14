using System;
using System.Collections.Generic;
using System.Text;

namespace cat_dog
{
    class Dog : Animal
    {
        //constructors
        public Dog() { }
        public Dog(string[] initDog) : base(initDog) { }
        //methods
        public override string RoarAnimal()
        {
            return "Woof";
        }
    }
}
