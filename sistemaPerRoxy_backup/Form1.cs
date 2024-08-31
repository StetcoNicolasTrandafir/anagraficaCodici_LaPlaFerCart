using System.Text.Json;

namespace sistemaPerRoxy
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Record> records;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = -1;
            string jsonString = null;
            try
            {
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "codes.json");

                //jsonString = File.ReadAllText(@"C:\\Users\\39388\\Desktop\\sistemaPerRoxy\\codes.json");
                jsonString = File.ReadAllText(jsonFilePath);

                //lblError.Text = jsonFilePath;

            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "File non trovato";
            }
            records = JsonSerializer.Deserialize<Dictionary<string, Record>>(jsonString);
            string[] keysArray = records.Keys.ToArray();
            comboBox1.DataSource = keysArray;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKey = comboBox1.SelectedItem?.ToString();

            if (selectedKey != null && records.TryGetValue(selectedKey, out Record record))
            {
                txtCode.Text = selectedKey;
                lblRis.Text = record.ToString();
                lblError.Text = string.Empty;
            }
            else
            {
                lblRis.Text = string.Empty;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            records.TryGetValue(code, out Record record);
            if (record != null)
                comboBox1.SelectedItem = txtCode.Text;
            else
            {
                lblError.Text = "Codice non trovato: controllare errori di battitura";
                comboBox1.SelectedIndex = -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            txtCode.Text = string.Empty;
            lblError.Text = string.Empty;
        }
    }
}
