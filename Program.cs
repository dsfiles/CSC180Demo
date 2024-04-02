using System;

namespace Quiz03

{
    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Car #1");

            Car car = new Car("1234", "Ford", "Focus", 98000);

            car.Drive(200);

            car.Display();


            Console.WriteLine("Car #2");

            Car car2 = new Car("7777", "Honda", "Civic", 2300);

            car2.Drive(1200);

            car2.Display();

        }

    }



    class Car

    {

        string vin;

        string make;

        string model;

        int mileage;



        public Car() { }

        public Car(string vin, string make, string model, int mileage)

        {

            this.vin = vin;

            this.make = make;

            this.model = model;

            this.mileage = mileage;

        }



        public void Drive(int miles)

        {

            mileage += miles;

        }



        public void Display()
        {
            Console.WriteLine("   Vin#: {0}\n   Make: {1}\n   Model: {2}\n   Mileage: {3}\n", vin, make, model, mileage);
        }

    }

}