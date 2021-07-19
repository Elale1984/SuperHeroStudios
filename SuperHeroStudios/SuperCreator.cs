using System;
using System.Collections.Generic;

using System.Windows.Forms;

/*
 * Name: Edward Lale
 * Course: CST-250
 * Statement of own work: I herby state that the code in this assignment is my own work and creativity.
 * 
 * 
 * This is the SuperCreator form class that controls taking the information of the form, 
 * creating a super charecter with the information, and then adding it to the SuperIndexList.
 * Also, there are some value change methods which do some logic to dynamically move the 
 * hScrolls to prevent the user from overloading the levels which are intended to add up
 * to 100. The Color selectors are also coded here updating the pictureboxes for their 
 * respected colors.
 */
namespace SuperHeroStudios
{
    public partial class SuperCreator : Form
    {
        
        public SuperCreator()
        {
            InitializeComponent();

        }

        private void pb_SuitColor_Click(object sender, EventArgs e)
        {
            DialogResult suitColorResult = colorDialog1.ShowDialog();

            if (suitColorResult == DialogResult.OK)
            {
                pb_SuitColor.BackColor = colorDialog1.Color;
                String suitColor = colorDialog1.Color.Name;
                MessageBox.Show(suitColor);
            }
        }

        private void pb_AccentColor_Click(object sender, EventArgs e)
        {
            DialogResult accentColorResult = colorDialog1.ShowDialog();

            if (accentColorResult == DialogResult.OK)
            {
                pb_AccentColor.BackColor = colorDialog1.Color;
                String accentColor = colorDialog1.Color.Name;
                MessageBox.Show(accentColor);
            }
        }

      
        //The following three ValueChanged methods will update the respective lable of the HScrollBars when they are moved to the 
        //represented integer values.
        private void hsb_Power_ValueChanged(object sender, ScrollEventArgs e)
        {
            int power = hsb_Power.Value;
            int speed = hsb_Speed.Value;
            int agility = hsb_Agility.Value;
            int total = speed + agility + power;

            if (power + speed + agility >= 100)
            {
                hsb_Agility.Value =  (100 - power) / 2;

                hsb_Speed.Value = (100 - power) / 2;
            }
           
            lbl_Power.Text = hsb_Power.Value.ToString();
            lbl_Speed.Text = hsb_Speed.Value.ToString();
            lbl_Agility.Text = hsb_Agility.Value.ToString();
            lbl_LevelTotal.Text = total.ToString();

        }

        private void hsb_Speed_ValueChanged(object sender, ScrollEventArgs e)
        {
            int power = hsb_Power.Value;
            int speed = hsb_Speed.Value;
            int agility = hsb_Agility.Value;
            int total = speed + agility + power;

            if (power + speed + agility >= 100)
            {
                hsb_Power.Value = (100 - speed) / 2;

                hsb_Agility.Value = (100 - speed) / 2;
               
            }
            
            lbl_Power.Text = hsb_Power.Value.ToString();
            lbl_Speed.Text = hsb_Speed.Value.ToString();
            lbl_Agility.Text = hsb_Agility.Value.ToString();
            lbl_LevelTotal.Text = total.ToString();
        }

        private void hsb_Agility_ValueChanged(object sender, ScrollEventArgs e)
        {
            int power = hsb_Power.Value;
            int speed = hsb_Speed.Value;
            int agility = hsb_Agility.Value;
            int total = speed + agility + power;

            if (power + speed + agility >= 100)
            {
                hsb_Power.Value = (100 - agility) / 2;

                hsb_Speed.Value = (100 - agility) / 2;
               
            }
           
            lbl_Power.Text = hsb_Power.Value.ToString();
            lbl_Speed.Text = hsb_Speed.Value.ToString();
            lbl_Agility.Text = hsb_Agility.Value.ToString();
            lbl_LevelTotal.Text = total.ToString();
        }


        // the lbl_PowerRank text will be set to the tkb_PowerRank value when bar is moved.
        private void tkb_PowerRank_ValueChanged(object sender, EventArgs e)
        {
            lbl_PowerRank.Text = tkb_PowerRank.Value.ToString();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            String superAlias = tb_Alias.Text;
            String secretIdent = tb_SecretIdentity.Text;
            String archEnemy = tb_ArchEnemy.Text;
            String type = getSuperType();
            String humanBDay = dtp_HBDay.Value.ToString("d");
            String superBDay = dtp_SBDay.Value.ToString("d"); ;
            String city = lb_City.SelectedItem.ToString();
            List<String> abilities = getAbilities();
            List<String> weaknesses = getWeaknesses();
            String primaryWeapon = getPrimaryWeapon();
            String secondaryWeapon1 = cb_Secondary1.SelectedItem.ToString();
            String secWeap1Amt = nub_Sec1Amount.Value.ToString();
            String secondaryWeapon2 = cb_Secondary2.SelectedItem.ToString();
            String secWeap2Amt = nub_Sec2Amount.Value.ToString();
            String suitColor = pb_SuitColor.BackColor.Name;
            String accentColor = pb_AccentColor.BackColor.Name;
            String powerRank = tkb_PowerRank.Value.ToString();
            int power = hsb_Power.Value;
            int speed = hsb_Speed.Value;
            int stamina = hsb_Agility.Value;


            SuperCharecter charecter = new SuperCharecter(superAlias, secretIdent, archEnemy, type, humanBDay, superBDay, city,
                abilities, weaknesses, primaryWeapon, secondaryWeapon1, secWeap1Amt, secondaryWeapon2, secWeap2Amt, suitColor,
                accentColor, powerRank, power, speed, stamina);

            //MessageBox.Show(charecter.ToString());

            SuperIndexList.giftedIndex.Add(charecter);
            
            // Dialog Message box that allows the user to choose to add another hero/villan or to contine to the index
            string message = "Do you want to see the whole index of Powered People?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                SuperIndex superIndexForm = new SuperIndex();
                superIndexForm.Show();
            }
            else
            {
                MessageBox.Show("Your Charecter has been added to the list. Add another Charecter");
                SuperCreator creator = new SuperCreator();
                creator.Show();
                this.Dispose(false);

            }
        }

       

        //Gets the selected radio button for primary weapon and returns its text value
        private string getPrimaryWeapon()
        {
            String pw = "";
            foreach (RadioButton rb in gb_PrimaryWeapon.Controls)
            {
                if (rb.Checked)
                {
                    pw = rb.Text;
                }
            }
            return pw;
        }

        //Gets the selected radio button for type and returns its text value
        private string getSuperType()
        {
            if (rb_Hero.Checked)
                return rb_Hero.Text;
            else
                return rb_Villain.Text;
        }

        //Gets the selected checkboxes for weaknesses and returns a list of their text values
        private List<String> getWeaknesses()
        {
            List<String> weaknesses = new List<string>();

            foreach (CheckBox cb in gb_Weaknesses.Controls)
            {
                if (cb.Checked)
                {
                    weaknesses.Add(cb.Text);
                }
            }
            return weaknesses;
        }

        //Gets the selected checkboxes for abilities and returns a list of their text values
        private List<String> getAbilities()
        {
            List<String> abilities = new List<string>();

            foreach (CheckBox cb in gb_Abilities.Controls)
            {
                if (cb.Checked)
                {
                    abilities.Add(cb.Text);
                }
            }

            return abilities;
        }

       
    }
}
