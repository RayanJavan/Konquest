using Konquest.Student.Model.StudentData;
using Konquest.Student.Model.StudentSettings;

namespace Konquest.Domain.Student;

public class Student(
    string Username,
    string PasswordHashed,
    StudentProfile Profile,
    StudentPrivacy Privacy,
    StudentDataDto StudentData,
    List<Student> Connections);