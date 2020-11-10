using System.ComponentModel;
using System.ServiceProcess;
using System.Configuration.Install;


namespace WindowsService1
{
    [RunInstaller(true)]
    public class SendMailServiceInstaller : Installer
    {
        public SendMailServiceInstaller()
        {
            var processInstaller = new ServiceProcessInstaller();
            var serviceInstaller = new ServiceInstaller();
            processInstaller.Account = ServiceAccount.LocalSystem;
            processInstaller.Username = null;
            processInstaller.Password = null;
            serviceInstaller.DisplayName = "MailListenserService";
            serviceInstaller.StartType = ServiceStartMode.Automatic;
            serviceInstaller.ServiceName = "MailListenserService";
            serviceInstaller.Description = "Automatic send mail";
            this.Installers.Add(processInstaller);
            this.Installers.Add(serviceInstaller);
        }
    }

}
