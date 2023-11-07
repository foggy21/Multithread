using System.Threading;
using System.IO;

namespace MultithreadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Thread1_Click(object sender, EventArgs e)
        {
            MathParametrs sinParametrs = readValues(n1Text, x1Text, s1Text, d1Text);
            MathParametrs cosParametrs = readValues(t2Text, x2Text, s2Text, d2Text);

            Thread sinThread = new Thread(CalculateSin);
            Thread cosThread = new Thread(CalculateCos);

            sinThread.Start(sinParametrs);
            cosThread.Start(cosParametrs);
        }

        // Общий для всех потоков/таймеров объект
        private static object fileLock = new object();

        private void CalculateSin(object? parametrs)
        {
            if (parametrs is MathParametrs sinParametrs)
            {
                double x = sinParametrs.Value;
                for (int i = 0; i < sinParametrs.Time; i++)
                {
                    double y = Math.Sin(x);

                    // Ставим блокировку
                    lock (fileLock)
                    {
                        using (StreamWriter writer = new StreamWriter("sin.dat", true))
                        {
                            writer.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:fff") + " " + x.ToString() + " " + y.ToString());
                        }
                    }
                    Thread.Sleep(sinParametrs.Delay);
                    x += sinParametrs.Step;
                }                
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private void CalculateCos(object? parametrs) {
            if (parametrs is MathParametrs cosParametrs)
            {
                double x = cosParametrs.Value;
                DateTime startTime = DateTime.Now;

                while((DateTime.Now - startTime).TotalSeconds < cosParametrs.Time)
                {
                    double y = Math.Sin(x);

                    lock(fileLock)
                    {
                        using (StreamWriter writer = new StreamWriter("cos.dat", true))
                        {
                            writer.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:fff") + " " + x.ToString() + " " + y.ToString());
                        }
                    }
                    Thread.Sleep(cosParametrs.Delay);
                    x += cosParametrs.Step;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private MathParametrs readValues(TextBox timeText, TextBox valueText, TextBox stepText, TextBox delayText)
        {
            double time = Convert.ToDouble(timeText.Text);
            double value = Convert.ToDouble(valueText.Text);
            double step = Convert.ToDouble(stepText.Text);
            int delay = Convert.ToInt32(delayText.Text);

            return new MathParametrs(time, value, step, delay);
        }
    }
}
