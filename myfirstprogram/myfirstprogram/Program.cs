/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;
using System.Collections;



namespace myfirstprogram
{

    class College
    {
        public string fname { get; set; }

        public string lname { get; set; }
        public int stu_id { get; set; }
        public int number { get; set; }
    }
    class faculty
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string subject { get; set; }

    }
    class Student
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string course { get; set; }
        public int id { get; set; }

    }
    class Connect
    {
        private List<College> Information;

        public void create()
        {
            List<College> clg = GetInformation();

            foreach (var c in clg)
            {
                Console.WriteLine(c.fname + " " + c.lname + " " + c.stu_id + " " + c.number);

            }

            var f = true;
            while (f)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Search");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Display the new list");
                Console.WriteLine("5.Delete the person record in the college");
                Console.WriteLine("6.Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        College i1 = new College();
                        Console.WriteLine("Enter fname:");
                        i1.fname = Console.ReadLine();

                        Console.WriteLine("Enter lname:");
                        i1.lname = Console.ReadLine();

                        Console.WriteLine("Enter stu_id:");
                        i1.stu_id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter number");
                        i1.number = Convert.ToInt32(Console.ReadLine());
                        clg.Add(i1);

                        break;

                    case 2:
                        Console.WriteLine("Enter the person first name which you wants to search");
                        var search = Console.ReadLine();
                        var got = clg.Where(sa => sa.fname == search).ToList<College>();
                        foreach (var g in got)
                        {
                            Console.WriteLine(g.fname + " " + g.lname + " " + g.stu_id + " " + g.number);
                        }
                        break;

                    case 3:

                        Console.WriteLine("Enter the person name which wants to update:");

                        var update = Console.ReadLine();

                        var y = clg.FirstOrDefault(u => u.fname == update);
                        Console.WriteLine("Enter new name for person");
                        var q = Console.ReadLine();
                        y.fname = q;

                        break;

                    case 4:
                        Console.WriteLine("Displaying all persons in the college:");
                        foreach (var l in clg)
                        {
                            Console.WriteLine(l.fname + " " + l.lname + " " + l.stu_id + " " + l.number);
                        }
                        break;

                    case 5:

                        Console.WriteLine("Enter the person name whose record that you want to delete");
                        var z = Console.ReadLine();
                        var b = clg.Where(t => t.fname == z).ToList<College>();
                        foreach (var k in b)
                        {
                            clg.Remove(k);
                        }
                        Console.WriteLine("record has been deleted");
                        break;

                }
            }
        }
        public void create1()
        {
            List<College> clg = GetInformation();
            foreach (var c in clg)
            {
                Console.WriteLine(c.fname + " " + c.lname + " " + c.stu_id + " " + c.number);

            }



        }

        public List<College> GetInformation()
        {
            if (Information == null)
            {
                createEntry();
            }
            return Information;
        }
        private void createEntry()
        {
            Information = new List<College>
            {

                new College {fname="neha",lname="devri",stu_id=101,number=123456},
                new College {fname="anjali",lname="devri",stu_id=102,number=123486},
                new College {fname="medha",lname="joshi",stu_id=103,number=1234567},
                new College {fname="lata",lname="pandey",stu_id=104,number=123856},
                new College {fname="chandra",lname="devri",stu_id=104,number=123436},
                new College {fname="geeta",lname="devri",stu_id=106,number=123056},
                new College {fname="himani",lname="chauhan",stu_id=104,number=123956},
                new College {fname="pooja",lname="joshi",stu_id=108,number=123656},

            };
             IEnumerable<College> query = Information.OrderByDescending(p => p.fname);

             foreach (College q in query)
             {
                 Console.WriteLine("{0} {1}", q.fname,q.lname);
                 Console.ReadLine();
             
            Console.WriteLine("comparision of strings");
            Console.WriteLine("enter the first sring to be compare");
            var x = Console.ReadLine();
            Console.WriteLine("enter the second string to be compare");
            var y = Console.ReadLine();
            Console.WriteLine("Comparision of strings {0} and {1} :{2}", x, y, String.Compare(x, y, true));
            Console.ReadLine();
        

            

        }
    
        class Result
        {
            static void Main(string[] args)
            {


                Connect c = new Connect();
                
                c.createEntry();
               

        }
        }
    }
}*/

