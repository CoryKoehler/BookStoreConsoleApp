using EventFlow.Aggregates;
using EventFlow.EventStores;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.Ids;
using EventFlowConsoleApp.ValueObjects;

namespace EventFlowConsoleApp.Events
{
    [EventVersion("FinalGradeAssigned", 1)]
    public class FinalGradeAssigned : AggregateEvent<ExamAggregate, ExamId>
    {
        public Grade Grade { get; private set; }
        public FinalGradeAssigned(Grade grade)
        {
            Grade = grade;
        }
    }
}