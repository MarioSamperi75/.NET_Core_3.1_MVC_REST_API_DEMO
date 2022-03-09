using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommand()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Plattform = "Kettle & Cup" },
                new Command { Id = 0, HowTo = "Cut Bread", Line = "Get a knife", Plattform = "Knife & Chopping board" },
                new Command { Id = 0, HowTo = "Make a cup of tea", Line = "Place teabug in cup", Plattform = "Kettle & Cup" }

            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Plattform = "Kettle & Cup" };
        }
    }
}
