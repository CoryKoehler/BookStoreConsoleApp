using System.Threading;
using System.Threading.Tasks;
using EventFlow.Commands;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.CommandHandlers.Results;
using EventFlowConsoleApp.Commands;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.CommandHandlers
{
    public class StudentExamAnswersSubmittalCommandHandler : CommandHandler<ExamAggregate, ExamId, StudentExamAnswersSubmittalExecutionResult, StudentExamAnswersSubmittalCommand>
    {
        public StudentExamAnswersSubmittalCommandHandler() { }

        public override async Task<StudentExamAnswersSubmittalExecutionResult> ExecuteCommandAsync(ExamAggregate aggregate,
            StudentExamAnswersSubmittalCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            aggregate.StudentExamAnswersSubmitted(command.StudentId, command.Answers);

            return new StudentExamAnswersSubmittalExecutionResult(aggregate.Id.GetGuid().ToString(), true);
        }
    }
}
