using System;

namespace ex11
{   //The class
    class Car
    {
        //Class members
        string color = "red";
        int maxSpeed;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.fullThrottle();
        }
    }
}
