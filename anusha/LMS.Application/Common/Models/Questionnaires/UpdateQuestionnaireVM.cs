namespace LMS.Application.Common.Models.Questionnaires
{
    public class UpdateQuestionnaireVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<UpdateOptionVM> TotalOptions { get; set; }

        public class UpdateOptionVM
        {
            public string Content { get; set; }
            public int Id { get; set; }
            public bool IsCorrect { get; set; }
        }
    }
}
