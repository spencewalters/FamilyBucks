using System;
using System.Collections.Generic;

namespace FamilyBucksProgram {
    public class PlayHistory : FamilyData {
        private string ID;
        private List<ProgramAndTime> history;
        private GeneralState state = GeneralState.EMPTY;

        public string Key { get => ID; }
        public void SetKey(string key) { ID = key; }
        public List<ProgramAndTime> Items => history;

        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY; }
        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE; }
        public void Destroy() { state = GeneralState.EMPTY; }

        public PlayHistory() {
            ID = Guid.NewGuid().ToString();
            history = new List<ProgramAndTime>();
        }

        public int CountMatching(string programID) {
            int count = 0;

            foreach (ProgramAndTime pair in history)
                if (pair.programID == programID)
                    count++;

            return count;
        }

        public int CountMatching(string programID, DateTime start, DateTime end) {
            int count = 0;

            foreach (ProgramAndTime pair in history) {
                if (pair.programID == programID) {
                    if ((pair.playDate.CompareTo(start) >= 0) &&
                        (pair.playDate.CompareTo(end) < 0))
                        count++;
                }
            }

            return count;
        }

        public void AddEntry(ProgramAndTime pair) {
            history.Add(pair);
        }

        public void AddEntry(string programID) {
            ProgramAndTime pair = new ProgramAndTime();
            pair.programID = programID;
            pair.playDate = DateTime.Now;
            history.Add(pair);
        }
    }
}
