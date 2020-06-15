using System;
using EventFlow.Commands;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.CommandHandlers.Results;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Commands
{
    public class AssignExamCommand : Command<ExamAggregate, ExamId, AssignExamExecutionResult>
    {
        public string ExamCode { get; set; }
        public StudentId StudentId { get; set; }

        public AssignExamCommand(string examCode, Guid studentId) : base(ExamId.New)
        {
            ExamCode = examCode;
            StudentId = StudentId.With(studentId);
        }
    }
}
