using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Repository;
using CAOL.Core.Entities;
using CAOL.Core.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CAOL.Core.Repository.Repositories
{
    public class Cao_osRepository : Repository<cao_os>, ICao_osRepository
    {
        public Cao_osRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
