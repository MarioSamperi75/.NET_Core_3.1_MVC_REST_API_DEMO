using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommand();
        Command GetCommandById(int id);
    }
}
