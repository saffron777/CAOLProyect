using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Repository;
using CAOL.Core.Entities;
using CAOL.Core.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CAOL.Core.Repository.Repositories
{
    public class Cao_clienteRepository: Repository<cao_cliente>, ICao_clienteRepository
    {
        public Cao_clienteRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
