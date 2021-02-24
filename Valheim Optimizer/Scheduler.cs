using Microsoft.Win32.TaskScheduler;

namespace Valheim_Optimizer
{
    class Scheduler
    {
        public static void Add_scheduler()
        {
            using (TaskService ts = new TaskService())
            {
                if (ts.FindTask("Valheim") == null)
                {
                    // Create a new task definition and assign properties
                    TaskDefinition td = ts.NewTask();
                    td.RegistrationInfo.Description = "Adds High Priority to Valheim.";

                    // Create a trigger that will fire the task at this time every other day
                    td.Triggers.Add(new BootTrigger { Delay = System.TimeSpan.FromSeconds(120) });

                    // Create an action that will launch Notepad whenever the trigger fires
                    td.Actions.Add(new ExecAction(System.Reflection.Assembly.GetEntryAssembly().Location, "-startup", null));

                    // Register the task in the root folder
                    ts.RootFolder.RegisterTaskDefinition(@"Valheim", td);
                }
            }
        }

        public static void Remove_scheduler()
        {
            using (TaskService ts = new TaskService())
            {
                if (ts.FindTask("Valheim") != null)
                {
                    ts.RootFolder.DeleteTask("Valheim");
                }
            }
        }
    }
}
