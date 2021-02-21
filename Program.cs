using System;

namespace POO2_Devoir
{
    public class Car
    {
        public double price { get; set; }
        public int time { get; set; }
        public string id { get; set; }

        public Car(string _id, int _time)
        {
            id = _id;
            time = _time;
        }

        public double calculateCharges(int _time)
        {
            time = _time;
            int copyTime = time;
            price = 2.0;
            while(copyTime > 3)
            {
                copyTime--;
                if(price < 10)
                    price += 0.5;
            }
            return price;
        }

        public override string ToString()
        {
            return $"Car number : {id}, parked for : {time} hours, paid {price} euros";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            var rand = new Random();
            for(int i = 1; i < 24; i += rand.Next(1,5))
            {
                Car car = new Car(""+ id, i);
                car.calculateCharges(i);
                Console.WriteLine(car);
                id++;
            }
        }
    }
}
