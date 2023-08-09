using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home", 
                "This is your home", 
                "..");

            newWorld.AddLocation(-1, -1, "Farmers House",
                "This is the house oif your neighbour, Farmer Ted",
                "..");

            newWorld.AddLocation(-2, -1, "Farmers Field", 
                "There are rows of corn growing here, with giant rats!",
                "..");

            return newWorld;
        }
    }
}
