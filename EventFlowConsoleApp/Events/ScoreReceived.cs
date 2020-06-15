using EventFlow.Aggregates;
using EventFlow.EventStores;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.Entities;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Events
{
    [EventVersion("ScoreReceived", 1)]
    public class ScoreReceived : AggregateEvent<ExamAggregate, ExamId>
    {
        public Score Score { get; private set; }
        public ScoreReceived(Score score)
        {
            Score = score;
        }
    }
}