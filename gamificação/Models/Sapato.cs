using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gamificação.Models.Enums;

namespace gamificação.Models
{
    public class Sapato : Acessorio
    {
        public TamanhoSapato TamanhoSapato { get; set; }
        public string Marca { get; set; }
    }

}
