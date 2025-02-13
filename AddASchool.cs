using System;
using System.Collections.Generic;
using MOES_Digitize_Schools;

namespace MOES_Digitize_Schools
{
    public static class AddASchool
    {
        public static void AddSchool(List<School> schools)
        {
            try
            {
                string schoolName = Helper.provideExitOption("\nEnter School Name (or '00' to go back): ");
                string schoolLocation = Helper.provideExitOption("Enter School Location (or '00' to go back): ");
                int schoolTotalStudents = Helper.getIsValidNumber("Enter Total Number of Students");

                Console.WriteLine("Enter Level of School (Nursary, Primary, Secondary)");
                string level = Console.ReadLine();

                Console.WriteLine("Create School Login Password");
                string password = Console.ReadLine();

                schools.Add(new School
                {
                    name = schoolName,
                    location = schoolLocation,
                    numberOfStudents = schoolTotalStudents,
                    LevelOfScool = level.ToLower(),
                    Password = password
                });
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("\nReturning to the main menu...");
            }
        }

    }
}
