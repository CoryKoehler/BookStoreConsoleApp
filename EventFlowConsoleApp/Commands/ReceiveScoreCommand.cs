using System;
using EventFlow.Commands;
using EventFlowConsoleApp.Aggregates;
using EventFlowConsoleApp.CommandHandlers.Results;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Commands
{
    public class ReceiveScoreCommand : Command<ExamAggregate, ExamId, ReceiveScoreExecutionResult>
    {
        public ProctorId ProctorId { get; }
        public double GradePercent { get; }
        public QuestionId QuestionId { get; }
        public AnswerId AnswerId { get; }

        public ReceiveScoreCommand(Guid examId, Guid proctorId, double gradePercent,
            QuestionId questionId, AnswerId answerId) : base(ExamId.With(examId))
        {
           ProctorId = ProctorId.With(proctorId);
           GradePercent = gradePercent;
           QuestionId = questionId;
           AnswerId = answerId;
        }
    }
}