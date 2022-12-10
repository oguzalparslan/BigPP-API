using BigPP.DataAccess.Concrete;
using BigPP.Entity.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        // Access to AppDbContext
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        /// <summary>
        /// Asenkron olmayan işlemlerde kullanılacak commit metotu.
        /// tek görevi kaydetmektir.
        /// </summary>
        public void Commit()
        {
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// Asenkron işlemlerde kullanılacak commit metotu 
        /// tek görevi kaydetmektir.
        /// </summary>
        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
