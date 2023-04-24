using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LiveProduction
{
    public partial class Form1 : Form
    {


        public Form1()
        {
#if DEBUG
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();
            AllocConsole();
#endif
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Test");

            const string title = "About LiveProduction";
            const string license = "Copyright 2023 Avellea - See LICENSE for more information.\n\n";
            const string about = "LiveProduction is an open source alternative to the Sony SDK LiveArea Authoring Tools.";

            MessageBox.Show(
                license + about,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
                );

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Entered...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ConvertProgressBar.Value);
            ConvertProgressBar.Value += 33;
        }
    }
}