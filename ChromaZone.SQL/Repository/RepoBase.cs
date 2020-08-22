using ChromaZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChromaZone.SQL.Repository
{
    /// <summary>
    /// Interfaz que todos los respos deben implementar
    /// </summary>
    public abstract class RepoBase<T> : IRepoInterface<T> where T :ChromaZone.Core.Model.RootEntity
    {
        protected ChromeZoneContext _db;

        protected RepoBase(ChromeZoneContext context)
        {
            _db = context;
        }

        /// <summary>
        /// Se asegura que se ejecute ell isvalid al agregar 
        /// </summary>
        /// <param name="entidad"></param>
        /// <return>La entiddad ya agregada a la base de datos, es de utilidad para leer autonumericos
        /// o otros camos generados por la base de datos.</return>
        public async Task AgregarAsync(T entidad)
        {
            await _db.AddAsync(entidad);
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}