using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Repository;
using CAOL.Core.Entities;
using CAOL.Core.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CAOL.Core.Repository.Repositories
{
    public class Cao_usuarioRepository : Repository<cao_usuario>, ICao_usuarioRepository
    {
        public Cao_usuarioRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
