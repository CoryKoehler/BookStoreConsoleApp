using System.Collections.Generic;
using EventFlow.Aggregates;
using EventFlow.EventStores;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.Entities;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Events
{
    [EventVersion("ExamAssigned", 1)]
    public class ExamAssigned : AggregateEvent<ExamAggregate, ExamId>
    {
        public StudentId StudentId { get; }
        public string ExamCode { get; }
        public List<Question> Questions { get; }
   

        public ExamAssigned(StudentId studentId, string examCode, List<Question> questions)
        {
            StudentId = studentId;
            ExamCode = examCode;
            Questions = questions;
        }
    }
}
