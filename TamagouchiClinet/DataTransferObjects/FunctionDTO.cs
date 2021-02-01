using System;
using System.Collections.Generic;
using System.Text;

namespace TamagouchiClinet.DataTransferObjects
{
    class FunctionDTO
    {
        public string Functionname { get; set; }
        public int AnimalId { get; set; }
        public DateTime FunctionDate { get; set; }
        public FunctionDTO() { }
    }
}
