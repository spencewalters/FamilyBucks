using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public static class FormHelper {
        public static bool TextFieldIsValid(string text) {
            return (string.IsNullOrWhiteSpace(text) == false);
        }
    }
}
