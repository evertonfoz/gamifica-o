using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gamificação.Models.Enums;

namespace gamificação.Models
{
    public class Promocao
    {
        public decimal ValorDesconto { get; set; }
        public TipoDesconto TipoDesconto { get; set; }
        public List<Produto> Produtos { get; set; }

        public decimal CalcularDesconto()
        {
            decimal totalDesconto = 0;

            foreach (Produto produto in Produtos)
            {
                if (produto.Categoria == CategoriaProduto.Acessorio)
                {
                    Acessorio acessorio = (Acessorio)produto;
                    if (acessorio.Tamanho == TamanhoAcessorio.G)
                    {
                        if (TipoDesconto == TipoDesconto.Porcentagem)
                        {
                            totalDesconto += (produto.Preco * ValorDesconto / 100);
                        }
                        else if (TipoDesconto == TipoDesconto.ValorFixo)
                        {
                            totalDesconto += ValorDesconto;
                        }
                    }
                }
                else if (produto.Categoria == CategoriaProduto.Camiseta)
                {
                    if (TipoDesconto == TipoDesconto.Porcentagem)
                    {
                        totalDesconto += (produto.Preco * ValorDesconto / 100);
                    }
                    else if (TipoDesconto == TipoDesconto.ValorFixo)
                    {
                        totalDesconto += ValorDesconto;
                    }
                }
            }

            return totalDesconto;
        }
    }

}
