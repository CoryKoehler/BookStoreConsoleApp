using System;
using EventFlow.Commands;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.CommandHandlers.Results;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Commands
{
    public class StartScoringCommand : Command<ExamAggregate, ExamId, StartScoringExecutionResult>
    {
        public StartScoringCommand(Guid id) : base(ExamId.With(id))
        {
        }
    }
}
