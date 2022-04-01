using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1
{
    public abstract class Entrant //POLYMORPHISM
    {
        protected int entryID;
        protected string raceType;
        protected double totalPaid;
        protected static List<string> athleteList = new List<string>();


        public int get_Entry_ID()
        {
            return entryID;
        }

        public string get_Race_Type()
        {
            return raceType;
        }

        public virtual int calculate_total_Payment()
        {
            return 0; 
        }

        public static void add_Athlete_to_List(string name)
        {
            athleteList.Add(name);
        }
    }
}
