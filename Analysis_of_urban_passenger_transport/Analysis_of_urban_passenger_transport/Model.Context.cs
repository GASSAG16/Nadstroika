﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Analysis_of_urban_passenger_transport
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Core.Objects.DataClasses;
    using System.Linq;
    
    public partial class AddonEntities : DbContext
    {
        public AddonEntities()
            : base("name=AddonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Route> Routes { get; set; }
        public DbSet<tip_trans> tip_trans { get; set; }
    
        public virtual ObjectResult<requestRoute> requestRoute(string param1, string param2)
        {
            var param1Parameter = param1 != null ?
                new ObjectParameter("Param1", param1) :
                new ObjectParameter("Param1", typeof(string));
    
            var param2Parameter = param2 != null ?
                new ObjectParameter("Param2", param2) :
                new ObjectParameter("Param2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<requestRoute>("requestRoute", param1Parameter, param2Parameter);
        }
    }
}