using LMS.Application.Common.Models.Questionnaires;
using LMS.Application.Interfaces;
using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Ui.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly ILmsContext _dbContext;
        public QuestionnaireService(ILmsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<QuestionnaireVM> List()
        {
            var response = _dbContext.Questionnaires.Include(i => i.Options).Select(s => new QuestionnaireVM
            {
                Id = s.Id,
                Content = s.Content,
                TotalOptions = s.Options.Count,
            }).ToList();

            return response;
        }

        public QuestionnaireVM Get(int id)
        {
            var response = _dbContext.Questionnaires
                            .Include(q => q.Options)
                            .Where(q => q.Id == id)
                            .Select(q => new QuestionnaireVM
                            {
                                Id = q.Id,
                                Content = q.Content,
                                Options = q.Options.Select(s => new QuestionnaireVM.OptionVM
                                {
                                    Id = s.Id,
                                    Content = s.Content,
                                    IsCorrect = s.IsCorrect

                                }).ToList()
                            }).FirstOrDefault();

            return response;
        }


        public int Add(CreateQuestionnaireVM questionnaireVM)
        {
            var dbQuestionniare = new Questionnaire
            {
                Content = questionnaireVM.Content,
                IsActive = true,
                LastUpdatedAt = DateTimeOffset.Now,
                LastUpdatedBy = "Anupam",
                Options = questionnaireVM.Options.Select(s => new Option
                {
                    Content = s.Content,
                    IsActive = true,
                    IsCorrect = s.IsCorrect,
                    LastUpdatedAt = DateTimeOffset.Now,
                    LastUpdatedBy = "Anusha"
                }).ToList()
            };

            _dbContext.Questionnaires.Add(dbQuestionniare);
            _dbContext.SaveChanges();

            return dbQuestionniare.Id;
        }
        public void Delete(int id)
        {
            var response = _dbContext.Questionnaires.FirstOrDefault(x => x.Id == id);
            if (response != null)
            {
                _dbContext.Questionnaires.Remove(response);
            }
            _dbContext.SaveChanges();
        }

		public int Update(UpdateQuestionnaireVM questionnaireVM)
		{
			var questionnaire = _dbContext.Questionnaires.Include(s => s.Options).FirstOrDefault(q => q.Id == questionnaireVM.Id);

			if (questionnaire == null)
			{
				throw new KeyNotFoundException($"Questionaire with  ID:{questionnaireVM.Id} not found");
			}

			questionnaire.Content = questionnaireVM.Content;
			questionnaire.LastUpdatedAt = DateTimeOffset.Now;
			questionnaire.LastUpdatedBy = "Ujjwal";

			questionnaire.Options.Clear();
			if (questionnaire.Options != null)
			{
				foreach (var optionVM in questionnaireVM.TotalOptions)
				{
					var option = new Option
					{
						Content = optionVM.Content,
						IsActive = true,
						IsCorrect = optionVM.IsCorrect,
						LastUpdatedAt = DateTimeOffset.Now,
						LastUpdatedBy = "Ujjwal"
					};
					questionnaire.Options.Add(option);
				};
			}

			_dbContext.SaveChanges();
			return questionnaire.Id;
		}
	}
}
