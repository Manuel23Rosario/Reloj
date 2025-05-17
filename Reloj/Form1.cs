namespace Reloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_HoraLocal.Text = DateTime.Now.ToString("HH:mm");
            lbl_SegundosLocal.Text = DateTime.Now.ToString("ss");
            lbl_FechaLocal.Text = DateTime.Now.ToString("MMM dd yyyy");
            lbl_DayLocal.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var idLugar = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
            var date = TimeZoneInfo.ConvertTime(DateTime.Now, idLugar);

            lbl_HoraNY.Text = date.ToString("HH:mm");
            lbl_SegundosNY.Text = date.ToString("ss");
            lbl_FechaNY.Text = date.ToString("MMM dd yyyy");
            lbl_DiaNY.Text = date.ToString("dddd");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var idLugar = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            var date = TimeZoneInfo.ConvertTime(DateTime.Now, idLugar);

            lbl_HoraBN.Text = date.ToString("HH:mm");
            lbl_SecondsBN.Text = date.ToString("ss");
            lbl_FechaBN.Text = date.ToString("MMM dd yyyy");
            lbl_DiaBN.Text = date.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var idLugar = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            var date = TimeZoneInfo.ConvertTime(DateTime.Now, idLugar);

            lbl_HoraTO.Text = date.ToString("HH:mm");
            lbl_SecondsTO.Text = date.ToString("ss");
            lbl_FechaTO.Text = date.ToString("MMM dd yyyy");
            lbl_DiaTO.Text = date.ToString("dddd");
        }
    }
}
