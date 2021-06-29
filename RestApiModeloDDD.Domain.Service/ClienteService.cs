using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Domain.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository repository;

        public ClienteService(IClienteRepository repository) : base (repository)
        {
            this.repository = repository;
        }
    }
}
