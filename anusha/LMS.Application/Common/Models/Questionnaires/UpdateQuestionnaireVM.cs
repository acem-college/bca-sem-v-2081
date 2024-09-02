namespace LMS.Application.Common.Models.Questionnaires
{
    public class UpdateQuestionnaireVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<string> Options { get; set; }

    }
}
