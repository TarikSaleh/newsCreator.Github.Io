using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using Timer = System.Timers.Timer;
using System.Windows.Forms;

namespace newsCreator
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        

        public Form1()
        {
            InitializeComponent();
            //Start Timer

            Timer startTimer = new Timer(1000);
        startTimer.AutoReset = true;
        startTimer.Elapsed += new System.Timers.ElapsedEventHandler(startClicked_Click);
        startTimer.Start();
        }

        private void selectPath_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                textPath.Text = openFileDialog1.FileName;
            }
        }

        private void startClicked_Click(object sender, EventArgs e)
        {
            

            //Connect to DataBase

            string conString = "Server=localhost;port=3306;Database=elSharqNews;Uid=root;Pwd='';SslMode=none";
            
            try
            {
                conn = new MySqlConnection(conString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM news ORDER BY Position ";
                conn.Open();

                label3.Text = "Database Connected";
                
                string file = textPath.Text;

                if (File.Exists(file))
                {
                    // Use a try block to catch IOExceptions, to 
                    // handle the case of the file already being 
                    // opened by another process. 
                    try
                    {
                        File.Delete(file);
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);

                        return;
                    }
                }

            StreamWriter myWriter = new StreamWriter(file, true, Encoding.Unicode);

            MySqlDataReader reader = command.ExecuteReader();
                    
                while (reader.Read())

                {
                    myWriter.Write(reader["News"].ToString() + Environment.NewLine);
                }

                reader.Close();

                myWriter.Close();

                conn.Close();
            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

            
        }

        private void stopClicked_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

            myTimer.Stop();

            Application.Exit();
        }
    }
}
