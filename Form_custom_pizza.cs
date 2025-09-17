using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pizza_desktop_app
{
    public partial class Form_custom_pizza : Form
    {
        public Form_custom_pizza()
        {
            InitializeComponent();
        }


        short price = 0; 

        private void reset_crust()
        {
            radioButton5.Checked = true;
        }
        private void reset_checkboxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox6.Checked = false;
            checkBox5.Checked = false;
            checkBox4.Checked = false;
        }
        private void reset_all()
        {
            reset_crust();
            reset_checkboxes();
        }
        private void print_price()
        {
            label10.Text = $"${price.ToString()}";
        }
        private void update_size()
        {
            reset_all();
            if (radioButton1.Checked)
            {
                price = 10;
                label2.Text = "Small";
                print_price();
                return; 
            }

            if (radioButton2.Checked)
            {
                price = 15;
                label2.Text = "Medium";
                print_price();
                return;
            }

            if (radioButton3.Checked)
            {
                price = 20;
                label2.Text = "Large";
                print_price();
                return; 
            }
        }
        private void update_crust()
        {
            if (radioButton5.Checked)
            {
                label4.Text = "Thin";
                return;
            }

            if (radioButton6.Checked)
            {
                label4.Text = "Plump";
                return; 
            }

            return; 
        }
        private void update_place()
        {

            if (radioButton4.Checked)
            {
                label5.Text = "Eat in";
                return; 
            }

            if (radioButton7.Checked)
            {
                label5.Text = "Take out";
                return;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            update_size();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            update_size();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            update_size();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            update_crust();
            if (label4.Text == "Thin")
            {
                price -= 3;
                print_price();
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            update_crust();
            if(label4.Text == "Plump")
            {
                price += 3;
                print_price();
            }
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            update_place();
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            update_place();
        }



        List<string> Toppings = new List<string>();
        private void add_toppings(string topping)
        {
            Toppings.Add(topping);
            price += 3;
            return;
        }
        private void remove_toppings(string topping)
        {
            Toppings.Remove(topping);
            price -= 3;
            return;
        }
        private void print_toppings()
        {
            label7.Text = "";
            if (Toppings.Count > 0)
            {
                label7.Text = string.Join(", ", Toppings);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) 
            {
                remove_toppings("Extra cheese");
            } else
            {
                add_toppings("Extra cheese");
            }
   
            print_toppings();
            print_price();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == false)
            {
                remove_toppings("Mashrooms");
            } else
            {
                add_toppings("Mashrooms");
            }

            print_toppings();
            print_price();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBox3.Checked)
            {
                remove_toppings("Tomatoes");
            } else
            {
                add_toppings("Tomatoes");
            }

            print_toppings();
            print_price();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked == false)
            {
                remove_toppings("Onion");
            } else
            {
                add_toppings("Onion");
            }
             
            print_toppings();
            print_price();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                remove_toppings("Olives");
            }
            else
            {
                add_toppings("Olives");
            }

            print_toppings();
            print_price();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                remove_toppings("green peppers");
            } else
            {
                add_toppings("green peppers");
            }

            print_toppings();
            print_price();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure you wanna order this.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                gb_size.Enabled = false;
                grp_crust.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false; 
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            gb_size.Enabled = true;
            grp_crust.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

    }
}
