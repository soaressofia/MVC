using CadastroProdutos.Models;
using Microsoft.AspNetCore.Mvc;
// Importa recursos do framework
namespace CadastroProdutos.Controllers;
// Organiza as classes
public class ProdutosController : Controller 
//.          Nome do Controller    Herança da classe Controller
{
    public IActionResult Index()
    // IActionResult = Tipo de ação
    //Index() = Método responsável pela página inicial 
{
    var produtos = new List<Produto>
    {
            new Produto
            {
                Id=1,
                Nome="Teclado",
                Preco= 129.90m,
                Estoque= 15
            },
             new Produto
            {
                Id=2,
                Nome="Mouse",
                Preco= 59.90m,
                Estoque = 15
            },
             new Produto
            {
                Id=3,
                Nome="Monitor",
                Preco= 899.90m,
                Estoque = 15
            }

        };
    return View(produtos);
    //return Content ("Página de produtos");
    // Content = Retorna conteúdo textual
}
} 