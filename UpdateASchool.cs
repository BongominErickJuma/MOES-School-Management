using System;
using System.Collections.Generic;
using MOES_Digitize_Schools;

namespace MOES_Digitize_Schools
{
    public static class UpdateASchool
    {
        public static void UpdateSchool(List<School> schools)
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
                                while (true)
                                {
                                    Console.WriteLine("\nWhat do you want to change?");
                                    Console.WriteLine("1. Name\n2. Level of Education\n3. Total Students\n4. Location\n5. Password\n6. Exit");

                                    int option = Helper.getIsValidNumber("Enter Option.");

                                    switch (option)
                                    {
                                        case 1:
                                            string newName = Helper.provideExitOption("Enter new School name");
                                            school.name = newName;
                                            break;
                                        case 2:
                                            string newLevel = Helper.provideExitOption("Change School Level");
                                            school.levelOfSchool = newLevel;
                                            break;
                                        case 3:
                                            int newTotal = Helper.getIsValidNumber("Change School Total students");
                                            school.numberOfStudents = newTotal;
                                            break;
                                        case 4:
                                            string newLocation = Helper.provideExitOption("Change School Location");
                                            school.location = newLocation;
                                            break;
                                        case 5:
                                            Console.WriteLine("Enter Old Password");
                                            string oldPassword = Console.ReadLine();

                                            if(oldPassword == school.password)
                                            {
                                                Console.WriteLine("Enter New Password");
                                                string newPassword = Console.ReadLine();
                                                school.password = newPassword;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Wrong Old Password");
                                            }
                                            break;
                                        case 6:
                                            return;
                                        default:
                                            Console.WriteLine("Invalid Option");
                                            break;
                                    }
                                }
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
