using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace fLogin
{
    public partial class UCSearchBar : UserControl
    {
        private List<KeyValuePair<string,string>> people;
        public delegate void SelectionUser(string UID);
        public event SelectionUser OnSelectionUser;

        public UCSearchBar(List<KeyValuePair<string, string>> _people)
        {
            InitializeComponent();
            people = _people;
            //
            //Event TextChanged
            lsvSearchView.Visible = false;
            txbSearch.TextChanged += TxbSearch_TextChanged;

            txbSearch.GotFocus += TxbSearch_GotFocus;
            txbSearch.LostFocus += TxbSearch_LostFocus;

            lsvSearchView.MouseDoubleClick += LsvSearchView_MouseDoubleClick;
            lsvSearchView.KeyDown += LsvSearchView_KeyDown;
        }

        private void TxbSearch_LostFocus(object sender, EventArgs e)
        {
            //if (lsvSearchView.Focus() != false)
            //    lsvSearchView.Visible = false;
        }

        private void TxbSearch_GotFocus(object sender, EventArgs e)
        {
            lsvSearchView.Visible = true;
        }

        private void LsvSearchView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                OnSelectionUser(people.Where(x => lsvSearchView.SelectedItem.ToString() == x.Value).SingleOrDefault().Key);
        }

        private void LsvSearchView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OnSelectionUser(people.Where(x => lsvSearchView.SelectedItem.ToString() == x.Value).SingleOrDefault().Key);
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            lsvSearchView.Items.Clear();
            if (txbSearch.Text != "")
            {
                var temp = people.Where(x => new Regex(string.Format(@"^({0})(\w+|)", txbSearch.Text), RegexOptions.IgnoreCase).IsMatch(x.Value)).ToList();
                foreach (var str in temp)
                {
                    lsvSearchView.Items.Add(str.Value);
                }
            }
        }

    }
}
