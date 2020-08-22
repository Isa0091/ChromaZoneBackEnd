
using ChromaZone.Core.Data.Repository;
using ChromaZone.Core.Model.Catalogos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromaZone.SQL.Repository
{

    public class CategoriaRepo : RepoBase<Categoria>, ICategoriaRepo
    {
        public CategoriaRepo(ChromeZoneContext context) : base(context)
        {

        }
        public async Task<Categoria> GetById(Guid codigo)
        {
            return await _db.Categoria.SingleOrDefaultAsync(z => z.Codigo == codigo);
        }
    }
}
