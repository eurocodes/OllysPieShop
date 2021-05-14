using Microsoft.AspNetCore.Mvc;
using OllysPieShop.Interfaces;
using OllysPieShop.ViewModels;

namespace OllysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModels piesListViewModel = new PiesListViewModels();
            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(piesListViewModel);
        }
    }
}
