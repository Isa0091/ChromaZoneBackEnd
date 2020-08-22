using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Providers.ManejoArchivos
{
    /// <summary>
    /// DTo de retorno de un archivo generado
    /// </summary>
    public class ArchivoGeneradoDTO
    {
        /// <summary>
        /// nombre del archivo
        /// </summary>
        public string NombreArchivo { get; set; }
        /// <summary>
        /// Archivo Generado
        /// </summary>
        public List<byte> Archivo { get; set; }
        /// <summary>
        /// MimeType del archivo retornado
        /// </summary>
        public string MimeType { get; set; }
    }
}
