using System.Collections.Generic;
using EventFlow.Aggregates;
using EventFlow.EventStores;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.Entities;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Events
{
    [EventVersion("StudentExamAnswersSubmitted", 1)]
    public class StudentExamAnswersSubmitted : AggregateEvent<ExamAggregate, ExamId>
    {
        public StudentId StudentId { get; }
        public List<Answer> Answers { get; }


        public StudentExamAnswersSubmitted(StudentId studentId, List<Answer> answers)
        {
            StudentId = studentId;
            Answers = answers;
        }
    }
}