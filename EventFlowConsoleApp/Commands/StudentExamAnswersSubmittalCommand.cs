using System;
using System.Collections.Generic;
using EventFlow.Commands;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.CommandHandlers.Results;
using EventFlowConsoleApp.Entities;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Commands
{
    public class StudentExamAnswersSubmittalCommand : Command<ExamAggregate, ExamId, StudentExamAnswersSubmittalExecutionResult>
    {
        public StudentId StudentId { get; set; }
        public List<Answer> Answers { get; set; }

        public StudentExamAnswersSubmittalCommand(Guid examId, Guid studentId, List<Answer> answers) : base(ExamId.With(examId))
        {
            StudentId = StudentId.With(studentId);
            Answers = answers;
        }
    }
}
