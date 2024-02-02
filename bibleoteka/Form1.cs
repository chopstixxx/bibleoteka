using dates_lib;
namespace bibleoteka
{
    public partial class Form1 : Form
    {
        Date_class date_class = new Date_class();
        public Form1()
        {
            InitializeComponent();
            dateTimePicker3.Format = DateTimePickerFormat.Time;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;

            TimeSpan diff = date_class.Get_date_diff(dt1, dt2);


            MessageBox.Show($"Разница: {diff.Days} дней {diff.Hours} часов");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(date_class.get_time(dateTimePicker3.Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (date_class.IsLeapYear(Convert.ToInt32(textBox1.Text)))
            {
                MessageBox.Show("Високосный!");
            }
            else
            {
                MessageBox.Show("Не високосный!");

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(radioButton1.Checked)
            {
                MessageBox.Show(date_class.date_format(now, "D"));

            }
            if (radioButton2.Checked)
            {
                MessageBox.Show(date_class.date_format(now, "d"));

            }
            if (radioButton3.Checked)
            {
                MessageBox.Show(date_class.date_format(now, "F"));

            }
            if (radioButton4.Checked)
            {
                MessageBox.Show(date_class.date_format(now, "g"));

            }
        }
    }
}