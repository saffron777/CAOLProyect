using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Repository;
using CAOL.Core.Entities;
using CAOL.Core.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CAOL.Core.Repository.Repositories
{
    public class Cao_salarioRepository : Repository<cao_salario>, ICao_salarioRepository
    {
        public Cao_salarioRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
