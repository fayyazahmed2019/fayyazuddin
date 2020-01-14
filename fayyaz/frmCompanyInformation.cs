using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingInventory
{
    public partial class frmCompanyInformation : Form
    {
        public frmCompanyInformation()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void con()
        {
            sqlcon conobj = new sqlcon();
            conobj.Connection_Sql();



            cmd2.Connection = sqlcon.con;

        }
        public void conn()
        {
            StreamReader sr = new StreamReader("CnnIQHbtXfsqK7XNEmbwuR6eBVwSVbkIn10tcUWPhc=.dll");
            String line = sr.ReadToEnd();
            SqlConnection con = new SqlConnection(@"Data Source='" + line + "';Initial Catalog=claires;Integrated Security=false;User ID=admin;Password=axisflow;Max Pool Size=50000;");

            con.Open();
            cmd.Connection = con;
        }
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        public void email ()
        {
            
                string from = "technallize@outlook.com";
                string pass = "tech@2019";
                


                MailAddress fromAddress = new MailAddress(from);
                MailMessage mail = new MailMessage(from, txtemail.Text);







                mail.Subject = "Software Registration sucessfully!";
                mail.Body = "Technallize Software Registration Sucessfull!"+Environment.NewLine+"Username :" + txtfname.Text + Environment.NewLine + "Password :" + txtpass.Text+Environment.NewLine+"For Further information feel free to visit our Website : https://technallize.com"+Environment.NewLine+"for software training feel free to watch our Software Training via our website page https://technallize.com/training";

                for (int i = 1; i >= 2; i++)
                {
                    string bcc = null;
                    if (i == 1)
                    {
                        bcc = "usama@technallize.com";
                    }
                    else if (i == 2)
                    {
                        bcc = "fayyaz@technallize.com";
                    }
                    mail.Bcc.Add(bcc);
                }

                SmtpClient client = new SmtpClient();
                client.Host = "outlook.office365.com";
                client.Port = 995;
                client.EnableSsl = true;
                client.Timeout = 99999;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(from, pass);

                
                try
                {
                    client.Send(mail);
                    //MessageBox.Show("Email has been send!", "Technallize", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

            

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkagree.Checked == true)
                {

                    splashScreenManager1.ShowWaitForm();
                    con();
                    cmd2.CommandText = "exec cleandb";
                    cmd2.ExecuteNonQuery();

                    cmd2.CommandText = "delete userlog";
                    cmd2.ExecuteNonQuery();
                    cmd2.CommandText = "delete form_rights";
                    cmd2.ExecuteNonQuery();



                    conn();
                    cmd.CommandText = "insert into soft_registration values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtcname.Text + "','" + txtemail.Text + "','" + txtnumber.Text + "','" + txttype.Text + "','" + txtaddress.Text + "','" + txtpass.Text + "','" + txturl.Text + "','" + doe.Text + "','" + dor.Text + "','" + mac + "','" + chkagree.Text + linkLabel1.Text + "','" + cmbcountry.SelectedItem.ToString() + "','" + cmbcity.SelectedItem.ToString() + "')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "insert into software values('1.00','"+mac+"')";
                    cmd.ExecuteNonQuery();


                    cmd2.CommandText = "insert into storelog values('4133','" + txtcname.Text + "','" + txtaddress.Text + "','" + txtnumber.Text + "','" + txtfname.Text + "','" + txtemail.Text + "')";
                    cmd2.ExecuteNonQuery();

                    cmd2.CommandText = "insert into userlog values('" + txtfname.Text + "','" + txtpass.Text + "','" + dor.Text + "','" + dor.Text + "','" + txtemail.Text + "','" + txtnumber.Text + "','" + txtfname.Text + " " + txtlname.Text + "','" + txtcname.Text + "','Admin')";
                    cmd2.ExecuteNonQuery();

                    cmd2.CommandText = "select distinct form_title from form_title";


                    cmd2.CommandText = "insert into userlog values('staff','staff','" + dor.Text + "','" + dor.Text + "','support@technallize.com','" + txtnumber.Text + "','" + txtfname.Text + " " + txtlname.Text + "','" + txtcname.Text + "','sales advisor')";
                    cmd2.ExecuteNonQuery();


                    cmd.CommandText = "insert into login_activity values('" + mac + "','Offline',1)";
                    cmd.ExecuteNonQuery();


                    cmd2.CommandText = "update form_rights set user_name = '" + txtfname.Text + "' where user_name = 'usama'";
                    cmd2.ExecuteNonQuery();


                    cmd2.CommandText = "select distinct form_title from form_titles";
                    SqlDataReader rd = cmd2.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            con();
                            cmd2.CommandText = "insert into form_rights values('" + rd["form_title"].ToString() + "',1,1,1,1,1,'" + txtfname.Text + "',1,'Admin')";
                            cmd2.ExecuteNonQuery();

                        }

                    }


                    StreamWriter sw1 = new StreamWriter("SXdOkLIy5xToY5pmxEHoKjEMO2+3zZU49gbiqJ0QlM=.dll");

                    sw1.Write(txtcname.Text);
                    sw1.Close();


                    email();
                    splashScreenManager1.CloseWaitForm();

                    MessageBox.Show("You are registered sucessfully with Bizz Dot Pro Software for 30 days trial." + Environment.NewLine + "Congratulation! for becoming a member of Bizz Dot Pro.", "Bizz Dot Pro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Application.Exit();


                    Process.Start("bizzdotpro.exe");

                }
                else
                {
                    splashScreenManager1.CloseWaitForm();
                    MessageBox.Show("Kindly View our Terms and Condition for Next Step.");

                }
            }

            catch (Exception)
            {
                MessageBox.Show("All Fields are Required", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static string mac { get; set; }
        public string GetMACAddress()
        {
            //string macAddresses = "";

            foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    mac += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return mac;
        }
       
        private void frmCompanyInformation_Load(object sender, EventArgs e)
        {
            mac = GetMACAddress().ToString();
            txtfname.Focus();
            dor.Text = DateTime.Now.ToShortDateString();
            doe.Value = dor.Value.AddDays(30);


            conn();

            cmd.CommandText = "select distinct country from tbl_country";
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
               while(rd.Read())
                {
                    cmbcountry.Items.Add(rd[0].ToString());   
                }
            
            }
            



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtfname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlname.Focus();
            }
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcname.Focus();
            }
        }

        private void txtcname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnumber.Focus();
            }
        }

        private void txtnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttype.Focus();
            }
        }

        private void txttype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbcountry.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txturl.Focus();
            }
        }

        private void txturl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkagree.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else 
            {
                txtpass.UseSystemPasswordChar = true;
            }

        }

        private void frmCompanyInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbcountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbcity.Focus();
            }
        }

        private void cmbcity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn();

            cmbcity.Items.Clear();
            cmd.CommandText = "select distinct city from tbl_country where country = '"+cmbcountry.SelectedItem+"'";
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    cmbcity.Items.Add(rd[0].ToString());
                }

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
