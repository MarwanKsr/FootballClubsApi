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
    class EClubRepository : IClubRepository
    {
        public CatalogDbContext context;
        public EClubRepository(CatalogDbContext context)
        {
            this.context = context;
        }
        public async Task<IList<Club>> GetAll()
        {
            var clubs = await context.Clubs.ToListAsync();
            return clubs;
        }

        public Task<Club> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetClubByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
