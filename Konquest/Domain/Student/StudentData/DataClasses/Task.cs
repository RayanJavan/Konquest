using Konquest.Domain.Student.IndepDataModels.Helpers;

namespace Konquest.Domain.Student.IndepDataModels;

public class Task(Student Student, string Title, string Description, TimeInterval TaskTimeInterval, Goal RelatedGoal)
    : ReferencableStudentObject(Student);