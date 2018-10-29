using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            // GravarUsandoEntity();
            //RecuperandoDados();
           // DeletarDados();
           //RecuperandoDados();
           //AlterarDados();
           RecuperandoDados();
        }

        private static void AlterarDados()
        {
            using( var repo = new LojaContext()){
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var produto in produtos)
                {
                    produto.Nome += "- Editado";
                }
                repo.SaveChanges();
            }
        }

        private static void DeletarDados()
        {
            using(var repo = new LojaContext()){
                IList<Produto> produtos = repo.Produtos.ToList();

                foreach (var produto in produtos)
                {
                    repo.Remove(produto);
                }
                repo.SaveChanges();
            }
            
        }

        private static void RecuperandoDados()
        {
           using(var repo = new LojaContext())
           {
               IList<Produto> produtos = repo.Produtos.ToList();
                Console.Write("Existem {0} Produtos",produtos.Count);
               foreach (var produto in produtos)
               {
                   Console.WriteLine(produto.Nome);
               }
           }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;
            
            using (var contexto = new LojaContext())
            {
                  contexto.Produtos.Add(p);
                  contexto.SaveChanges();
            }
        }


        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;
/*
            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            } */
        }
    }
}
