using System;
using System.Collections.Generic;
using System.Text;

namespace cat_dog
{
    class Animal
    {
        public string[] initAnimal { get; set; }
        //constructors
        public Animal() { }
        public Animal(params string[] args)
        {
            initAnimal = args;
        }
        //methods
        public virtual string RoarAnimal()
        {
            return "";
        }
    }
}
