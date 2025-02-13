using System;

namespace MOES_Digitize_Schools
{
    public class School
    {
        public string name;
        public string location;
        public int numberOfStudents;
        public string levelOfSchool;
        public string password;

        public string LevelOfScool
        {
            get { return levelOfSchool; }
            set
            {
                if (value == "primary" || value == "secondary" || value == "nursary")
                {
                    levelOfSchool = value;
                }
                else
                {
                    levelOfSchool = "not primary, secondary or pre-primary";
                }
            }
        }

        public string Password { get { return password; } set { password = value; } }
    }
}