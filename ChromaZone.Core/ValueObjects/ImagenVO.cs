using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.ValueObjects
{

    public class ImagenVO : BaseValueObject
    {
        /// <summary>
        /// 
        /// </summary>
        public ImagenVO(Uri urlImagen,Guid idPlantilla)
        {
            IdPlantilla = idPlantilla;
            UrlImagen = urlImagen;
        }
        /// <summary>
        /// Plantilla la cual define dimenciones de la imagen
        /// </summary>
        public Guid IdPlantilla { get; private set; }

        /// <summary>
        ///url de la imagen
        /// </summary>
        public Uri UrlImagen { get; private set; }


        public override void IsValid()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return IdPlantilla;
            yield return UrlImagen;
        }
    }
}
