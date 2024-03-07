using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveButton
{
    internal class LoveButton : Label
    {
        int num = 1;
        public LoveButton()
        {
            MouseClick += LoveButton_MouseClick;
            BackColor = Color.Red;
            AutoSize = true;
        }

        private void LoveButton_MouseClick(object? sender, MouseEventArgs e)
        {
            num++;
            if (num == 4) num = 1;
            Text = "";
            for (int i = 0; i < num; i++)
            {
                Text += "\u2764";
            }   
        }
    }
}
