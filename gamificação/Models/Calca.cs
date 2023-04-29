using gamificação.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamificação.Models
{
    public class Calca : Produto
    {
        public TamanhoCalca Tamanho { get; set; }
        public CorRoupa Cor { get; set; }
    }
}
