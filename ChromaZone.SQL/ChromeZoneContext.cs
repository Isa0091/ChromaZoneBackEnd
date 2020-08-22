using ChromaZone.Core.Eventos;
using ChromaZone.Core.Model;
using ChromaZone.Core.Model.Catalogos;
using ChromaZone.SQL.Mapping;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChromaZone.SQL
{
    public class ChromeZoneContext : DbContext
    {
        private readonly IMediator _mediator;
        public ChromeZoneContext(DbContextOptions<ChromeZoneContext> options, MediatR.IMediator mediator) : base(options)
        {
            _mediator = mediator;
        }

        public ChromeZoneContext(DbContextOptions<ChromeZoneContext> options) : base(options)
        {

        }

        #region DBset
        public DbSet<Categoria> Categoria { get; set; }
        #endregion

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.ApplyConfiguration(new CategoriaMap());
        }
        #endregion

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await generacionEventosAsync();
            validar();
            return await base.SaveChangesAsync(cancellationToken);
        }
        public override int SaveChanges()
        {
            throw new InvalidOperationException("No puede utiliza el metodo sincrono de save changes");

        }

        #region Metodos Privados

        /// <summary>
        /// Genera los eventos apartir de los root entity
        /// </summary>
        /// <returns></returns>
        private async Task generacionEventosAsync()
        {

            List<RootEntity> rootEntities = getRootEntities();

            //Para cada entidad que ha cambiado, vamos a validarlo y extraer sus eventos
            foreach (RootEntity rootEntity in rootEntities.Where(x => x.Eventos.Any()).ToList())
            {
                //Saco los integrations eventos que se pudieron haber generado
                foreach (IEvent noti in rootEntity.Eventos.ToList())
                {
                    if (noti is INotification)
                        await _mediator.Publish(noti);

                    //if (noti is IIntegrationEvent integrationEvent)
                    //    await agregarCola(integrationEvent);

                    //habiendo publicado el evento lo remuevo
                    rootEntity.QuitarEvento(noti);
                }
            }

        }

        /// <summary>
        /// Integration events
        /// </summary>
        /// <param name="evento"></param>
        /// <returns></returns>
        //private async Task agregarCola(IIntegrationEvent evento)
        //{
        //    string json = JsonConvert.SerializeObject(evento);

        //    await ColaPendiente.AddAsync(new ColaPendiente()
        //    {
        //        MensajeJson = json,
        //        NombreCola = evento.GetType().Name


        //    });

        //}

        /// <summary>
        /// Valida las entidades
        /// </summary>
        private void validar()
        {

            List<Entity> entities = getEntities();
            foreach (var ent in entities)
            {
                ent.IsValid();
            }
        }
        /// <summary>
        /// Obtiene las entidades Root
        /// </summary>
        /// <returns></returns>
        private List<RootEntity> getRootEntities()
        {
            //Saco una lista de los elementos agregados o modificados, que sean del tipo Entidad
            List<object> elementosCambiados = ChangeTracker.Entries()
                .Where(x => (x.Entity.GetType().IsSubclassOf(typeof(RootEntity)))).Select(x => x.Entity)
                .ToList();

            //Casteo la lista de objetos a root
            List<RootEntity> rootEntities = new List<RootEntity>();

            elementosCambiados.ForEach(x => rootEntities.Add((RootEntity)x));

            //Filtro para que solo tome las entidades que tienen integration Events
            return rootEntities.ToList();
        }

        /// <summary>
        /// Obtiene las entidades entity
        /// </summary>
        /// <returns></returns>
        private List<Entity> getEntities()
        {
            //Saco una lista de los elementos agregados o modificados, que sean del tipo Entidad
            List<object> elementosCambiados = ChangeTracker.Entries()
                .Where(x => (x.Entity.GetType().IsSubclassOf(typeof(Entity)))).Select(x => x.Entity)
                .ToList();

            //Casteo la lista de objetos a root
            List<Entity> entities = new List<Entity>();

            elementosCambiados.ForEach(x => entities.Add((Entity)x));

            //Filtro para que solo tome las entidades que tienen integration Events
            return entities.ToList();
        }
        #endregion


    }
}
