using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gamificação.Models;
using gamificação.Models.Enums;
namespace gamificação.Models
{
    public class Bolsa : Acessorio
    {
        public string Material { get; set; }
        public int NumeroCompartimentos { get; set; }
    }

}
