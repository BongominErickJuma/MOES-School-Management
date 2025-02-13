using System;
using System.Collections.Generic;
using MOES_Digitize_Schools;

namespace MOES_Digitize_Schools
{
    public static class ViewYourSchool
    {
        public static void ViewSchool(List<School> schools)
        {
            try
            {
                if (schools.Count > 0)
                {
                    string schoolName = Helper.provideExitOption("\nEnter School Name (or '00' to go back): ");
                    bool found = false;

                    foreach (var school in schools)
                    {
                        if (school.name.ToLower() == schoolName.ToLower())
                        {
                            found = true;
                            string password = Helper.provideExitOption("Enter School Password (or '00' to go back): ");
                            if (school.Password == password)
                            {

                                Console.WriteLine($"\n {school.name.ToUpper()}");
                                Console.WriteLine($" Level: {school.LevelOfScool}");
                                Console.WriteLine($" Total Students: {school.numberOfStudents}");
                                Console.WriteLine($" Location: {school.location}");
                            }
                            else
                            {
                                Console.WriteLine("\nWrong Password");
                            }
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine($"\n{schoolName} not found");
                    }
                }
                else
                {
                    Console.WriteLine("\nNo School Registered");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("\nReturning to the main menu...");
            }
        }
    }
}
