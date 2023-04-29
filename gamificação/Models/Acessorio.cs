using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gamificação.Models.Enums;

namespace gamificação.Models
{
    public abstract class Acessorio : Produto
    {
        public TamanhoAcessorio Tamanho { get; set; }
        public CorAcessorio Cor { get; set; }


    }
}

