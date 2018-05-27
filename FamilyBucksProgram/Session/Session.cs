using System;

namespace FamilyBucksProgram {
    public interface Session : FamilyData {
        User User { get; }
        AccountInformation AccountInfo { get;  }
        PlayHistory ProgramsRun { get; }
        TimeSpan LoginDuration { get; }
        DateTime LoginTime { get; }
    }
}
