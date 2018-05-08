using Topshelf;

namespace BackupDatabase
{
    static class ConfigureService
    {
        public static readonly bool IsConfigured=false;
        static ConfigureService()
        {
            IsConfigured = true;
            HostFactory.Run(configure =>
            {
                configure.Service<MyService>(service =>
                {
                    service.ConstructUsing(s => new MyService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                //Setup Account that window service use to run.  
                configure.RunAsLocalSystem();
                configure.SetServiceName("DatabaseBackupService");
                configure.SetDisplayName("DatabaseBackupService");
                configure.SetDescription("Scheduled Db Backup");
            });
        }
    }
}
