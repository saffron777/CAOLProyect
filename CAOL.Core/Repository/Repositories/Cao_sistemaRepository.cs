using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Repository;
using CAOL.Core.Entities;
using CAOL.Core.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CAOL.Core.Repository.Repositories
{
    public class Cao_sistemaRepository : Repository<cao_sistema>, ICao_sistemaRepository
    {
        public Cao_sistemaRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
