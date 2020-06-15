using System.Threading;
using System.Threading.Tasks;
using EventFlow.Commands;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.CommandHandlers.Results;
using EventFlowConsoleApp.Commands;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.CommandHandlers
{
    public class StartScoringCommandHandler : CommandHandler<ExamAggregate, ExamId, StartScoringExecutionResult, StartScoringCommand>
    {
        public StartScoringCommandHandler() { }

        public override async Task<StartScoringExecutionResult> ExecuteCommandAsync(ExamAggregate aggregate,
            StartScoringCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
            aggregate.ScoringStarted();

            return new StartScoringExecutionResult(aggregate.Id.GetGuid().ToString(), true);
        }
    }
}
