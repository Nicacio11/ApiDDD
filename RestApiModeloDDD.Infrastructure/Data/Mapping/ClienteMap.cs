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
    class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        // Para utilizar o totable é necessário instalar Microsoft.EntityFrameworkCore.Relational
        public void Configure(EntityTypeBuilder<Cliente> build)
        {
            build.ToTable("cliente");
            build.HasKey(x => x.Id);

            build.Property(x => x.Nome);
            build.Property(x => x.Email);
            build.Property(x => x.DataCadastro);
            build.Property(x => x.Sobrenome);
            build.Property(x => x.IsAtivo);
        }
    }
}
