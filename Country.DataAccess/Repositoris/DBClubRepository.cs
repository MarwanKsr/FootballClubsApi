using Catalog.DataAccess.Data;
using Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Repositoris
{
     public class DBClubRepository : IClubRepository
    {
        private CatalogDbContext context;
        public DBClubRepository(CatalogDbContext context)
        {
            this.context = context;
        }
        public async Task<IList<Club>> GetAll()
        {
            return await context.Clubs.ToListAsync();
        }

        public async Task<Club> GetById(int id)
        {
            var club = await context.Clubs.FindAsync(id);
            return club;
        }

        

         async Task<IList<Club>> IClubRepository.GetClubByName(string name)
        {
            var club = await context.Clubs.Where(c => c.Name.Contains(name)).ToListAsync();
            return club;
        }
    }
}
