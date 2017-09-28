using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mydatabasefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //add the items to the table
            var context = new nehadeoriEntities();
            
        
            context.faculties.Add(new faculty
            {
               course_id =2,
              courseName = "b-tech",
                faculty1 = "alok_sharma"


            });
            context.faculties.Add(new faculty
            {
                course_id = 3,
                courseName = "b-tech",
               faculty1 = "alok_sharma"


            });

            context.faculties.Add(new faculty
            {
                course_id = 4,
                courseName = "b-tech",
                faculty1 = "nitin_chimmwal"
                

            });

            context.SaveChanges(); 




        }
           
            }
         
        }
    

