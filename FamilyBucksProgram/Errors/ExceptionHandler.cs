using System;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public static class ExceptionHandler {
        
        public static void RespondTo(Exception exception, string customMessage = "") {
            log.Error($"Exception: {exception.StackTrace}" );
            string messageToShow = "An unexpected problem occurred!";
            if (string.IsNullOrEmpty(customMessage) == false)
                messageToShow = customMessage;


            MessageBox.Show(messageToShow, "Oopsies!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
