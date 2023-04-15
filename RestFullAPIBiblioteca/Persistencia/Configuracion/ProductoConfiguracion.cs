using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entidades;

namespace Persistencia.Configuracion
{
    public class ProductoConfiguracion : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.producto)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(p => p.fechaRegistro)
                .IsRequired();
            builder.Property(p => p.precioCompra)
                 .IsRequired();
            builder.Property(p => p.PrecioVenta)
                .IsRequired();
            builder.Property(p => p.Existencias)
                .IsRequired();

            

            builder.Property(p => p.Creadopor);
            // .IsRequired();
            builder.Property(p => p.UltimaModificacionPor);
            // .IsRequired();
        }
       
    }
}
