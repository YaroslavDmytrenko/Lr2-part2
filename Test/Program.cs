using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class Car 
    {

        int speed = 0;
        public delegate void TooFast();

        private TooFast tooFast;


        public void Start()
        {
            speed = 10;
        }
        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
                tooFast();
        }
        public void Stop()
        {
            speed = 0;
        }

        public void RegisterOnTooFast(TooFast tooFast)
        {
            this.tooFast = tooFast;
        }

    }


    class Test
    {

        static Car car;
        static void Main(string[] args)
        {
            car = new Car();

            car.RegisterOnTooFast(HandleOnTooFast);
            car.Start();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();

        }

        private static void HandleOnTooFast()
        {
            Console.WriteLine("Oh, I got it, calling stop!");
            car.Stop();
        }



    }
    
}