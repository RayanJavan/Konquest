using Konquest.Domain.Student.IndepDataModels.Helpers;

namespace Konquest.Domain.Student.IndepDataModels;

public class Goal(Student Student, string Title, string Description) : ReferencableStudentObject(Student);