using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManageGarage
{
    internal class Vehicle
    {
        private string licensePlate;
        private string brand;
        private string name;
        private int countSeat;
        private double price;

        public Vehicle() { }
        public Vehicle(string LicensePlate,string Brand, string Name, int CountSeat, double Price)
        {
            this.licensePlate = LicensePlate;
            this.brand = Brand;
            this.name = Name;
            this.countSeat = CountSeat;
            this.price = Price;
        }
        public string LicensePlate { get {  return licensePlate; } set {  licensePlate = value; } }
        public string Brand { get {  return brand; } set {  brand = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int CountSeat { get {  return countSeat; } set {  countSeat = value; } }
        public double Price { get { return price; } set { price = value; } }
        public virtual void inputInfo()
        {
            Console.Write("Enter license plate: ");
            licensePlate = Console.ReadLine();
            Console.Write("Enter brand: ");
            brand = Console.ReadLine();
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter the number of seats: ");
            countSeat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void printInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("License plate: " + licensePlate);
            Console.WriteLine("Brand: " +  brand);
            Console.WriteLine("Name: " +  name);
            Console.WriteLine("Number of seats: " + countSeat);
            Console.WriteLine("Price: $" + price);
        }
    }
}