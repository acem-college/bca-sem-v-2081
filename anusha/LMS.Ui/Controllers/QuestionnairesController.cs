using LMS.Application.Common.Models.Questionnaires;
using LMS.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LMS.Ui.Controllers
{
    [Authorize]
    public class QuestionnairesController : Controller
    {
        private readonly IQuestionnaireService _questionnaireService;
        public QuestionnairesController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var response = _questionnaireService.List();
            return View(response);
        }


        [HttpGet("create")]
        public IActionResult Create()
        {
            var model = new CreateQuestionnaireVM
            {
                Options = new List<CreateQuestionnaireVM.CreateOptionVm>
                {
                    new CreateQuestionnaireVM.CreateOptionVm(),
                    new CreateQuestionnaireVM.CreateOptionVm(),
                    new CreateQuestionnaireVM.CreateOptionVm(),
                    new CreateQuestionnaireVM.CreateOptionVm()
                }
            };
            return View(model);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateQuestionnaireVM model)
        {
            if (ModelState.IsValid)
            {
                var response = _questionnaireService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
		[HttpGet("Edit/{id}")]
		public IActionResult Edit(int id)
		{
			var result = _questionnaireService.Get(id);
			var model = new UpdateQuestionnaireVM
			{
				Id = result.Id,
				Content = result.Content,
				TotalOptions = result.Options.Select(s => new UpdateQuestionnaireVM.UpdateOptionVM
				{
					Content = s.Content,
					Id = s.Id,
					IsCorrect = s.IsCorrect
				}).ToList()
			};

			return View(model);
		}

		[HttpPost("Edit/{id}")]
		public IActionResult Edit(int id, UpdateQuestionnaireVM model)
		{
			if (ModelState.IsValid)
			{
				_questionnaireService.Update(model);
				return RedirectToAction("Index");
			}
			return View(model);
		}


		[HttpGet("Details/{id}")]
        public ActionResult Details(int id)
        {
            var result = _questionnaireService.Get(id);
            return View(result);
        }


        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            TempData["SuccessMessage"] = "Item successfully deleted.";
            _questionnaireService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}