using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagouchiClinet.DataTransferObjects
{
    public class PlayerDTO
    {

        public int PlayerId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PlayerGender { get; set; }
        public DateTime? PbirthDay { get; set; }
        public string PfirstName { get; set; }
        public string PlastName { get; set; }
        public string PlayerPassword { get; set; }
        public PlayerDTO()
        { }
       

    }
}
