using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamificação.Models
{
    public class Pagamento
    {
        public CarrinhoDeCompras CarrinhoDeCompras { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoEntrega { get; set; }

        public void RealizarPagamento()
        {
            GerarNotaFiscal();
        }

        public void GerarNotaFiscal()
        {
            Console.WriteLine("Nota Fiscal");
            Console.WriteLine($"Nome do Cliente: {NomeCliente}");
            Console.WriteLine($"Endereço de Entrega: {EnderecoEntrega}");

            foreach (Produto produto in CarrinhoDeCompras.Produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome} - Preço: {produto.Preco}");
            }

            decimal totalDescontos = 0;
            foreach (Promocao promocao in CarrinhoDeCompras.Promocoes)
            {
                totalDescontos += promocao.CalcularDesconto();
            }

            decimal totalCompra = CarrinhoDeCompras.ObterValorTotal();
            Console.WriteLine($"Total dos produtos: {totalCompra}");
            Console.WriteLine($"Total de descontos: {totalDescontos}");
            Console.WriteLine($"Total a pagar: {totalCompra - totalDescontos}");
        }
    }

}
