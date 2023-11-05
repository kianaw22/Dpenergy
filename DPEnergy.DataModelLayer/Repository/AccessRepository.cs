using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DPEnergy.DataModelLayer.ViewModels.Admin;
using DPEnergy.DataModelLayer.Services;

namespace DPEnergy.DataModelLayer.Repository
{
   public  class AccessRepository: IAccessRepository
    {
        private readonly ApplicationDbContext _context;
        public AccessRepository(ApplicationDbContext db)
        {
            _context = db;

        }
        public List<NameAndPersonelCodeViewModel> GetNameFromPersonelCode()
        {
            var query = (from p in _context.P_Personel
                         join u in _context.A_UserManager on p.PersonelCode equals u.Personel
                         select new NameAndPersonelCodeViewModel
                         {
                             Id = u.Id,
                             FirstName = p.FirstName,
                             LastName = p.LastName,
                             PersonelCode = u.Personel,
                             UserName = u.UserName
                         }).ToList(); 
            return query;  
        }
    }
}
