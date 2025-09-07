using Konquest.Student.Model.StudentSettings.Helpers;

namespace Konquest.Student.Model.StudentSettings;

public record StudentPrivacy(ViewAccess ProfileViewAccess, ViewAccess ProgressViewAccess);