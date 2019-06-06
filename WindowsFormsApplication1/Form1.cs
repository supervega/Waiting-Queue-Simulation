using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen MainPen = new Pen(Color.Black);
        List<person> persons = new List<person>();
        List<person> queue = new List<person>();
        int sleeptime=1000;
        int systemtime = 0;
        bool Is_serverBusy = false;
        string[] Colors = new string[] {"dark","red","yellow","blue","cyan","magenta" };
        person serverperson=null;
        List<person> result = new List<person>();
        int Count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            TXTDirectory.Text = Environment.CurrentDirectory + "\\data.txt";
            persons = new List<person>();
            queue = new List<person>();
            g = DrawPanel.CreateGraphics();
            g.Clear(Color.White);
            //draw queue
            g.DrawString("Queue",new Font(FontFamily.GenericSansSerif,14f,FontStyle.Bold),MainPen.Brush,new PointF(380,24));
            g.DrawRectangle(MainPen,new Rectangle(200,50,400,100));

            //draw server
            g.DrawString("Server", new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold), MainPen.Brush, new PointF(780, 290));
            g.DrawRectangle(MainPen, new Rectangle(700, 250, 200, 100));
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Run()
        {
            string[] Data = File.ReadAllLines(TXTDirectory.Text);
            Random r=new Random(1234);
            Count = Data.Length;
            for (int i = 0; i < Data.Length; i++)
            {
                person Per = new person();
                string[] content = Data[i].Split(';');
                Per.Arrival = Convert.ToInt32(content[0]);
                Per.ServiceTime = Convert.ToInt32(content[1]);
                Per.ID = i + 1;
                Per.Col = Color.FromName(Colors[r.Next(0, 5)]);
                persons.Add(Per);
            }
            systemtime = 0;
            Is_serverBusy = false;
            serverperson = null;
            result = new List<person>();
            //g = DrawPanel.CreateGraphics();
            timer1.Start();
        }

        

        private void NUDSimulateSpeed_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)NUDSimulateSpeed.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            systemtime++;
            LblTime.Text = "Time : "+systemtime;
            //update system

            if (queue.Count != 0 && !Is_serverBusy)
            {
                person current = queue[0];
                current.BeginService = systemtime;
                current.Delay = current.BeginService - current.Arrival;
                serverperson = current;
                queue.Remove(current);
                Is_serverBusy = true;
            }
            else
            for (int i = 0; i < persons.Count; i++)
            {
                person current = persons[i];
                if (current.Arrival == systemtime)
                {
                    if (!Is_serverBusy)
                    {
                        current.BeginService = systemtime;
                            current.Delay = current.BeginService - current.Arrival;
                            serverperson = current;
                            persons.Remove(current);
                            Is_serverBusy = true;                     
                    }
                    else
                    {
                        queue.Add(current);
                        persons.Remove(current);
                    }
                }
            }

            
            if(serverperson!=null && serverperson.BeginService+serverperson.ServiceTime==systemtime)
            {                
                serverperson.Done=true;
                serverperson.Leave=systemtime;
                serverperson.TotalWait=serverperson.Leave-serverperson.Arrival;
                result.Add(serverperson);
                serverperson=null;
                Is_serverBusy = false;
            }

            g.Clear(Color.White);

            //draw queue
            g.DrawString("Queue", new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold), MainPen.Brush, new PointF(380, 24));
            g.DrawRectangle(MainPen, new Rectangle(200, 50, 400, 100));

            //draw server
            g.DrawString("Server", new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold), MainPen.Brush, new PointF(780, 290));
            g.DrawRectangle(MainPen, new Rectangle(700, 250, 200, 100));

            int X = 0;
            foreach (person perr in queue)
	        {
                g.FillEllipse((new Pen(perr.Col)).Brush,new Rectangle(450-X,75,50,50));
                g.DrawString(perr.ID.ToString(), new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold), (new Pen(Color.Black)).Brush, new PointF(475 - X, 100));
                X += 100;
	        }
            if (Is_serverBusy)
            {
                g.FillEllipse((new Pen(serverperson.Col)).Brush, new Rectangle(680, 300, 50, 50));
                g.DrawString(serverperson.ID.ToString(), new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold), (new Pen(Color.Black)).Brush, new PointF(705,325));
            }

            int simend1 = (from e2 in persons where !e2.Done select e2).ToList<person>().Count;
            int simend2 = (from e2 in queue where !e2.Done select e2).ToList<person>().Count;
            if (simend1 == 0 && simend2 == 0 && serverperson == null)
            {
                timer1.Stop();
                UpdateStatistics();
            }
        }

        float ArrivalRate = 0;
        float Interarrivalrate = 0;
        float ServiceRate = 0;
        float ServiceAvg = 0;
        float delayavg = 0;
        float waitavg = 0;
        float ServiceTime = 0;

        private void UpdateStatistics()
        {
            for (int i = 0; i < Count; i++)
            {
                ArrivalRate += result[i].Arrival;
                Interarrivalrate +=result[i].InterArrival;
                ServiceAvg += result[i].ServiceTime;
                delayavg += result[i].Delay;
                waitavg += result[i].TotalWait;
                ServiceTime +=result[i].ServiceTime;
            }
            ServiceRate = 1 / ServiceAvg;

            LblInterarriavalavg.Text = (Interarrivalrate/Count).ToString();
            LblArrival.Text = ((ArrivalRate/Count)).ToString();
            LblServiceRate.Text = (ServiceRate*100).ToString("0.00");
            LblServiceAvg.Text = (ServiceAvg/Count).ToString();
            LblDelayAvg.Text = (delayavg/Count).ToString();
            LblWaitAvg.Text = (waitavg/Count).ToString();
            LblServerUtilization.Text = (ServiceTime / result[result.Count - 1].Leave).ToString();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFd = new OpenFileDialog();
            if (OFd.ShowDialog() == DialogResult.OK)
            {
                TXTDirectory.Text = OFd.FileName;
            }
        }

        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            Run();
        }
    }
}
