using System.Collections.Generic;
using System.Threading.Tasks;
using Ploomtopia.Repositories;
using Ploomtopia.Models;

namespace Ploomtopia.UseCases
{
    public class PloomieUseCase : IPloomieUseCase
    {
        private readonly IPloomieRepository _ploomieRepository;

        public PloomieUseCase(IPloomieRepository ploomieRepository)
        {
            _ploomieRepository = ploomieRepository;
        }

        public async Task<Ploomie[]> GetAllPloomiesAsync()
        {
            var ploomies = await _ploomieRepository.GetAllPloomiesAsync();
            return ploomies.ToArray();
        }

        public Task<Ploomie> GetPloomieByIdAsync(int id)
        {
            return _ploomieRepository.GetPloomieByIdAsync(id);
        }

        public Task<Ploomie> CreatePloomieAsync(Ploomie ploomie)
        {
            return _ploomieRepository.CreatePloomieAsync(ploomie);
        }

        public Task UpdatePloomieAsync(int id, Ploomie ploomie)
        {
            return _ploomieRepository.UpdatePloomieAsync(id, ploomie);
        }

        public Task DeletePloomieAsync(int id)
        {
            return _ploomieRepository.DeletePloomieAsync(id);
        }
    }
}
