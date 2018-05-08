﻿using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Repository;
using System.Reflection;
using log4net.Repository.Hierarchy;
using log4net.Layout;
using log4net;
using log4net.Appender;
using System.Configuration;
using log4net.Core;

namespace BackupDatabase
{
    class OwnConfigurationAttribute : ConfiguratorAttribute
    {
        public OwnConfigurationAttribute() : base(0)
        {
        }

        public override void Configure(Assembly sourceAssembly, ILoggerRepository targetRepository)
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender roller = new RollingFileAppender();
            roller.AppendToFile = false;
            roller.File = ConfigurationManager.AppSettings["LogFileLocation"];
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = 5;
            roller.MaximumFileSize = "1GB";
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.StaticLogFileName = true;
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);

            MemoryAppender memory = new MemoryAppender();
            memory.ActivateOptions();
            hierarchy.Root.AddAppender(memory);

            hierarchy.Root.Level = Level.Info;
            hierarchy.Configured = true;
        }
    }
}
