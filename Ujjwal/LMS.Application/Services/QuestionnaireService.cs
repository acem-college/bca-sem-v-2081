using LMS.Application.Common.Models.Questionnaire;
using LMS.Application.Interfaces;
using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Ui.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly ILmscontext _dbContext;
        public QuestionnaireService(ILmscontext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<QuestionnaireVM> List()
        {
            var response = _dbContext.Questionnaires.Include(i =>i.Options).Select(s => new QuestionnaireVM
            {
                Id = s.Id,
                Content = s.Content,
                TotalOptions = s.Options.Count,

            }).ToList();
            return response;
        }

        public QuestionnaireVM Get(int id)
        {
            var response = _dbContext.Questionnaires.Include(i => i.Options)
                                                    .Where(w => w.Id == id)
                                                    .Select(s => new QuestionnaireVM
                                                    {
                                                        Id = s.Id,
                                                        Content = s.Content,
                                                        Options = s.Options.Select(s => new QuestionnaireVM.OptionVM
                                                        {
                                                            Id = s.Id,
                                                            Content = s.Content,
                                                            IsCorrect = s.Iscorrect
                                                        }).ToList()
                                                    })
                                                    .FirstOrDefault();
            return response;
        }

        public int Add(CreateQuestionnaireVM questionnaireVM)
        {
            var questionnaire = new Questionnaire
            {
                Content = questionnaireVM.Content,
                IsActive = true,
                LastUpdateAt = DateTimeOffset.Now,
                LastUpdateBy = "Ujjwal",
                Options = questionnaireVM.Options.Select(s => new Option
                {
                    Content = s.Content,
                    IsActive = true,
                    LastUpdateAt = DateTimeOffset.Now,
                    LastUpdateBy = "Ujjwal",

                }).ToList()
            };

            _dbContext.Questionnaires.Add(questionnaire);
            _dbContext.SaveChanges();

            return questionnaire.Id;
        }

        public int Update(UpdateQuestionnaireVM questionnaireVM)
        {
            var questionnaire = _dbContext.Questionnaires.Include(s => s.Options).FirstOrDefault(q => q.Id == questionnaireVM.Id);

            if (questionnaire == null)
            {
                throw new KeyNotFoundException($"Questionaire with  ID:{questionnaireVM.Id} not found");
            }

            questionnaire.Content = questionnaireVM.Content;
            questionnaire.LastUpdateAt = DateTimeOffset.Now;
            questionnaire.LastUpdateBy = "Ujjwal";

            questionnaire.Options.Clear();
            if (questionnaire.Options != null)
            {
                foreach (var optionVM in questionnaireVM.TotalOptions)
                {
                    var option = new Option
                    {
                        Content = optionVM.Content,
                        IsActive = true,
                        LastUpdateAt = DateTimeOffset.Now,
                        LastUpdateBy = "Ujjwal"
                    };
                    questionnaire.Options.Add(option);
                };
            }
            
            _dbContext.SaveChanges();
            return questionnaire.Id;
        }

        public int Delete(int id) 
        {
			var response = _dbContext.Questionnaires.FirstOrDefault(q => q.Id == id);
            if (response != null)
            {
                _dbContext.Questionnaires.Remove(response);
            }
			_dbContext.SaveChanges();
            return id;
		}
    }
}
