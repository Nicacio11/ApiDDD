using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.Data.Mapping
{
    class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> build)
        {
            build.ToTable("produto");
            build.HasKey(x => x.Id);

            build.Property(x => x.Nome);
            build.Property(x => x.Valor);
            build.Property(x => x.IsDisponivel);
        }
    }
}
