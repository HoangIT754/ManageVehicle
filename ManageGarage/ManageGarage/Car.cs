using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManageGarage
{
    internal class Car : Vehicle
    {
        private string bodyType;
        public Car() : base() { }
        public Car(string LicensePlate, string Brand, string Name, int CountSeat, double Price, string BodyType) : base(LicensePlate, Brand, Name, CountSeat, Price)
        {
            this.bodyType = BodyType;
        }
        public string BodyType { get { return this.bodyType; } set { this.bodyType = value; } }
        public override void inputInfo()
        {
            base.inputInfo();
            Console.Write("Enter body type: ");
            bodyType = Console.ReadLine();
        }
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Body type: " + bodyType);
        }
    }
}
