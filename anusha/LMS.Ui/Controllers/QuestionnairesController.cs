using LMS.Application.Interfaces;
using LMS.Application.Common.Models.Questionnaires;
using LMS.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace LMS.Ui.Controllers
{
    public class QuestionnairesController : Controller
    {
        private readonly IQuestionnaireService _questionnaireService;
        public QuestionnairesController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

        private static List<QuestionnaireVM>? _questionnaires;
        private static List<QuestionnaireVM> GetQuestionnaires()
        {
            if (_questionnaires == null)
            {
                _questionnaires = new List<QuestionnaireVM>
                {
                     new QuestionnaireVM
                     {
                         Id = 1,
                         Content = "Which of these is not a fruit?",
                         TotalOptions = 4,
                         Options = new List<string> { "Apple", "Banana", "Carrot", "Orange" }
                     },
                     new QuestionnaireVM
                     {
                         Id = 2,
                         Content = "Which of these is not a vegetable?",
                         TotalOptions = 4,
                         Options = new List<string> { "Carrot", "Broccoli", "Potato", "Apple" }
                     },
                     new QuestionnaireVM
                     {
                         Id = 3,
                         Content = "Which of these is not a fish?",
                         TotalOptions = 4,
                         Options = new List<string> { "Salmon", "Tuna", "Shark", "Eagle" }
                     },
                     new QuestionnaireVM
                     {
                         Id = 4,
                         Content = "Which of these is not a flower?",
                         TotalOptions = 4,
                         Options = new List<string> { "Rose", "Tulip", "Lily", "Rock" }
                     }
                };
            }

            return _questionnaires;
        }

        public IActionResult Index()
        {
            var model = GetQuestionnaires();
            return View(model);
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
                var newQuestionnaire = new QuestionnaireVM
                {
                    Id = _questionnaires.Count + 1,
                    Content = model.Content,
                    TotalOptions = model.Options.Count,
                    Options = model.Options.Select(o => o.Content).ToList()
                };
                _questionnaires.Add(newQuestionnaire);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == id);
            if (questionnaire == null)
            {
                return NotFound();
            }
            var model = new UpdateQuestionnaireVM
            {
                Id = questionnaire.Id,
                Content = questionnaire.Content,
                Options = questionnaire.Options,

            };
            return View(model);
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit(UpdateQuestionnaireVM model)
        {
            if (ModelState.IsValid)
            {
                var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == model.Id);
                if (questionnaire == null)
                {
                    return NotFound();
                }
                questionnaire.Content = model.Content;

                //  questionnaire.TotalOptions = model.Options.Count;
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == id);
            if (questionnaire == null)
            {
                return NotFound();
            }
            return View(questionnaire);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var questionnaire = _questionnaires.FirstOrDefault(q => q.Id == id);
            if (questionnaire == null)
            {
                return NotFound();
            }
            _questionnaires.Remove(questionnaire);
            return RedirectToAction("Index");
        }
    }
}
