using LMS.Application.Interfaces;
using LMS.Application.Common.Models.Questionaires;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Ui.Controllers
{
    public class QuestionairesController : Controller
    {
        private readonly IQuestionareService _questionaireService;
        public QuestionairesController(IQuestionareService questionareServices)
        {
                _questionaireService = questionareServices;
        }

        public IActionResult Index()
        {
            List <QuestionairesVM> model = new List <QuestionairesVM> ();
            
            return View(model);
        }
    }
}
