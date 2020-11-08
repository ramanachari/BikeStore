using BikeStoreWeb.Api.Models;
using System.Collections.Generic;

namespace BikeStoreWeb.Api.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        void UpdateCommand(Command command);

        void DeleteCommand(int id);
    }
}
