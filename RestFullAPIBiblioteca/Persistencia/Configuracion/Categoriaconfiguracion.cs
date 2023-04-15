using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Configuracion
{
    public class Categoriaconfiguracion : IEntityTypeConfiguration<Categorias>
    {

        public void Configure(EntityTypeBuilder<Categorias> builder)
        {

            builder.ToTable("Categorias");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.nomcategoria)
                .HasMaxLength(200)
                .IsRequired();

            


        }
    }

}
