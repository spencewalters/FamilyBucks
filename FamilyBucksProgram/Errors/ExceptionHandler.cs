using System;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public static class ExceptionHandler {
        
        public static void RespondTo(Exception exception, string customMessage = "") {
            Console.WriteLine($"Exception: {exception.StackTrace}" );
            string messageToShow = "An unexpected problem occurred!";
            if (string.IsNullOrEmpty(customMessage) == false)
                messageToShow = customMessage;

            MessageBox.Show(messageToShow, "Oopsies!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
