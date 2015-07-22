using System.Collections.Generic;
using System.Web.Http;

namespace TesteCompressaoWebAPI
{
    public class ProdutosController : ApiController
    {
        public IEnumerable<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            Produto prod;
            for (int i = 1; i <= 100; i++)
            {
                prod = new Produto();
                prod.CodProduto = i.ToString("0000");
                prod.NomeProduto = string.Format("PRODUTO {0:0000}", i);
                prod.Preco = i / 10.0;

                produtos.Add(prod);
            }

            return produtos;
        }
    }
}