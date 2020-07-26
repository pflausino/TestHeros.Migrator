using System;
using TestHeros.Migrator.Domain.Core.Entities;

namespace TestHeros.Migrator.Domain.Entities
{
    public class Hero : Entity
    {
        public Hero()
        {
        }
        public virtual string Name { get; set; }

        public virtual string IdentityName { get; set; }
        public virtual int Strong { get; set; }
        public virtual int Intelligent { get; set; }
        public virtual int Resistence { get; set; }
        public virtual Vehicle MainVehicle { get; set; }
    }
}

