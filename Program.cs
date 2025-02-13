using System;
using MOES_Digitize_Schools;


namespace MOES_Digitize_Schools
{
    class Program
    {
        public static List<School> schools = new List<School>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Add School\n2. View Your School\n3. View All Schools\n4. Update School\n5. Delete School\n6. Exit");
                int option = Helper.getIsValidNumber("Enter Option");

                switch (option)
                {
                    case 1:
                        AddASchool.AddSchool(schools);
                        break;
                    case 2:
                        ViewYourSchool.ViewSchool(schools);
                        break;
                    case 3:
                        ViewAllTheSchools.ViewAllSchools(schools);
                        break;
                    case 4:
                        UpdateASchool.UpdateSchool(schools);
                        break;
                    case 5:
                        DeleteASchool.DeleteSchool(schools);
                        break;
                    case 6:
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
        }
    }
}