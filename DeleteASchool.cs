using System;
using System.Collections.Generic;
using MOES_Digitize_Schools;

namespace MOES_Digitize_Schools
{
    public static class DeleteASchool
    {
        public static void DeleteSchool(List<School> schools)
        {
            try
            {
                if (schools.Count > 0)
                {
                    string schoolName = Helper.provideExitOption("\nEnter School Name (or '00' to go back): ");
                    bool found = false;

                    for (int i = 0; i < schools.Count; i++)
                    {
                        if (schools[i].name.ToLower() == schoolName.ToLower())
                        {
                            found = true;
                            string password = Helper.provideExitOption("Enter School Password (or '00' to go back): ");
                            if (schools[i].Password == password)
                            {
                                schools.RemoveAt(i);
                                Console.WriteLine($"\n{schoolName} has been deleted.");
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
                        Console.WriteLine($"\n{schoolName} not Found");
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
