using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Newtonsoft.Json;


namespace AnketWINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(@"pocosound.wav");
            player.Play();
        }

        private void savefileBTN_Click(object sender, EventArgs e)
        {
            string ad = nameTXTBOX.Text;
            string soyad = surnameTXTBOX.Text;
            int yas = Convert.ToInt32(ageTXTBOX.Text);
            string cins = genderTXTBOX.Text;

            Anket anket = new Anket
            {
                Ad = ad,
                Soyad = soyad,
                Yas = yas,
                Cins = cins
            };

            string jsonAnket = JsonConvert.SerializeObject(anket);

            // Faylı yarat və json məlumatını yaz
            string faylAdi = $"{ad}.json";
            File.WriteAllText(faylAdi, jsonAnket);

            MessageBox.Show("Anket ugurla save olundu!");
        }

        private void loadfileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json Faylları|*.json";
            openFileDialog.Title = "Anket Faylını Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonAnket = File.ReadAllText(openFileDialog.FileName);

                Anket anket = JsonConvert.DeserializeObject<Anket>(jsonAnket);

                nameTXTBOX.Text = anket.Ad;
                surnameTXTBOX.Text = anket.Soyad;
                ageTXTBOX.Text = anket.Yas.ToString();
                genderTXTBOX.Text = anket.Cins;

                Label welcomeLBL = new Label();
                welcomeLBL.AutoSize = true;
                welcomeLBL.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                welcomeLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                welcomeLBL.Location = new System.Drawing.Point(145, 142);
                welcomeLBL.Name = "welcomeLBL";
                welcomeLBL.Size = new System.Drawing.Size(186, 32);
                welcomeLBL.TabIndex = 11;
                welcomeLBL.Text = $"Xoş gəldiniz, {anket.Ad}";
                this.Controls.Add(welcomeLBL);
            }
        }
    }
}
