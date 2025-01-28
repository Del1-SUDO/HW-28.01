using System;
class Program
{
    static void Main()
    {
        Computer pc = new Computer ("Lenovo", "Beast", "Linux");
        pc.Info();
        pc.TurnOn();

        System.Console.WriteLine();

        Laptop laptop = new Laptop ("Acer", "Aspire 5", "Windows", 15);
        laptop.Info();
        laptop.TurnOn();
        laptop.ScreenSizeInfo();

        System.Console.WriteLine();

        SmartPhone phone = new SmartPhone ("Iphone", "15 Pro", "IOS", 7);
        phone.Info();
        phone.TurnOn();
        phone.PhoneInfo();
    }
}

class Computer
{
    public string Brand;
    public string Model;
    public string OperatingSystem;

    public Computer (string Brand, string Model, string OperatingSystem) {
        this.Brand = Brand;
        this.Model = Model;
        this.OperatingSystem = OperatingSystem;
    }

    public void Info (){
        System.Console.WriteLine($"Brand: {Brand}, Model: {Model}, OS: {OperatingSystem}");
    }

    public void TurnOn (){
        System.Console.WriteLine($"The {Brand} {Model} is turned on. You are running {OperatingSystem}.");
    }
    
}

class Laptop : Computer
{
    public int ScreenSize;
    public Laptop (string Brand, string Model, string OperatingSystem, int ScreenSize) : base (Brand, Model, OperatingSystem){
        this.ScreenSize = ScreenSize;
    }

    public void ScreenSizeInfo(){
        System.Console.WriteLine($"This {Brand} {Model} laptop has {ScreenSize} inch screen size.");
    }

}

class SmartPhone : Computer
{
    public int BatteryLife;
    public SmartPhone (string Brand, string Model, string OperatingSystem, int BatteryLife) : base (Brand, Model, OperatingSystem){
        this.BatteryLife = BatteryLife;
    }

    public void PhoneInfo(){
        System.Console.WriteLine($"This {Brand} {Model} phone has {BatteryLife} hours of battery life.");
    }
}