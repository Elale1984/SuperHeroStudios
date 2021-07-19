using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * This is the Super Index form. This form contains a listbox and a multilined text box. The listbox displays the added name 
 * of the Super Charecter that is created. The text box contains the details attributed to that Super Charecter
 */
namespace SuperHeroStudios 
{
    public partial class SuperIndex : Form
    {
        public SuperIndex( )
        {
            InitializeComponent();
            
            // Using the Bidning source with data source to populate the listbox with the list of super charecters
            BindingSource binder = new BindingSource();
            binder.DataSource = SuperIndexList.giftedIndex;
            lb_PoweredIndex.DataSource = binder;
            
            // this should display the alies of the super charecter in the list box but for some reason it does not function 
            // corectly and instead calls the overriden toString method and attempts to populate with all the information
            lb_PoweredIndex.DisplayMember = "alias";
            
               
        }

        private void lb_PoweredIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            // populates the text box with a customized ToString method
            tb_IndexSelectedDetails.Text = lb_PoweredIndex.SelectedItem.ToString();

        }
    }
}
