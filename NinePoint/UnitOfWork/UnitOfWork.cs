using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using NinePoint.Entities;
using NinePoint.Repositories;

namespace NinePoint.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ManageApartmentDbContext _context;
        private bool _disposed = false;
        public IEquipmentReponsitory equipmentReponsitory { get; set; }
        public IResidentReponsitory residentReponsitory { get; set; }
        public IJobInfoRepository jobInfoRepository { get; set; }
        public ISupportRepository supportRepository { get; set; }

        public UnitOfWork(ManageApartmentDbContext context)
        {
            _context = context;
            InitRepositories();
        }

        public void InitRepositories()
        {
            equipmentReponsitory = new EquipmentReponsitory(_context);
            residentReponsitory = new ResidentReponsitory(_context);
            jobInfoRepository = new JobInfoRepository(_context);
            supportRepository = new SupportRepository(_context);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}