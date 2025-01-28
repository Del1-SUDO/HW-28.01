using System;
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Camry", 180, 4);
        car.DisplayInfo();

        Console.WriteLine();

        Airplane airplane = new Airplane("Boeing", "747", 900, 76);
        airplane.DisplayInfo();

        Console.WriteLine();

        Train train = new Train("Siemens", "ICE 3", 300, 20);
        train.DisplayInfo();

        Console.WriteLine();

        PassengerCar passengerCar = new PassengerCar("Mercedes", "E-Class", 220, 4, 5);
        passengerCar.DisplayInfo();

        Console.WriteLine();

        CargoCar cargoCar = new CargoCar("Volvo", "FH", 120, 16, 20);
        cargoCar.DisplayInfo();

        Console.WriteLine();

        PassengerPlane passengerPlane = new PassengerPlane("Airbus", "A380", 900, 75, 550);
        passengerPlane.DisplayInfo();

        Console.WriteLine();

        CargoPlane cargoPlane = new CargoPlane("Boeing", "C-130", 800, 90, 30);
        cargoPlane.DisplayInfo();
    }
}

class Transport
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Speed { get; set; }

    public Transport(string brand, string model, double speed)
    {
        Brand = brand;
        Model = model;
        Speed = speed;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Transport: {Brand} {Model} traveling at {Speed} km/h");
    }
}

class Car : Transport
{
    public int Wheels { get; set; }

    public Car(string brand, string model, double speed, int Wheels) : base(brand, model, speed)
    {
        this.Wheels = Wheels;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"This car has {Wheels} wheels");
    }
}

class Airplane : Transport
{
    public double Length { get; set; }

    public Airplane(string brand, string model, double speed, double Length) : base(brand, model, speed)
    {
        this.Length = Length;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Length of the plane: {Length} meters");
    }
}

class Train : Transport
{
    public int TonsOfGoods { get; set; }

    public Train(string brand, string model, double speed, int TonsOfGoods) : base(brand, model, speed)
    {
        this.TonsOfGoods = TonsOfGoods;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Train can move up to: {TonsOfGoods} tons of goods.");
    }
}


class PassengerCar : Car
{
    public int PassengerCapacity { get; set; }

    public PassengerCar(string brand, string model, double speed, int Wheels, int passengerCapacity) : base(brand, model, speed, Wheels)
    {
        PassengerCapacity = passengerCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Passenger Capacity: {PassengerCapacity} people");
    }
}

class CargoCar : Car
{
    public double CargoCapacity { get; set; }

    public CargoCar(string brand, string model, double speed, int Wheels, double cargoCapacity) : base(brand, model, speed, Wheels)
    {
        CargoCapacity = cargoCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Cargo Capacity: {CargoCapacity} tons");
    }
}


class PassengerPlane : Airplane
{
    public int PassengerCapacity { get; set; }

    public PassengerPlane(string brand, string model, double speed, double Length, int PassengerCapacity) : base(brand, model, speed, Length)
    {
        this.PassengerCapacity = PassengerCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Passenger seats capacity: {PassengerCapacity} seats");
    }
}

class CargoPlane : Airplane
{
    public double CargoCapacity { get; set; }

    public CargoPlane(string brand, string model, double speed, double Length, double cargoCapacity) : base(brand, model, speed, Length)
    {
        CargoCapacity = cargoCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Cargo Capacity: {CargoCapacity} tons");
    }
}