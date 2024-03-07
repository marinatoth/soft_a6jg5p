namespace LoveButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    LoveButton loveButton = new LoveButton();
                    loveButton.Top = i *(loveButton.Height + 1);
                    loveButton.Left = j * (loveButton.Width + 1);
                    Controls.Add(loveButton);

                    
                }
            }
        }
    }
}