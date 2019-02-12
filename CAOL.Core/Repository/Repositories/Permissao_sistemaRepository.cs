using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Repository;
using CAOL.Core.Entities;
using CAOL.Core.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CAOL.Core.Repository.Repositories
{
    public class Permissao_sistemaRepository : Repository<permissao_sistema>, IPermissao_sistemaRepository
    {
        public Permissao_sistemaRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
