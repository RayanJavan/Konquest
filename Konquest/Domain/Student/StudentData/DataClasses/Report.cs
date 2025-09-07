using Konquest.Domain.Student.IndepDataModels.Helpers;

namespace Konquest.Domain.Student.IndepDataModels;

public class Report(
    Student Student,
    ReferencableStudentObject ReferencableStudentObject,
    string Title,
    string Description) : ReferencableStudentObject(Student);