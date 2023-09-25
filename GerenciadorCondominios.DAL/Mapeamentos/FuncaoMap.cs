using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>

    {
        void IEntityTypeConfiguration<Funcao>.Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);

            builder.HasData(
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Morador",
                    NormalizedName = "MORADOR",
                    Descricao = "Morador do Prédio"
                },
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Síndico",
                    NormalizedName = "SÍNDICO",
                    Descricao = "Síndico do Prédio"
                }
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                    Descricao = "Administrador do Prédio"
                });

            builder.ToTable("Funcoes");

        }
    }
}
