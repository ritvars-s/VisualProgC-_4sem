using _4_seminars.Models;

namespace _4_seminars
{
    public partial class Form1 : Form
    {
        private AppDbContext db = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData.loadCSVData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFuelTypeSource_Click(object sender, EventArgs e)
        {
            srcView.DataSource = db.FuelTypes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srcView.DataSource = db.Locations.ToList();
        }

        private void btnCarMakeSource_Click(object sender, EventArgs e)
        {
            srcView.DataSource = db.CarMakes.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            srcView.DataSource = db.Cars.ToList();
        }
    }
}
