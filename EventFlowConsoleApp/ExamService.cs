using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EventFlow;
using EventFlowConsoleApp.Commands;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp
{
    public interface IExamService
    {

    }

    public class ExamService : IExamService
    {
        private readonly ICommandBus _commandBus;

        public ExamService(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task<string> AssignExamAsync(string examCode, Guid studentId, CancellationToken cancellationToken)
        {
            var command = new AssignExamCommand(examCode, studentId);
            var result = await _commandBus.PublishAsync(command, cancellationToken);

            return result.ExamId;
        }
    }
}
