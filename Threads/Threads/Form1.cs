using System.Threading;

namespace Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(MyThreadClass.Thread1) { Name = "ThreadA", Priority = ThreadPriority.Highest };
            Thread threadB = new Thread(MyThreadClass.Thread2) { Name = "ThreadB", Priority = ThreadPriority.Normal };
            Thread threadC = new Thread(MyThreadClass.Thread1) { Name = "ThreadC", Priority = ThreadPriority.BelowNormal };
            Thread threadD = new Thread(MyThreadClass.Thread2) { Name = "ThreadD", Priority = ThreadPriority.Lowest };

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            

            label1.Text = "-Thread End-";
            MessageBox.Show("-Thread End-");
        }
    }
}
