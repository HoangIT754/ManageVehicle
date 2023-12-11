namespace ManageGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manage manage = new Manage();
            int select = 0;
            do
            {
                Console.WriteLine("---------*********-----MENU----*********---------");
                Console.WriteLine("\t0. Exit");
                Console.WriteLine("\t1. Add a vehicle");
                Console.WriteLine("\t2. Show all vehicle");
                Console.WriteLine("\t3. Show all car");
                Console.WriteLine("\t4. Show all motorcycle");
                Console.WriteLine("\t5. Update a vehicle");
                Console.WriteLine("\t6. Remove a vehicle");
                Console.WriteLine("\t7. Search a vehicle by license plate");
                Console.Write("What is your selection: ");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        manage.addVehicle(); break;
                    case 2:
                        manage.showAll(); break;
                    case 3:
                        manage.showCar(); break;
                    case 4:
                        manage.showMotorcycle(); break;
                    case 5:
                        Console.Write("Enter license plate: ");
                        string up = Console.ReadLine();
                        manage.updateVehicle(up);
                        break;
                    case 6:
                        Console.Write("Enter license plate: ");
                        string rm = Console.ReadLine();
                        manage.removeVehicle(rm);
                        break;
                    case 7:
                        Console.Write("Enter license plate: ");
                        string sch = Console.ReadLine();
                        manage.searchByLicensePlate(sch);
                        break;
                    default:
                        select = 0;
                        break;
                }
            } while (select != 0);
        }
    }
}