using System.Xml.Linq;
using System.Data.SqlClient;
using System.Drawing;
namespace Connect_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        
        private void button1_Click(object sender, EventArgs e)
        { string connString = "Data Source=DESKTOP-P30AQDG;Initial Catalog=amndb;Integrated Security=True;Trust Server Certificate=True";

            string name = textBox1.Text;
            string message = textBox2.Text;


            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();


                    string query = "INSERT INTO product (name, message) VALUES (@Name, @Message)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Message", message);

                        cmd.ExecuteNonQuery();
                    }
                        MessageBox.Show("Data Saved");
                    }                    catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

    }   }
                

        