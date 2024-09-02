using LMS.Application.Common.Models.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace LMS.Application.Interfaces
{
    public interface IQuestionnaireService
    {
        int Add(CreateQuestionnaireVM questionnaireVM);
        List<QuestionnaireVM> List();
        QuestionnaireVM Get(int id);

        int Update(UpdateQuestionnaireVM questionnaireVM);

        void Delete(int id);
       
    }
}
