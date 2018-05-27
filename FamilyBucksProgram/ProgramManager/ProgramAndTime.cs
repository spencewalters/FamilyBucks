using System;

namespace FamilyBucksProgram
{
    public class ProgramAndTime
    {
        public string programID;
        public DateTime playDate;

        public bool IsActive { get => (String.IsNullOrEmpty(programID) == false); }
    }
}