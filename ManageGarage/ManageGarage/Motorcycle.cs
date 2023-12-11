using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageGarage
{
    internal class Motorcycle : Vehicle
    {
        private int seatHeight;
        public Motorcycle() : base() { }
        public Motorcycle(string LicensePlate, string Brand, string Name, int CountSeat, double Price, int SeatHeight) : base(LicensePlate,Brand,Name,CountSeat,Price)
        {
            this.seatHeight = SeatHeight;
        }
        public int SeatHeight { get { return seatHeight; } set { seatHeight = value; } }
        public override void inputInfo()
        {
            base.inputInfo();
            Console.Write("Enter seat height: ");
            seatHeight = Convert.ToInt32(Console.ReadLine());
        }
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Seat height: " + seatHeight +"cm");
        }
    }
}
