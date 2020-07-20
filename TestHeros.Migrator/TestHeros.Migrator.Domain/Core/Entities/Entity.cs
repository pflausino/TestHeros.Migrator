using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TestHeros.Migrator.Domain.Core.Entities
{
    public class Entity : IEquatable<Entity>, IEqualityComparer<Entity>
    {

        public virtual Guid Id { get; set; }

        public Entity()
        {
        }

        public virtual bool Equals(Entity other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.Id.Equals(Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (!(obj is Entity))
            {
                return false;
            }
            return Equals((Entity)obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(Entity left, Entity right)
        {
            return object.Equals(left, right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !object.Equals(left, right);
        }

        protected virtual void AddToList<T>(IEnumerable<T> list, T item)
            where T : Entity
        {
            AddToList(list, item, null);
        }

        protected virtual void AddToList<T>(IEnumerable<T> list, T item, Action<T> preProcessAction)
            where T : Entity
        {
            if (item == null)
            {
                return;
            }
            preProcessAction?.Invoke(item);
            ((IList<T>)list).Add(item);
        }

        protected virtual void RemoveFromList<T>(IList<T> list, T item)
            where T : Entity
        {
            RemoveFromList(list, item, null);
        }

        protected virtual void RemoveFromList<T>(IList<T> list, T item, Action<T> preProcessAction)
            where T : Entity
        {
            if (item == null)
            {
                return;
            }
            preProcessAction?.Invoke(item);
            if (list != null && list.Contains(item))
            {
                list.Remove(item);
            }
        }

        public virtual bool Equals(Entity x, Entity y)
        {
            if (x == null && y == null)
            {
                return true;
            }
            return x != null && x.Equals(y);
        }

        public virtual int GetHashCode(Entity obj)
        {
            return GetHashCode();

        }
    }
}
