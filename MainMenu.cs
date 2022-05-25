using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Windows.Input;

using System.Timers;

namespace TSE
{
  
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();





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
/*


namespace TSE
{
    public partial class MainMenu : Form
    {
        public static int minutesCount = 0;
        public static System.Timers.Timer aTmr = new System.Timers.Timer(60000);

        bool stop = false;
        bool save = false;

        [DllImport("PresentationCore.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        public MainMenu()
        {
            InitializeComponent();

            

        }

        



        private void UserStats_Click(object sender, EventArgs e)
        {
            StatisticsScreen Stats = new StatisticsScreen();
            Stats.Show();
            this.Hide();
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



        private void StartLogging_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool save = false;

            

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

            aTmr.Elapsed += ATmr_Elapsed;
            aTmr.Enabled = true;
            aTmr.AutoReset = true;
            aTmr.Start();

            while (stop = false)
            {
                System.Threading.Thread.Sleep(5);



                for (int i = 32; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState != 0)
                    {
                        count++;
                        


                        if (save == true)
                        {
                            string toSave = count.ToString();

                            using (StreamWriter sw = File.AppendText(path))
                            {
                                sw.Write(toSave, "\n");
                            }

                            save = false;
                            count = 0;
                        }
                    }
                }





            }

          

            


        }

        private void ATmr_Elapsed(object? sender, ElapsedEventArgs e)
        {
            minutesCount++;
            save = true;
        }

        private void StopLogging_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
*/