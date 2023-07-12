using Ploomtopia.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Ploomtopia.Repositories
{
    public class PloomieRepository : IPloomieRepository
    {
        private readonly PloomtopiaDbContext _dbContext;

        public PloomieRepository(PloomtopiaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Ploomie>> GetAllPloomiesAsync()
        {
            return await _dbContext.Ploomies.ToListAsync();
        }

        public async Task<Ploomie> GetPloomieByIdAsync(int id)
        {
            return await _dbContext.Ploomies.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Ploomie> CreatePloomieAsync(Ploomie ploomie)
        {
            _dbContext.Ploomies.Add(ploomie);
            await _dbContext.SaveChangesAsync();
            return ploomie;
        }

        public async Task<Ploomie> UpdatePloomieAsync(int id, Ploomie ploomie)
        {
            var existingPloomie = await _dbContext.Ploomies.FirstOrDefaultAsync(p => p.Id == id);
            if (existingPloomie != null)
            {
                existingPloomie.Name = ploomie.Name;
                existingPloomie.Traits = ploomie.Traits;
                existingPloomie.HungerLevel = ploomie.HungerLevel;
                existingPloomie.HappinessLevel = ploomie.HappinessLevel;

                await _dbContext.SaveChangesAsync();
            }
            return existingPloomie;
        }

        public async Task<bool> DeletePloomieAsync(int id)
        {
            var ploomie = await _dbContext.Ploomies.FirstOrDefaultAsync(p => p.Id == id);
            if (ploomie != null)
            {
                _dbContext.Ploomies.Remove(ploomie);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
