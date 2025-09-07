using Konquest.Domain.Student.IndepDataModels.Helpers;

namespace Konquest.Domain.Student.IndepDataModels;

public class Plan(Student Student, List<Task> Tasks): ReferencableStudentObject(Student);