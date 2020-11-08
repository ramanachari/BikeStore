using BikeStoreWeb.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace BikeStoreWeb.Api.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            _context.Commands.Add(command);
            _context.SaveChanges();

        }

        public void DeleteCommand(int id)
        {
            _context.Commands.ToList().RemoveAll(cmd => cmd.Id == id);
            _context.SaveChanges();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(command => command.Id == id);
        }

        public void UpdateCommand(Command command)
        {
            _context.SaveChanges();
        }
    }
}
