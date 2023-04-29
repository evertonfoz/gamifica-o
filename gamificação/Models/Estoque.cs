using gamificação.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gamificação.Models
{
    public class Estoque
    {
        private List<Produto> _produtos;

        public Estoque()
        {
            _produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public List<Produto> ListarProdutos(int code)
        {
            List<Produto> produtosFiltrados = new List<Produto>();
            foreach (var produto in _produtos)
            {
                if (code == produto.Tipo)
                {
                    produtosFiltrados.Add(produto);
                }
            }
            return produtosFiltrados;
        }

        public void RemoverProduto(int codigo)
        {
            var produto = _produtos.FirstOrDefault(p => p.Codigo == codigo);
            if (produto != null)
            {
                _produtos.Remove(produto);
            }
        }
        public Produto ObterProdutoPorCodigo(int codigo,int tipo)
        {
            return _produtos.FirstOrDefault(p => p.Codigo == codigo && p.Tipo == tipo);
        }




        public Produto AdicionarProdutoNoCarrinho(int codigo, int tipo)
        {
            List<Produto> produtosFiltrados = ListarProdutos(tipo);
            var produto = produtosFiltrados.FirstOrDefault(p => p.Codigo == codigo);
            if (produto != null)
            {
                _produtos.Remove(produto);
                return produto;
            }
            return null;
        }


    }
}


