using System;
using System.Collections.Generic;
using System.Text;

namespace cat_dog
{
    class Cat : Animal
    {
        //constructors
        public Cat() { }
        public Cat(string[] initCat) : base(initCat){}
        //methods
        public override string RoarAnimal()
        {
            return "Meyau";
        }
    }
}
