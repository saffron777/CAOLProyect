using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Repository;
using CAOL.Core.Entities;
using CAOL.Core.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CAOL.Core.Repository.Repositories
{
    public class Cao_faturaRepository : Repository<cao_fatura>, ICao_faturaRepository
    {
        public Cao_faturaRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
