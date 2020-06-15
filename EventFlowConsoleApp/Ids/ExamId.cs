using EventFlow.Core;

namespace EventFlowConsoleApp.Ids
{
    public class ExamId : Identity<ExamId>
    {
        public ExamId(string value) : base(value) { }
    }
}
