using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;
using log4net.Repository.Hierarchy;
using log4net.Layout;
using log4net.Appender;
using System.Configuration;

namespace BackupDatabase
{
    static class Log 
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //static Log()
        //{
        //    Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

        //    PatternLayout patternLayout = new PatternLayout();
        //    patternLayout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
        //    patternLayout.ActivateOptions();

        //    RollingFileAppender roller = new RollingFileAppender();
        //    roller.AppendToFile = false;
        //    roller.File = ConfigurationManager.AppSettings["LogFileLocation"];
        //    roller.Layout = patternLayout;
        //    roller.MaxSizeRollBackups = 5;
        //    roller.MaximumFileSize = "1GB";
        //    roller.RollingStyle = RollingFileAppender.RollingMode.Size;
        //    roller.StaticLogFileName = true;
        //    roller.ActivateOptions();
        //    hierarchy.Root.AddAppender(roller);

        //    MemoryAppender memory = new MemoryAppender();
        //    memory.ActivateOptions();
        //    hierarchy.Root.AddAppender(memory);

        //    hierarchy.Root.Level = Level.Info;
        //    hierarchy.Configured = true;
        //}

        public static bool IsDebugEnabled
        {
            get
            {
                return log.IsDebugEnabled;
            }
        }

        public static bool IsErrorEnabled
        {
            get
            {
                return log.IsErrorEnabled;
            }
        }

        public static bool IsFatalEnabled
        {
            get
            {
                return log.IsFatalEnabled;
            }
        }

        public static bool IsInfoEnabled
        {
            get
            {
                return log.IsInfoEnabled;
            }
        }

        public static bool IsWarnEnabled
        {
            get
            {
                return log.IsWarnEnabled;
            }
        }

        public static ILogger Logger
        {
            get
            {
                return log.Logger;
            }
        }

        public static void Debug(object message)
        {
            log.Debug(message);
        }

        public static void Debug(object message, Exception exception)
        {
            log.Debug(message, exception);
        }

        public static void DebugFormat(string format, object arg0)
        {
            log.DebugFormat(format, arg0);
        }

        public static void DebugFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void DebugFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public static void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public static void Error(object message)
        {
            log.Debug(message);
        }

        public static void Error(object message, Exception exception)
        {
            log.Debug(message, exception);
        }

        public static void ErrorFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void ErrorFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public static void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public static void Fatal(object message)
        {
            log.Fatal(message);
        }

        public static void Fatal(object message, Exception exception)
        {
            log.Fatal(message,exception);
        }

        public static void FatalFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public static void FatalFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void FatalFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public static void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public static void Info(object message)
        {
            log.Info(message);
        }

        public static void Info(object message, Exception exception)
        {
            log.Info(message, exception);
        }

        public static void InfoFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public static void InfoFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public static void InfoFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public static void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public static void Warn(object message)
        {
            log.Warn(message);
        }

        public static void Warn(object message, Exception exception)
        {
            log.Warn(message, exception);
        }

        public static void WarnFormat(string format, object arg0)
        {
            log.WarnFormat(format, arg0);
        }

        public static void WarnFormat(string format, params object[] args)
        {
            log.WarnFormat(format, args);
        }

        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            log.WarnFormat(provider, format, args);
        }

        public static void WarnFormat(string format, object arg0, object arg1)
        {
            log.WarnFormat(format, arg0, arg1);
        }

        public static void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            log.WarnFormat(format, arg0, arg1, arg2);
        }
    }
}
