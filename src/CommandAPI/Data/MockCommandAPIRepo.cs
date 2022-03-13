using CommandAPI.Data;
using CommandAPI.Models;
namespace CommandAPI.Data;
public class MockCommandAPIRepo : ICommandAPIRepo
{
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
        var commands = new List<Command>
        {
            new Command{Id=0,HowTo="How to generate a migration", CommandLine="dotnet ef migrations add <Name of Migration>",Platform=".net core ef"},
            new Command{Id=1,HowTo="How to run migrations", CommandLine="dotnet ef database update",Platform="dot net core ef"},
            new Command{Id=2,HowTo="List of active migrations", CommandLine="dotnet ef migrations list", Platform ="dotnet core ef"},
        };
        return commands;
    }

    public Command GetCommandById(int id)
    {
        return 
            new Command{Id=0,HowTo="How to generate a migration", CommandLine="dotnet ef migrations add <Name of Migration>",Platform=".net core ef"};
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