using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageGarage
{
    internal class Manage
    {
        public List<Vehicle> listVehicle {  get; set; }
        public Manage()
        {
            listVehicle = new List<Vehicle>();
        }
        public void addVehicle()
        {
            Vehicle vehicle = null;
            Console.WriteLine("Do you want add car or motorcycle?");
            Console.WriteLine("\t1. Car\n\t2. Motorcycle");
            Console.Write("Enter your selection: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    vehicle = new Car();
                    vehicle.inputInfo();
                    break;
                case 2:
                    vehicle = new Motorcycle();
                    vehicle.inputInfo(); 
                    break;
                default: 
                    Console.WriteLine("Invalid selection. Vehicle not added!");
                    break;
            }
            listVehicle.Add(vehicle);
        }
        public void showAll()
        {
            listVehicle.ForEach(vehicle => vehicle.printInfo());
        }
        public void showCar()
        {
            List<Vehicle> listCar = listVehicle.Where(item => item is Car).ToList();
            if(listCar.Count > 0)
            {
                foreach(Vehicle car in listCar)
                {
                    car.printInfo();
                }
            }
            else
            {
                Console.WriteLine("Don't have any car!");
            }
        }
        public void showMotorcycle()
        {
            List<Vehicle> listMotorcycle = listVehicle.Where(item => item is Motorcycle).ToList();
            if (listMotorcycle.Count > 0)
            {
                foreach (Vehicle motorcycle in listMotorcycle)
                {
                    motorcycle.printInfo();
                }
            }
            else
            {
                Console.WriteLine("Don't have any motorcycle!");
            }
        }
        public void searchByLicensePlate(string licensePlate)
        {
            Vehicle veh = listVehicle.FirstOrDefault(item => item.LicensePlate.Equals(licensePlate));
            if (veh != null)
            {
                veh.printInfo();
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
        public void updateVehicle(string licensePlate)
        {
            Vehicle veh = listVehicle.FirstOrDefault(item => item.LicensePlate.Equals(licensePlate));
            if (veh != null)
            {
                Console.WriteLine("Updating vehicle with license plate: " + licensePlate);
                veh.inputInfo();
                Console.WriteLine("Vehicle updated successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }
        public void removeVehicle(string licensePlate)
        {
            Vehicle veh = listVehicle.FirstOrDefault(item => item.LicensePlate.Equals(licensePlate));
            if (veh != null)
            {
                listVehicle.Remove(veh);
                Console.WriteLine("Vehicle with license plate " + licensePlate + " has been removed.");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }
    }
}
