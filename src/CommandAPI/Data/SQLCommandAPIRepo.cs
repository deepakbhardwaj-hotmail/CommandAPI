using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SQLCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;

        public SQLCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }
        public void CreateCommand()
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand()
        {
            throw new NotImplementedException();
        }
    }
}