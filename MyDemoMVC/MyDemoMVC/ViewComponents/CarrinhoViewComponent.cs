using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyDemoMVC.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItensCarrinho = 3;
        }
        public async Task<IViewComponentResult> InvokeSync()
        {
            return View(ItensCarrinho);
        }
    }
}
