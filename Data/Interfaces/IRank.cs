using SamokatTask.Data.Models;

namespace SamokatTask.Data.Interfaces
{
    public interface IRank
    {
        IEnumerable<Rank> ranks { get; }
    }
}
