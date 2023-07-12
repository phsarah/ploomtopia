using System.Collections.Generic;
using System.Threading.Tasks;
using Ploomtopia.Models;

namespace Ploomtopia.UseCases
{
    public interface IPloomieUseCase
    {
        Task<Ploomie[]> GetAllPloomiesAsync();
        Task<Ploomie> GetPloomieByIdAsync(int id);
        Task<Ploomie> CreatePloomieAsync(Ploomie ploomie);
        Task UpdatePloomieAsync(int id, Ploomie ploomie);
        Task DeletePloomieAsync(int id);
    }
}