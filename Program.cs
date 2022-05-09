using System.Linq;

namespace Contact
{
    class program
    {
        public static List<ContactInfo> contact = new List<ContactInfo> (); 
       public static void Main()
        {

            MainMenu();
            
            
            
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Contact App");
            Console.WriteLine("Choose an Option");
            Console.WriteLine("1) Display info");
            Console.WriteLine("2)Sum of all ages");
            Console.WriteLine("3)Name with longest length");
            Console.WriteLine("4)Exit");

            string? result = Console.ReadLine();
            if (result == "1")
            {
                Display();
            }
            else if (result == "2")
            {
                SumAges();
            }
            else if (result == "3")
            {
                Length();
            }
            else if (result == "4")
            {
                Console.Clear();
            }

            Console.ReadLine();
        }


        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("Display info");

            /*
            var items = List<ContactInfo> items
            {
             new ContactInfo { Name="Adedeji Mike", PhoneNumber= 090243331452, Age = 19 },
             new ContactInfo { Name="Damilola ibrahim", PhoneNumber= 090547689123, Age = 65 }
            }
            ;

            foreach (var item in items)
            {
                Console.WriteLine("Name: {0}  Phone Number: {1}  Age: {2}", item.Name, item.PhoneNumber, item.Age);
            }
            */


            contact.Add(new ContactInfo 
            { Name = "Adedeji Mike", PhoneNumber = 0903456271, Age = 27 });
            contact.Add(new ContactInfo
            { Name = "Adedeji Mike", PhoneNumber = 0704567121, Age = 35 });
            contact.Add(new ContactInfo
            { Name = "Adedeji Mike", PhoneNumber = 0903456271, Age = 62 });

            






            foreach (var item in contact)
            {
                Console.WriteLine("Name: {0}   Age: {1}  Phone Number: {2} ", item.Name, item.Age, item.PhoneNumber);

            }

            Console.ReadLine();
        }



        public static void SumAges()
        {
            Console.Clear();
            Console.WriteLine("Sum of all ages");

            contact.Add(new ContactInfo { Age = 27 });
            contact.Add(new ContactInfo { Age = 35 });
            contact.Add(new ContactInfo { Age = 62 });
            
            int total = contact.Sum(item => item.Age);
             Console.WriteLine(total);
            


        }

        public static void Length()
        {
            Console.Clear();
            Console.WriteLine("Name with longest length");
        }



    }
    public class ContactInfo
    {
        public string? Name { get; set; }
        public long PhoneNumber { get; set; }
        public int Age { get; set; }

    }

}