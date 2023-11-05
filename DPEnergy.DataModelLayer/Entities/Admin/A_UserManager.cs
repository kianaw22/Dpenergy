using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Admin
{
   
    public class A_UserManager: IdentityUser
    {
        [Key]
        public override string Id { get; set; }
        public string Personel { get; set; }
        override public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPass { get; set; }
        override public string Email { get; set; }
        public string SystemUserName { get; set; }
        public string SystemPassword { get; set; }
        public bool IsActive { get; set; }
        public byte IsAdmin { get; set; }

    }
}
