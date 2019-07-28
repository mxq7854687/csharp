using System;
namespace PointsAndLines
{
    class User
    {
        public readonly int Height = 180;
        public static int currentID;
        private string username;
        private int password;

        public readonly int ID;

        public Race race;
        public string Username
        {
            get
            {
                return "User name is " + username;
            }
        }
        public int Password
        {

            set
            {
                if (value > 4 && value < 10)
                {
                    password = value;
                }
                else { Console.WriteLine("oops. This is not a valid password."); }

            }
        }

        public User()
        {
            currentID++;
            ID = currentID;
            
        }
        public User(string username, Race race )
        {
            currentID++;
            ID = currentID;
            this.username = username;
            this.race = race;
            if (race == Race.Marshian)
            {
                Height = 100;
            }
            else if (race == Race.Earthing)
            {
                Height = 180;
            }
          
        }
    }


}



