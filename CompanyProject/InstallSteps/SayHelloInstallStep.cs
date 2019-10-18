using WixSharp;

namespace CompanyProject.InstallSteps
{
    public static class SayHelloInstallStep
    {
        public static void Handle(SetupEventArgs e, string appName)
        {
            if (e.IsInstalling)
            {
                e.Session.Log("----------------------------------------------------");
                e.Session.Log($"App {appName} is going to be installed...");
                e.Session.Log("----------------------------------------------------");
            }
        }
    }
}