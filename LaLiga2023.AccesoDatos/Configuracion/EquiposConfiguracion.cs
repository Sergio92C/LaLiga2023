using LaLiga2023.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga2023.AccesoDatos.Configuracion
{
    public class EquiposConfiguracion : IEntityTypeConfiguration<Equipos>
    {
        public void Configure(EntityTypeBuilder<Equipos> builder)
        {
            builder.Property(x => x.id_equipo).IsRequired();
            builder.Property(x => x.nombre_oficial).IsRequired().HasMaxLength(50);
            builder.Property(x => x.nombre_coloquial).IsRequired().HasMaxLength(30);
            builder.Property(x => x.fundacion).IsRequired().HasMaxLength(4);
            builder.Property(x => x.estadio).IsRequired().HasMaxLength(35);
            builder.Property(x => x.presidente).IsRequired().HasMaxLength(35);
            builder.Property(x => x.web).IsRequired().HasMaxLength(50);
            builder.Property(x => x.entrenador).IsRequired().HasMaxLength(40);
        }
    }
}
