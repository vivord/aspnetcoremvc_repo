using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers
{

    public class TutorialController : Controller
    {
        private readonly ITutorialRepository _tourRepository;
        public TutorialController(ITutorialRepository tutorialRepository)
        {
            _tourRepository = tutorialRepository;
        }
        public IActionResult Index()
        {
            //var tutorials = new List<Tutorial>
            //{
            //    new Tutorial{Id =1, Name = "C#", Description = "C# Tutorial"},
            //    new Tutorial{Id =2, Name = "Asp.net core", Description = "Asp.net core Tutorial"},
            //};
            //var tutorials = new TutorialRepository().GetAllTutorial();
            var tutorials = _tourRepository.GetAllTutorial();
            return View(tutorials);
        }
    }
}
