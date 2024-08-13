using LMS.Application.Common.Models.Questionnaire;
using LMS.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Ui.Controllers
{
    public class QuestionnairesController : Controller
	{
        private readonly IQuestionnaireService _questionnaireService;
        public QuestionnairesController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }


		//CRUD

        //Create for in_list memory
        private static List<QuestionnaireVM> _questionnaires = new List<QuestionnaireVM>();
		//create for autoincrement for id
		private static int _nextId = 1;
		[HttpGet]
		public IActionResult Index()
		{

			return View(_questionnaires);
		}
		[HttpGet("create")]
		public IActionResult Create()
		{
			//create new instance to createquestionnaireVM
			var model = new CreateQuestionnaireVM();
			//to create new 4 options for the questions
			model.Options =
			[
				new CreateQuestionnaireVM.CreateOptionVM(),
				new CreateQuestionnaireVM.CreateOptionVM(),
				new CreateQuestionnaireVM.CreateOptionVM(),
				new CreateQuestionnaireVM.CreateOptionVM(),
			];

			return View(model);
		}

		

		[HttpPost("create")]
		public IActionResult Create(CreateQuestionnaireVM model)
		{
			if (ModelState.IsValid)
			{
				// Create a new QuestionnaireVM instance from the model
				var newQuestionnaire = new QuestionnaireVM
				{
					// Assuming QuestionnaireVM has properties
					Id = _nextId++,
					Content = model.Content,
					TotalOptions = model.Options.Select(option => new QuestionnaireVM.TotalOption
					{
						Content = option.Content,
						IsCorrect =option.IsCorrect
					}).ToList()
				};

				// Add to the in-memory list
				_questionnaires.Add(newQuestionnaire);

				// Redirect to the index page to view the list of questionnaires
				return RedirectToAction("Index");
			}

			// If the model is not valid, redisplay the create view with validation errors
			return View(model);
		}
		[HttpGet("Edit/{id}")]
		public IActionResult Edit(int id)
		{
			//find the questionnaire in the collection where Id == id
			
			var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == id);
			//if questionnaire is null then it return NotFound
			if(questionnaire == null)
			{
				return NotFound();
			}
			//create a new QuestionnairVM instance from model
			var model = new QuestionnaireVM 
			{ 
				Content = questionnaire.Content,
                // Transform the list of options from the questionnaire into a list of view model objects
                // Each option is projected into a new 'QuestionnaireVM.TotalOption' with properties 'Content' and 'IsCorrect'.
                // The resulting list is assigned to 'TotalOptions'.
                TotalOptions = questionnaire.TotalOptions.Select(option => new QuestionnaireVM.TotalOption
				{
					Content = option.Content,
					IsCorrect = option.IsCorrect
				}).ToList()
			};

			return View(model);
		}
		[HttpPost("Edit/{id}")]
		public IActionResult Edit(int id, QuestionnaireVM model)
		{
			if (ModelState.IsValid)
			{
				var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == id);
				if (questionnaire == null)
				{
					return NotFound();
				}

				questionnaire.Content = model.Content;
				questionnaire.TotalOptions = model.TotalOptions.Select(option => new QuestionnaireVM.TotalOption
				{
					Content = option.Content,
					IsCorrect = option.IsCorrect
				}).ToList();

				return RedirectToAction("Index");
			}

			return View(model);
		}
		[HttpGet("Details/{id}")]
		public ActionResult Details(int id)
		{
			var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == id);
			if(questionnaire == null)
			{
				return NotFound();
				
			}
			return View(questionnaire);
		}

		[HttpGet("Delete/{id}")]
		public IActionResult Delete(int id)
		{
			var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == id);
			if (questionnaire != null)
			{
				_questionnaires.Remove(questionnaire);
			}
			return RedirectToAction("Index");
		}

		

	}
}
