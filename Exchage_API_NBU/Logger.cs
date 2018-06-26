using System;
using System.IO;
using System.Text;

namespace Exchage
{
    public class Logger
    {
        private static readonly string currentDir = Directory.GetCurrentDirectory();
        private static string pathToLog = Path.Combine(currentDir, "Log.txt");
        private static string pathToCheck = Path.Combine(currentDir, "Check.txt");

        FileInfo fi = new FileInfo(pathToLog);
        FileInfo check = new FileInfo(pathToCheck);

        FileStream s = null;
        FileStream ch = null;
        public void WriteLine(string message)
        {
            if (!fi.Exists)
                try { s = fi.Create(); }
                catch (Exception e) { Console.WriteLine(e.Message); }
                finally { s?.Close(); }

            File.AppendAllText("Log.txt", message);
            
        }
        public void Write(string message)
        {
            Logger log = new Logger();
            try
            {
                if(File.Exists(pathToCheck)) { File.Delete(pathToCheck); }

                using (FileStream fs = File.Create(pathToCheck))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(message);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                log.WriteLine(ex.Message);
            }

        }
    }
}
