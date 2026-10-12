using InvoiceDbSeeding.Model;

namespace InvoiceDbSeeding
{
    public partial class Form1 : Form
    {
        AppDbContext db = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
