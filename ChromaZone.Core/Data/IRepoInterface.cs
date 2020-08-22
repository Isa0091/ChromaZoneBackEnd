using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChromaZone.Core.Data
{
    /// <summary>
    /// Metodos base que todos los repositorios deben implmentar
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepoInterface<T> where T : Model.RootEntity
    {

        /// <summary>
        /// Se asegura que se ejecute el isvalid al agregar 
        /// </summary>
        /// <param name="entidad"></param>
        /// <return>La entiddad ya agregada a la base de datos, es de utilidad para leer autonumericos
        /// o otros camos generados por la base de datos.</return>
        Task AgregarAsync(T entidad);
        /// <summary>
        /// Persiste los cambios a la base de datos
        /// </summary>
        Task SaveChangesAsync();
    }
}
