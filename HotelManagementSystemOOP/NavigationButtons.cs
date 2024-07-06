using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace NavigationView
{
    public class NavigationButtons
    {
        private List<Button> buttons;

        public NavigationButtons(List<Button> buttons)
        {
            this.buttons = buttons;
        }

        public void Highlight(Button selectedButton)
        {
            foreach (var button in buttons)
            {
                if (button == selectedButton)
                {
                    // Highlight logic (change background color to black)
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White; // Optionally change the text color to white for better contrast
                }
                
            }
        }
   
    }
}
