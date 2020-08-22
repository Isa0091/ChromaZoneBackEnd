using ChromaZone.Core.Model.Catalogos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChromaZone.Core.Data.Repository
{
    /// <summary>
    /// Accede a al adata de la categoria
    /// </summary>
    public interface ICategoriaRepo : IRepoInterface<Categoria>
    {
        /// <summary>
        /// Obtengo la entidad por su codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        Task<Categoria> GetById(Guid codigo);
    }
}
