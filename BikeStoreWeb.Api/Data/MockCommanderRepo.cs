using BikeStoreWeb.Api.Models;
using System;
using System.Collections.Generic;

namespace BikeStoreWeb.Api.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>()
            {
                new Command() { Id = 0, HowTo = "Boil an Egg", Line = "Boild and water", Platform = "Kettle & pan" },
                new Command() { Id = 1, HowTo = "Cut Bread", Line = "Get knife", Platform = "Knife and chopping board" },
                new Command() { Id = 2, HowTo = "Make a coffie", Line = "Boild and water", Platform = "Kettle & pan" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command() { Id = 0, HowTo = "Boil an Egg", Line = "Boild and water", Platform = "Kettle & pan" };
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
