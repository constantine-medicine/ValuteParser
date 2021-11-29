using ValuteLibrary;

namespace ValuteUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var infos = Controller.GetValuteFromUrl("");
            txtBoxResult.Text += $"Резульат на {infos.Date.ToString("dd.MM.yyyy")}.\n";
            var currents = infos.Valute.GetAllValuteInformation();
            var current = Controller.PrintInfo(button.Text, currents);
            foreach (var item in current)
            {
                txtBoxResult.Text += $"{item.Key}: {item.Value}\n";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = string.Empty;
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            var button = sender as Button;
            var infos = Controller.GetValuteFromUrl("");
            var currents = infos.Valute.GetAllValuteInformation();
            var current = Controller.PrintInfo(button.Text, currents);
            string text = string.Empty;
            foreach (var item in current)
            {
                if (item.Key == "Название валюты")
                {
                    text = item.Value;
                    break;
                }
            }
            txtBoxFullName.Location = new Point(button.Location.X - txtBoxFullName.Size.Width, button.Location.Y);
            txtBoxFullName.Visible = true;
            txtBoxFullName.Text = text;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            txtBoxFullName.Visible = false;
        }
    }
}