using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var user = new User();        
            user.Name = textName.Text;
            user.SurName = textSurname.Text;
            user.FatherName = textFather.Text;
            user.Country = textCountry.Text;
            user.City = textCity.Text;
            user.Phone = textPhone.Text;
            user.Birthday = dateTimePicker1.Text;
            if (radioButton1.Checked)
                user.Gender = radioButton1.Text;
            else
                user.Gender = radioButton2.Text;

            var str = JsonConvert.SerializeObject(user, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText($"{user.Name}.json", str);
           


            textName.Text = null;
            textSurname.Text = null;
            textFather.Text = null;
            textCountry.Text = null;
            textCity.Text = null;
            textPhone.Text = null;
            dateTimePicker1.Text = null;
            if (radioButton1.Checked)
                radioButton1.Checked = false;
            else
                radioButton2.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = null;
            var a = File.Exists($"{textBox1.Text}.json");
            if (a)
            {
                var jsonStr = File.ReadAllText($"{textBox1.Text}.json");
                user = JsonConvert.DeserializeObject<User>(jsonStr);
                MessageBox.Show(user.ToString());

            }
            else
            {
                MessageBox.Show("There is no user with this name");
            }
            textBox1.Text = null;

            
        }

       
    }
}