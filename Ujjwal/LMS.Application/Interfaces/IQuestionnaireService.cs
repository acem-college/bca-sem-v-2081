using System.Runtime.CompilerServices;
using LMS.Application.Common.Models.Questionnaire;

namespace LMS.Application.Interfaces
{
    public interface IQuestionnaireService
    {
        List<QuestionnaireVM> List();
        QuestionnaireVM Get(int id);
        int Add(CreateQuestionnaireVM questionnaireVM);
        int Update(UpdateQuestionnaireVM questionnaireVM);
		int Delete(int id);

	}
}
