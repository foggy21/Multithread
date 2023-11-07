namespace MultithreadApp
{
    public class MathParametrs
    {
        public double Time { get => time; }
        public double Value { get => value; }
        public double Step { get => step; }
        public int Delay { get => delay; }

        private double time;
        private double value;
        private double step;
        private int delay;

        public MathParametrs(double time, double value, double step, int delay)
        {
            this.time = time;
            this.value = value;
            this.step = step;
            this.delay = delay;
        }
    }
}
