using ChromaZone.Core.Providers.ManejoArchivos;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromaZone.Provider.ManejoArchivos
{
    public class ManejoArchivosProvider : IManejoArchivosProvider
    {

        private string _cnn;
        private string _contenedor;

        public ManejoArchivosProvider(string cnn, string contenedor)
        {
            _cnn = cnn;
            _contenedor = contenedor;
        }

        public async Task<bool> EliminarArchivo(Uri urlArchivo)
        {
            string nombreArchivo = System.IO.Path.GetFileName(urlArchivo.ToString());
            CloudBlockBlob blob = getBlob(_cnn, _contenedor, nombreArchivo);
            return await blob.DeleteIfExistsAsync();
        }
        public async Task<Uri> PublicarArchivoStorageAsync(byte[] contenido, string nombreArchivo, string mimeType, bool sobreEscribir = false)
        {
            string nSinExtension = System.IO.Path.GetFileNameWithoutExtension(nombreArchivo);
            string extension = System.IO.Path.GetExtension(nombreArchivo);

            CloudStorageAccount cuenta = CloudStorageAccount.Parse(_cnn);
            CloudBlobClient cliente = cuenta.CreateCloudBlobClient();
            CloudBlobContainer contenedor = cliente.GetContainerReference(_contenedor);

            CloudBlockBlob blob = contenedor.GetBlockBlobReference(nombreArchivo);

            int i = 1;
            while (sobreEscribir == false && await blob.ExistsAsync())
            {
                blob = contenedor.GetBlockBlobReference($"{nSinExtension}{i}{extension}");
                i = i + 1;
            }

            blob.Properties.ContentType = mimeType;
            await blob.UploadFromByteArrayAsync(contenido, 0, contenido.Length);

            return blob.Uri;
        }
        public async Task<ArchivoGeneradoDTO> DescargarArchivoByteAsync(Uri urlArchivo)
        {
            ArchivoGeneradoDTO archivoGeneradoDTO = new ArchivoGeneradoDTO();
            string nombreArchivo = System.IO.Path.GetFileName(urlArchivo.ToString());
            CloudBlockBlob blob = getBlob(_cnn, _contenedor, nombreArchivo);

            if (await blob.ExistsAsync() == false)
                throw new FileNotFoundException();

            await blob.FetchAttributesAsync();
            long fileByteLength = blob.Properties.Length;

            byte[] file = new byte[fileByteLength];
            await blob.DownloadToByteArrayAsync(file, 0);

            archivoGeneradoDTO.Archivo = file.ToList();
            archivoGeneradoDTO.NombreArchivo = nombreArchivo;
            archivoGeneradoDTO.MimeType = blob.Properties.ContentType;

            return archivoGeneradoDTO;
        }
        private CloudBlockBlob getBlob(string cnn, string nombreContenedor, string nombreArchivo)
        {
            CloudStorageAccount cuenta = CloudStorageAccount.Parse(cnn);
            CloudBlobClient cliente = cuenta.CreateCloudBlobClient();

            CloudBlobContainer contenedor = cliente.GetContainerReference(nombreContenedor);

            return contenedor.GetBlockBlobReference(nombreArchivo);
        }
        public async Task<Uri> PublicarImagenBase64EnStorage(string nombreArchivo, string contenidoBase64, string mimeType, bool sobreEscribir = false)
        {
            byte[] contenido = Convert.FromBase64String(contenidoBase64);
            return await PublicarArchivoStorageAsync(contenido, nombreArchivo, mimeType, sobreEscribir);
        }


    }
}