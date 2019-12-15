using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    public partial class UCCatalog : UserControl
    {
        public delegate void SelectionUser(string UID);
        public event SelectionUser OnSelectionUser;
        public UCCatalog(List<KeyValuePair<string, string>> _people)
        {
            InitializeComponent();
            LoadDisplay_Catalog(_people);
        }

        private void LoadDisplay_Catalog(List<KeyValuePair<string, string>> _people)
        {
        //    UCSearchBar uCSearchBar = new UCSearchBar(_people);
        //    uCSearchBar.OnSelectionUser += (i) => OnSelectionUser(i);
        //    pnlSearch.Controls.Add(uCSearchBar);



        }
    }
}
