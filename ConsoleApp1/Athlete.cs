using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1
{
    public class Athlete : Entrant //inheitance from entrant
    {

        public Athlete(string name)
        {
            this.name = name;
            Name = name;
        }

        private string name;
        private int raceTime;

        public string Name { get; set; }

    }
}
