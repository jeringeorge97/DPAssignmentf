using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataproggassg2
{
    internal class viewdetails
    {
        string jsondataFromUrl;
       
        public void read()
        {
            Console.WriteLine("========= Student Data \n");



            
            
                StreamReader reader = new StreamReader(@"C:\Users\Kiran\Desktop\New folder\student.json");
                jsondataFromUrl = reader.ReadToEnd();
                if (jsondataFromUrl != null)
                {
                    
                    Console.WriteLine("data------------{0}", jsondataFromUrl);
                }
                else
                {
                    Console.WriteLine("NO Data----------");
                }
            }
        }
    }

