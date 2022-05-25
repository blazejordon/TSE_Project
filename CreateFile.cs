using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSE
{
    internal class CreateFile
    {
        public string LoginData() //This checks if a file exists in Documents, if not it is created
        {
            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            string Newpath = (filepath + @"\TSEHealthAssistLogins.txt"); //File name
            if (!File.Exists(Newpath))
            {
                using (StreamWriter sw = File.CreateText(Newpath))
                {
                    sw.Close();
                }
            }
            return Newpath;
        }
    }
}
