using EventFlow.Entities;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Entities
{
    public class Answer : Entity<QuestionId>
    {
      public StudentId StudentId { get; private set; }
      public string StudentAnswer { get; private set; }

        public Answer(QuestionId id, StudentId studentId, string studentAnswer) : base(id)
        {
            StudentId = studentId;
            StudentAnswer = studentAnswer;
        }
    }
}
