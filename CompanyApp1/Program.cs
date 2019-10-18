using CompanyProject;
using CompanyProject.InstallSteps;

namespace CompanyApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var project = new CompanySetupProject("CompanyApp1");

            project.AfterInstall += (e) => SayHelloInstallStep.Handle(e, "Company App 1");

            project.BuildMsi();
        }
    }
}