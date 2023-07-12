using Ploomtopia.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ploomtopia.Repositories
{
    public interface IPloomieRepository
    {
        Task<List<Ploomie>> GetAllPloomiesAsync();
        Task<Ploomie> GetPloomieByIdAsync(int id);
        Task<Ploomie> CreatePloomieAsync(Ploomie ploomie);
        Task<Ploomie> UpdatePloomieAsync(int id, Ploomie ploomie);
        Task<bool> DeletePloomieAsync(int id);
    }
}
