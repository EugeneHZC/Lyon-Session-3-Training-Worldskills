using System.Drawing.Text;

namespace LyonSession3WinForm
{
    public partial class Form1 : Form
    {
        private static PrivateFontCollection font = new PrivateFontCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            font.AddFontFile("Montserrat-SemiBold.ttf");
            font.AddFontFile("OpenSans-Regular.ttf");

            LoadControl(this);

            panel1.BackColor = ColorTranslator.FromHtml("#D4A017");
            this.BackColor = ColorTranslator.FromHtml("#FFFAF0");

            label1.Font = new Font(font.Families[0], 12);
            label1.Text = this.Text;
        }

        private void LoadControl(Control control)
        {
            foreach (Control c in control.Controls)
            {
                LoadControl(c);
            }

            control.Font = new Font(font.Families[1], 9);

            if (control is Button button)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = ColorTranslator.FromHtml("#A4C2D6");
            }
            else if (control is NumericUpDown numericUpDown)
            {
                numericUpDown.DecimalPlaces = 2;
                numericUpDown.Maximum = 100000000000;
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = "dd/MM/yyyy";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
