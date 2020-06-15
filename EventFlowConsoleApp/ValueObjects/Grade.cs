using EventFlow.ValueObjects;

namespace EventFlowConsoleApp.ValueObjects
{
    public class Grade : ValueObject
    {
        public double GradePercent { get; private set; }
        public string GradeValue { get; private set; }

        public Grade(double gradePercent, string gradeValue)
        {
            GradePercent = gradePercent;
            GradeValue = gradeValue;
        }

        public Grade(double gradePercent)
        {
            GradePercent = gradePercent;
        }
    }
}
