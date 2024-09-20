

public class Car
{
    public string brand;
    public int speed;

    public void Drive()
    {
        Console.WriteLine("The car is driving.");
    }


}      

Car myCar = new Car();
myCar.brand = "Dodge";
myCar.speed = 75;
myCar.Drive();

public class Vehicle
{
    public string brand;

    public void Start()
    {
        Console.WriteLine("Vehicle is staring.");
    }



}

public class Car : Vehicle
{
    public int speed;

    public void Dive()
    {
        Console.WriteLine(brand + "Is driving at " + speed + "km/h");
    }
}


Car myCar = new Car();
myCar.brand = "Dodge";
myCar.speed = 75;
myCar.Drive();
myCar.Drive();

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Make Sound");

    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }





}