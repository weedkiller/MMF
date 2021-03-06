﻿using MFF.DTO.Entities.SmartLab;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MFF.ERPAPI.Services
{
    public interface ILSXService 
    {
        Task<int> AddAsync(IEnumerable<LenhSanXuatERP> items);
        Task<int> UpdateAsync(IEnumerable<LenhSanXuatERP> items);      
    }
    public interface ITTTieuHaoService
    {       
        Task<int> AddAsync(IEnumerable<ThongTinTieuHao> items);
        Task<int> UpdateAsync(IEnumerable<ThongTinTieuHao> items);
    }
}
