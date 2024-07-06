﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace NavigationView
{
    public class NavigationControl
    {
        private List<UserControl> userControlList;
        private Panel panel;

        public NavigationControl(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            foreach (var userControl in userControlList)
            {
                userControl.Dock = DockStyle.Fill;
                panel.Controls.Add(userControl);
            }
        }

        public void Display(int index)
        {
            if (index >= 0 && index < userControlList.Count)
            {
                userControlList[index].BringToFront();
            }
        }
        
    }
}
