using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_May_Step_Ders_
{

    //#region Builder

    //public class Car
    //{
    //    public string Model { get; set; }
    //    public string Color { get; set; }

    //    public Engine Engine { get; set; }
    //    public Door LeftDoor { get; set; }
    //    public Door RightDoor { get; set; }

    //    public Wheels Wheels { get; set; }

    //    public Car(string model, string color)
    //    {
    //        Model = model;
    //        Color = color;
    //    }

    //}

    //public enum Side
    //{
    //    Left = 1, Right = 2
    //}
    //public class Door
    //{
    //    public Door(Side side)
    //    {

    //    }
    //}
    //public class Engine
    //{ }

    //public class Wheels
    //{ }

    //public class SportCarBuilder
    //{
    //    private readonly Car car;

    //    public SportCarBuilder(string model, string color)
    //    {
    //        car = new Car(model, color);
    //    }

    //    public SportCarBuilder SetEngine(Engine engine)
    //    {
    //        car.Engine = engine;
    //        return this;
    //    }
    //    public SportCarBuilder SetLeftDoor()
    //    {
    //        car.LeftDoor = new Door(Side.Left);
    //        return this;
    //    }
    //    public SportCarBuilder SetRightDoor()
    //    {
    //        car.RightDoor = new Door(Side.Right);
    //        return this;
    //    }
    //    public SportCarBuilder SetWheels(Wheels wheels)
    //    {
    //        car.Wheels = wheels;
    //        return this;//zencirvari gedmeyi uchun return this edirik.
    //    }
    //    public Car Build()
    //    {
    //        return car;
    //    }

    //}

    //#endregion

    #region Prototype

    public class Soft : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Robot : ICloneable
    {
        public Soft Soft { get; set; }

        public object Clone()
        {
            Robot robot = MemberwiseClone() as Robot;//shallow copy gedir
            robot.Soft = Soft.Clone() as Soft;//deep copy gedir
            return robot;
        }
    }

    #endregion


    #region Object Pool

    public class Enemy
    { }

    public class EnemyPool
    {
        Queue<Enemy> _enemies = new Queue<Enemy>();

        public Enemy GetEnemy()
        {
            if (_enemies.Count != 0)
            {
                return _enemies.Dequeue();
            }
            return new Enemy();
        }

        public void ReturnEnemy(Enemy enemy)
        {
            _enemies.Enqueue(enemy);//burda use olan enemy-ni qaytariram;
        }


    }


    #endregion

    class Program
    {
        static void Main(string[] args)
        {


            //Builder Pattern
            //elave builder-ler olsa Director class-i chixarda bilersen ve onun ichinde interface Builder saxlayiriq ve her builder-e gore ferqli davrana bilerik.
            //ve ya if-e sala bilerik sport olsa bele ele jeep olsa bashqa cur ele.

            //Car car = new SportCarBuilder("BMW", "Black").SetEngine(new Engine()).SetLeftDoor().SetRightDoor().SetWheels(new Wheels()).Build();

            //Console.WriteLine(car.Model);



        }
    }
}