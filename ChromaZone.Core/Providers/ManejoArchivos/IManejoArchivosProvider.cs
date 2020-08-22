using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChromaZone.Core.Providers.ManejoArchivos
{
    /// <summary>
    /// provider para el manejo de archivos dentro de un estorage especifico
    /// </summary>
    public interface IManejoArchivosProvider
    {
        /// <summary>
        /// Publica un archivo al azure storage
        /// </summary>
        /// <param name="contenido">Los bytes del archivo a publicar</param>
        /// <param name="nombreArchivo">El nombre a utilizar para el archivo.</param>
        /// <param name="sobreEscribir">indica si el nombre del archivo ya existe se sobreescribe</param>
        /// <param name="mimeType">Describe el mimeType de la imagen a subir</param>
        /// <remarks>
        /// <para>si el archivo ya existe en el storage le agrega un correlativo.</para>
        /// <para>Si el contenedor no existe lo crea.</para>
        /// </remarks>
        /// <returns>La URL absoluta de la imagen en el storage</returns>
        Task<Uri> PublicarArchivoStorageAsync(byte[] contenido, string nombreArchivo, string mimeType, bool sobreEscribir = false);

        /// <summary>
        /// DFescarga un archivo del storage account
        /// </summary>
        /// <param name="urlArchivo">La url del archivo el cual fue guardado</param>
        /// <exception cref="System.IO.FileNotFoundException">Si el archivo no existe en el blob</exception>
        /// <returns>Los bytes del archivo</returns>
        Task<ArchivoGeneradoDTO> DescargarArchivoByteAsync(Uri urlArchivo);
        /// <summary>
        /// Elimina un archivo del storage
        /// </summary>
        /// <param name="urlArchivo">La url del archivo el cual fue guardado</param>
        /// <returns></returns>
        Task<bool> EliminarArchivo(Uri urlArchivo);

        /// <summary>
        /// Publica una imagen en el storage 
        /// </summary>
        /// <param name="nombreArchivo">Nombre de archivo que s etratara de utilizar el cual se agrega un correlativo si ya existe</param>
        /// <param name="contenidoBase64">El contenido de la imagen en base 64</param>
        /// <param name="sobreEscribir">indica si el nombre del archivo ya existe se sobreescribe</param>
        /// <param name="mimeType">Describe el mimeType de la imagen a subir</param>
        /// <returns>El URL de la imagen en el storage</returns>
        Task<Uri> PublicarImagenBase64EnStorage(string nombreArchivo, string contenidoBase64, string mimeType, bool sobreEscribir = false);


    }
}
