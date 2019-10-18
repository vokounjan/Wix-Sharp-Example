using CompanyProject;

namespace CompanyApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var project = new CompanySetupProject("CompanyApp2");

            project.SayHelloBeforeInstall("Company App 2");

            project.BuildMsi();
        }
    }
}