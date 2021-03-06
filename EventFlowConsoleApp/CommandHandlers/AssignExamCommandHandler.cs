﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EventFlow.Commands;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.CommandHandlers.Results;
using EventFlowConsoleApp.Commands;
using EventFlowConsoleApp.Entities;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.CommandHandlers
{
    public class AssignExamCommandHandler : CommandHandler<ExamAggregate, ExamId, AssignExamExecutionResult, AssignExamCommand>
    {
        public AssignExamCommandHandler() { }

        public override async Task<AssignExamExecutionResult> ExecuteCommandAsync(ExamAggregate aggregate,
            AssignExamCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
            aggregate.ExamAssigned(command.StudentId, command.ExamCode, GenerateQuestionBank(command.ExamCode));

            return new AssignExamExecutionResult(aggregate.Id.GetGuid().ToString(), true);
        }

        //TODO this should be a new bounded context or returned from external service
        private static List<Question> GenerateQuestionBank(string examCode)
        {
            return new List<Question>()
            {
                new Question(QuestionId.New, examCode,
                    "True or False: This is a question", "True"),
                new Question(QuestionId.New, examCode,
                    "True or False: This is a question", "True"),
                new Question(QuestionId.New, examCode,
                    "True or False: This is a question", "True"),
                new Question(QuestionId.New, examCode,
                    "True or False: This is a question", "True"),
                new Question(QuestionId.New, examCode,
                    "True or False: This is a question", "False"),
                new Question(QuestionId.New, examCode,
                    "True or False: This is a question", "True"),
            };
        }
    }
}
