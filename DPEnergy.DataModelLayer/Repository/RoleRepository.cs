using DPEnergy.DataModelLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPEnergy.DataModelLayer.Repository
{
   public  class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext db)
        {
            _context = db;
        }
        public string GetRoleId ( string userId)
        {
            var getRoleId = _context.UserRoles.Where(u => u.UserId == userId).ToList();
            string getRoleString = "";
            for (int i = 0; i < getRoleId.Count; i++)
            {
                getRoleString += getRoleId[i].RoleId.ToString() + ",";
            }
            return getRoleString;
        }
    }
}
