using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1
{
    public class Club : Entrant //INHERITANCE
    {
        private string clubName;
        private int numTeamsEntered;



        public void setClubName()
        {
            Console.WriteLine("Please enter Club name");
            clubName = Console.ReadLine();
        }

        public int getNumTeams()
        {
            return numTeamsEntered;
        }

        public void setNumTeams()
        {
            Console.WriteLine("Enter the number of teams.");
            string value = Console.ReadLine();
            int num = Int32.Parse(value); //converts the string into an integer

            while (num < 1 || num > 8)
            {
                Console.WriteLine("Please enter a team number between 1 and 8");
                num = Int32.Parse(Console.ReadLine());

            }

        }

        public void setRaceType()
        {
            Console.WriteLine("Please enter the type of race (please insert dua or tri): ");
            string type = Console.ReadLine();
            type = type.ToLower(); // convert to lowercase for the if statement
            if (type == "dua" || type == "tri")
            {
                raceType = type;
                Console.WriteLine("The racetype is " + type);
            }
            else
            {
                Console.WriteLine("invalid - please enter dua or tri");
                type = Console.ReadLine();

            }
        }

        public override int calculate_total_Payment()
        {
            int price = 0;
            if (raceType == "tri")
                price = Convert.ToInt32(300 + (300 * 0.2)); //adding 20% tax
            else
                price = Convert.ToInt32(200 + (200 * 0.2)); //20% tax

            
            Console.WriteLine("The price is £" + price);
            return price;
        }

        public void setDetails(ref int id)
        {
            entryID = id; //refers to entryID from base "Entrant" class
        }

        public string getClubName()
        {
            return clubName;
        }
    }
}
