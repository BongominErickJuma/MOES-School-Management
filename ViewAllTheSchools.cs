using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOES_Digitize_Schools
{
    public static class ViewAllTheSchools
    {
        public static void ViewAllSchools(List<School> schools)
        {
            if (schools.Count > 0)
            {
                Console.WriteLine("\nSCHOOLS\n");
                for (int i = 0; i < schools.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {schools[i].name} - {schools[i].location}");
                }
            }
            else
            {
                Console.WriteLine("\nNo School Registered");
            }
        }
    }
}
