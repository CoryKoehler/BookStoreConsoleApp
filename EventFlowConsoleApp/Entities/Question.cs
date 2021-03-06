﻿using EventFlow.Entities;
using EventFlowConsoleApp.Ids;

namespace EventFlowConsoleApp.Entities
{
    public class Question : Entity<QuestionId>
    {
        public string ExamCode { get; private set; }
        public string ExamQuestion { get; private set; }
        public string ExamQuestionAnswer { get; private set; }

        public Question(QuestionId id, string examCode, string examQuestion, string examQuestionAnswer) : base(id)
        {
            ExamCode = examCode;
            ExamQuestion = examQuestion;
            ExamQuestionAnswer = examQuestionAnswer;
        }
    }
}