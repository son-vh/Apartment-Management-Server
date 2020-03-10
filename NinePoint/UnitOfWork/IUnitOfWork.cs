using NinePoint.Entities;
using NinePoint.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinePoint.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEquipmentReponsitory equipmentReponsitory { get; set; }
        IResidentReponsitory  residentReponsitory { get; set; }
        IJobInfoRepository jobInfoRepository { get; set; }
        ISupportRepository supportRepository { get; set; }

        Task SaveAsync();
    }
}
