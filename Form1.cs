using AirplaneApp;

namespace OOP_lab_3_task_1
{
    public partial class Form1 : Form
    {
        private Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtOutput.AppendText("\t\t Пасажирський літак (сортування за вартістю)\r\n");

            Child1[] planes = new Child1[3];
            for (int i = 0; i < planes.Length; i++)
            {
                planes[i] = new Child1(rand.Next(200, 600), rand.Next(8, 15));
                planes[i].Metod();
            }
            txtOutput.AppendText("До сортування: \r\n");
            foreach (var p in planes)
            {
                txtOutput.AppendText(p.Info() + "\r\n");
            }
            Array.Sort(planes);

            txtOutput.AppendText("\r\nСортування за вартістю: \r\n");
            foreach (var p in planes)
            {
                txtOutput.AppendText(p.Info() + "\r\n");
            }
        }

        private void btnFighter_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtOutput.AppendText("\t\t Винищувач (сортування за швидкістю) \r\n");

            Child2[] fighters = new Child2[3];
            for (int i = 0; i < fighters.Length; i++)
            {
                fighters[i] = new Child2(rand.Next(1500, 2200), rand.Next(10, 18));
                fighters[i].Metod();
            }
            txtOutput.AppendText("До сортування: \r\n");
            foreach (var f in fighters)
            {
                txtOutput.AppendText(f.Info() + "\r\n");
            }
            Array.Sort(fighters);
            txtOutput.AppendText("\r\nСортування за швидкістю: \r\n");
            foreach (var f in fighters)
            {
                txtOutput.AppendText(f.Info() + "\r\n");
            }
        }

        private void btnBomber_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtOutput.AppendText("\t\t Бомбардувальник \r\n");

            Child3[] bombers = new Child3[3];
            for (int i = 0; i < bombers.Length; i++)
            {
                bombers[i] = new Child3(rand.Next(1400, 1800), rand.Next(10, 15), rand.Next(4, 8));
                bombers[i].Metod();
            }

            foreach (var b in bombers)
            {
                txtOutput.AppendText(b.Info() + "\r\n");
            }
        }

        private void btnMainLoop_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtOutput.AppendText("\t\t Основний цикл (5 ітерацій) \r\n");
            for (int i = 0; i < 5; i++)
            {
                double speed = rand.Next(300, 2200);
                double height = rand.Next(8, 16);
                int planeType = rand.Next(1, 4);

                IParent plane = null;
                if (planeType == 1)
                {
                    plane = new Child1(speed, height);
                }
                else if (planeType == 2)
                {
                    plane = new Child2(speed, height);
                }
                else
                {
                    double bombs = rand.Next(3, 8);
                    plane = new Child3(speed, height, bombs);
                }
                plane.Metod();
                txtOutput.AppendText(plane.Info() + "\r\n");
            }
        }
    }
}
