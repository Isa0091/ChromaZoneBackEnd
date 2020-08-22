using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ChromaZone.Core.Model
{
    /// <summary>
    /// Calse heredada pro todas las entidades del sistema
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Valida que la entidad este en un estado valido.
        /// </summary>
        public virtual void IsValid()
        {
            foreach (var p in this.GetType().GetProperties(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance))
            {
                if (typeof(ValueObjects.BaseValueObject).IsAssignableFrom(p.PropertyType))
                {
                    if ((ValueObjects.BaseValueObject)p.GetValue(this) != null)
                        ((ValueObjects.BaseValueObject)p.GetValue(this)).IsValid();

                }
                if (typeof(Entity).IsAssignableFrom(p.PropertyType) && (p.GetMethod.IsPrivate == false && p.SetMethod.IsPrivate == false))
                {
                    if ((Entity)p.GetValue(this) != null)
                        ((Entity)p.GetValue(this)).IsValid();
                }

                if (typeof(IEnumerable).IsAssignableFrom(p.PropertyType) && ((p.GetMethod != null && p.SetMethod != null) && (p.GetMethod.IsPrivate == false && p.SetMethod.IsPrivate == false)))
                {
                    if ((IEnumerable)p.GetValue(this) != null)
                    {
                        foreach (object item in (IEnumerable)p.GetValue(this))
                        {
                            if (typeof(Entity).IsAssignableFrom(item.GetType()))
                            {
                                ((Entity)item).IsValid();
                            }
                            else
                                break;
                        }
                    }

                }
            }
        }
    }
}
