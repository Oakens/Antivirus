using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
// heeh
namespace Antivirus
{
    public partial class AntiVirus : Form
    {

        public AntiVirus()
        {
            InitializeComponent();
        }

        public string md5_hash(string file_name)
        {
            return hash_generator("md52", file_name); 
        }

        private string hash_generator(string hash_type, string fileName) // Hash generator er modtager hashen man putter i antivirussen
        {

            var hash = MD5.Create(); // variable som Initialiserere md5 objectet

            byte[] hashValues; // variable bliver til bytearray, så man får md5 hashes af bytes, den tager ikke en md5 hash af navnet, men hvad der er i filen
           
            FileStream filestream = File.OpenRead(fileName);
            filestream.Position = 0;
            hashValues = hash.ComputeHash(filestream); //der hvor filestream vil streame, der vil den udregne hashen af filen
            var hash_hex = PrintByteArray(hashValues); // converterere bytes til hexadin, så det nemmere at læse

            filestream.Close();
            return hash_hex;
        }

        //public string PrintByteArray(byte[] array)
        //{
        //    string hex_value = "";

        //    int i = 0;

        //    for (i = 0; i <= array.Length - 1; i++)
        //    {
        //        hex_value += array(i).Tostring("x2");
        //    }

        //    return hex_value.ToLower();
        //}

        public static string PrintByteArray(byte[] by) // konvertere bytes til hex
        {
            string hex_value = BitConverter.ToString(by);
            return hex_value;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblNameTitle_Click(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var path = openFileDialog1.FileName;

                textFile.Text = path;
                string sample;
                sample = md5_hash(path); // sample er filen, så filen bliver til md5 hash
                txtHash.Text = md5_hash(path);

                using (System.IO.FileStream f = System.IO.File.OpenRead("md5.txt")) // er min dictionary
                {
                    using (System.IO.StreamReader s = new System.IO.StreamReader(f)) // f er fil med md5
                    {
                        while (!s.EndOfStream)
                        {
                            string line = s.ReadLine();

                            if ((line == sample)) // hvis md5 passer til dictionary
                            {
                                lblResult.Text = "Infected!";
                                lblResult.ForeColor = Color.Red;
                            }
                            else
                            {
                                lblResult.Text = "Clean!";
                                lblResult.ForeColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtHash.Text);
                
            }
        }

        private void DelteBtn_Click(object sender, EventArgs e)
        {
            File.Delete(textFile.Text);


        }
    }
}
