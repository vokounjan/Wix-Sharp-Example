using CompanyProject.InstallSteps;
using System.Collections.Generic;
using WixSharp;

namespace CompanyProject
{
    public class CompanySetupProject : ManagedProject
    {
        public CompanySetupProject(string name)
        {
            Name = name;
            InstallScope = WixSharp.InstallScope.perMachine;
            InstallPrivileges = WixSharp.InstallPrivileges.elevated;
            ManagedUI = WixSharp.ManagedUI.Empty;
            Platform = WixSharp.Platform.x86;
            OutDir = $@"C:\MSI\{Name}";
            PreserveTempFiles = true;
            DefaultRefAssemblies = new List<string> { "bin/Debug/CompanyProject.dll", };
        }

        public void SayHelloBeforeInstall(string appName)
        {
            AfterInstall += (e) => SayHelloInstallStep.Handle(e, appName);
        }
    }
}