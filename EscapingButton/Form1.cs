namespace EscapingButton
{
    public partial class Form1 : Form
    {
        private Button button1;
        public Form1()
        {
            InitializeComponent();

            this.Text = "Убегающая кнопка";
            button1 = new Button();
            button1.Text = "Нажми меня!";
            button1.Width = 100;
            button1.Height = 100;
            button1.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            button1.MouseHover += (sender, e) => MoveButtonRandomly();
            Controls.Add(button1);
        }
        private void MoveButtonRandomly()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, ClientSize.Width - button1.Width);
            int y = rnd.Next(0, ClientSize.Height - button1.Height);
            button1.Location = new Point(x, y);
            button1.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
    }
}