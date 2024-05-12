using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mythic_Keystone_Instance_Time_Comparator
{
    public partial class Form1 : Form
    {
        public int Minut1 { get; private set; }
        public int Secon1 { get; private set; }
        public int Minut2 { get; private set; }
        public int Secon2 { get; private set; }
        public int Total1 { get; private set; }
        public int Total2 { get; private set; }
        public int MaxTime1 { get; private set; }
        public int MaxTime2 { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Instances = new List<Instance>
            {
                new Instance() { InstanceID = 0, Name = "De Other Side", Intime = 2340, Plus2Time = 1872, Plus3Time = 1404 },
                new Instance() { InstanceID = 1, Name = "Halls of Atonment", Intime = 1860, Plus2Time = 1488, Plus3Time = 1116 },
                new Instance() { InstanceID = 2, Name = "Mists of Tirna Scithe", Intime = 1800, Plus2Time = 1440, Plus3Time = 1080 },
                new Instance() { InstanceID = 3, Name = "Necrotic Wake", Intime = 2160, Plus2Time = 1728, Plus3Time = 1296 },
                new Instance() { InstanceID = 4, Name = "Sanguine Dephts", Intime = 2460, Plus2Time = 1968, Plus3Time = 1476 },
                new Instance() { InstanceID = 5, Name = "Spires of Ascension", Intime = 2340, Plus2Time = 1872, Plus3Time = 1404 },
                new Instance() { InstanceID = 6, Name = "Theatre of Pain", Intime = 2220, Plus2Time = 1716, Plus3Time = 1332 },
                new Instance() { InstanceID = 7, Name = "Plaguefall", Intime = 2280, Plus2Time = 1824, Plus3Time = 1358 }
            };
            //Bind data to combobox
            ComboBoxInst1.DataSource = Instances;
            ComboBoxInst1.DisplayMember = "Name";
            ComboBoxInst1.ValueMember = "InstanceID";
            var Instances2 = new List<Instance2>
            {
                new Instance2() { InstanceID2 = 0, Name2 = "De Other Side", Intime2 = 2340, Plus2Time2 = 1872, Plus3Time2 = 1404 },
                new Instance2() { InstanceID2 = 1, Name2 = "Halls of Atonment", Intime2 = 1860, Plus2Time2 = 1488, Plus3Time2 = 1116 },
                new Instance2() { InstanceID2 = 2, Name2 = "Mists of Tirna Scithe", Intime2 = 1800, Plus2Time2 = 1440, Plus3Time2 = 1080 },
                new Instance2() { InstanceID2 = 3, Name2 = "Necrotic Wake", Intime2 = 2160, Plus2Time2 = 1728, Plus3Time2 = 1296 },
                new Instance2() { InstanceID2 = 4, Name2 = "Sanguine Dephts", Intime2 = 2460, Plus2Time2 = 1968, Plus3Time2 = 1476 },
                new Instance2() { InstanceID2 = 5, Name2 = "Spires of Ascension", Intime2 = 2340, Plus2Time2 = 1872, Plus3Time2 = 1404 },
                new Instance2() { InstanceID2 = 6, Name2 = "Theatre of Pain", Intime2 = 2220, Plus2Time2 = 1716, Plus3Time2 = 1332 },
                new Instance2() { InstanceID2 = 7, Name2 = "Plaguefall", Intime2 = 2280, Plus2Time2 = 1824, Plus3Time2 = 1358 }
            };
            ComboBoxInst2.DataSource = Instances2;
            ComboBoxInst2.DisplayMember = "Name2";
            ComboBoxInst2.ValueMember = "InstanceID2";
            var MM1 = new List<Minutes1>
            {
                new Minutes1() {MM1Id = 0, Val1 = 0 },
                new Minutes1() {MM1Id = 1, Val1 = 1 },
                new Minutes1() {MM1Id = 2, Val1 = 2 },
                new Minutes1() {MM1Id = 3, Val1 = 3 },
                new Minutes1() {MM1Id = 4, Val1 = 4 },
                new Minutes1() {MM1Id = 5, Val1 = 5 },
                new Minutes1() {MM1Id = 6, Val1 = 6 },
                new Minutes1() {MM1Id = 7, Val1 = 7 },
                new Minutes1() {MM1Id = 8, Val1 = 8 },
                new Minutes1() {MM1Id = 9, Val1 = 9 },
                new Minutes1() {MM1Id = 10, Val1 = 10 },
                new Minutes1() {MM1Id = 11, Val1 = 11 },
                new Minutes1() {MM1Id = 12, Val1 = 12 },
                new Minutes1() {MM1Id = 13, Val1 = 13 },
                new Minutes1() {MM1Id = 14, Val1 = 14 },
                new Minutes1() {MM1Id = 15, Val1 = 15 },
                new Minutes1() {MM1Id = 16, Val1 = 16 },
                new Minutes1() {MM1Id = 17, Val1 = 17 },
                new Minutes1() {MM1Id = 18, Val1 = 18 },
                new Minutes1() {MM1Id = 19, Val1 = 19 },
                new Minutes1() {MM1Id = 20, Val1 = 20 },
                new Minutes1() {MM1Id = 21, Val1 = 21 },
                new Minutes1() {MM1Id = 22, Val1 = 22 },
                new Minutes1() {MM1Id = 23, Val1 = 23 },
                new Minutes1() {MM1Id = 24, Val1 = 24 },
                new Minutes1() {MM1Id = 25, Val1 = 25 },
                new Minutes1() {MM1Id = 26, Val1 = 26 },
                new Minutes1() {MM1Id = 27, Val1 = 27 },
                new Minutes1() {MM1Id = 28, Val1 = 28 },
                new Minutes1() {MM1Id = 29, Val1 = 29 },
                new Minutes1() {MM1Id = 30, Val1 = 30 },
                new Minutes1() {MM1Id = 31, Val1 = 31 },
                new Minutes1() {MM1Id = 32, Val1 = 32 },
                new Minutes1() {MM1Id = 33, Val1 = 33 },
                new Minutes1() {MM1Id = 34, Val1 = 34 },
                new Minutes1() {MM1Id = 35, Val1 = 35 },
                new Minutes1() {MM1Id = 36, Val1 = 36 },
                new Minutes1() {MM1Id = 37, Val1 = 37 },
                new Minutes1() {MM1Id = 38, Val1 = 38 },
                new Minutes1() {MM1Id = 39, Val1 = 39 },

            };
            ComboMM1.DataSource = MM1;
            ComboMM1.DisplayMember = "MMId";
            ComboMM1.ValueMember = "Val1";
            var MM2 = new List<Minutes2>
            {
                new Minutes2() {MM2Id = 0, Val2 = 0 },
                new Minutes2() {MM2Id = 1, Val2 = 1 },
                new Minutes2() {MM2Id = 2, Val2 = 2 },
                new Minutes2() {MM2Id = 3, Val2 = 3 },
                new Minutes2() {MM2Id = 4, Val2 = 4 },
                new Minutes2() {MM2Id = 5, Val2 = 5 },
                new Minutes2() {MM2Id = 6, Val2 = 6 },
                new Minutes2() {MM2Id = 7, Val2 = 7 },
                new Minutes2() {MM2Id = 8, Val2 = 8 },
                new Minutes2() {MM2Id = 9, Val2 = 9 },
                new Minutes2() {MM2Id = 10, Val2 = 10 },
                new Minutes2() {MM2Id = 11, Val2 = 11 },
                new Minutes2() {MM2Id = 12, Val2 = 12 },
                new Minutes2() {MM2Id = 13, Val2 = 13 },
                new Minutes2() {MM2Id = 14, Val2 = 14 },
                new Minutes2() {MM2Id = 15, Val2 = 15 },
                new Minutes2() {MM2Id = 16, Val2 = 16 },
                new Minutes2() {MM2Id = 17, Val2 = 17 },
                new Minutes2() {MM2Id = 18, Val2 = 18 },
                new Minutes2() {MM2Id = 19, Val2 = 19 },
                new Minutes2() {MM2Id = 20, Val2 = 20 },
                new Minutes2() {MM2Id = 21, Val2 = 21 },
                new Minutes2() {MM2Id = 22, Val2 = 22 },
                new Minutes2() {MM2Id = 23, Val2 = 23 },
                new Minutes2() {MM2Id = 24, Val2 = 24 },
                new Minutes2() {MM2Id = 25, Val2 = 25 },
                new Minutes2() {MM2Id = 26, Val2 = 26 },
                new Minutes2() {MM2Id = 27, Val2 = 27 },
                new Minutes2() {MM2Id = 28, Val2 = 28 },
                new Minutes2() {MM2Id = 29, Val2 = 29 },
                new Minutes2() {MM2Id = 30, Val2 = 30 },
                new Minutes2() {MM2Id = 31, Val2 = 31 },
                new Minutes2() {MM2Id = 32, Val2 = 32 },
                new Minutes2() {MM2Id = 33, Val2 = 33 },
                new Minutes2() {MM2Id = 34, Val2 = 34 },
                new Minutes2() {MM2Id = 35, Val2 = 35 },
                new Minutes2() {MM2Id = 36, Val2 = 36 },
                new Minutes2() {MM2Id = 37, Val2 = 37 },
                new Minutes2() {MM2Id = 38, Val2 = 38 },
                new Minutes2() {MM2Id = 39, Val2 = 39 },
            };
            ComboMM2.DataSource = MM2;
            ComboMM2.DisplayMember = "MMId2";
            ComboMM2.ValueMember = "Val2";
            var SS1 = new List<Seconds1>
            {
                new Seconds1() {SS1Id = 0, Val3 = 0 },
                new Seconds1() {SS1Id = 1, Val3 = 1 },
                new Seconds1() {SS1Id = 2, Val3 = 2 },
                new Seconds1() {SS1Id = 3, Val3 = 3 },
                new Seconds1() {SS1Id = 4, Val3 = 4 },
                new Seconds1() {SS1Id = 5, Val3 = 5 },
                new Seconds1() {SS1Id = 6, Val3 = 6 },
                new Seconds1() {SS1Id = 7, Val3 = 7 },
                new Seconds1() {SS1Id = 8, Val3 = 8 },
                new Seconds1() {SS1Id = 9, Val3 = 9 },
                new Seconds1() {SS1Id = 10, Val3 = 10 },
                new Seconds1() {SS1Id = 11, Val3 = 11 },
                new Seconds1() {SS1Id = 12, Val3 = 12 },
                new Seconds1() {SS1Id = 13, Val3 = 13 },
                new Seconds1() {SS1Id = 14, Val3 = 14 },
                new Seconds1() {SS1Id = 15, Val3 = 15 },
                new Seconds1() {SS1Id = 16, Val3 = 16 },
                new Seconds1() {SS1Id = 17, Val3 = 17 },
                new Seconds1() {SS1Id = 18, Val3 = 18 },
                new Seconds1() {SS1Id = 19, Val3 = 19 },
                new Seconds1() {SS1Id = 20, Val3 = 20 },
                new Seconds1() {SS1Id = 21, Val3 = 21 },
                new Seconds1() {SS1Id = 22, Val3 = 22 },
                new Seconds1() {SS1Id = 23, Val3 = 23 },
                new Seconds1() {SS1Id = 24, Val3 = 24 },
                new Seconds1() {SS1Id = 25, Val3 = 25 },
                new Seconds1() {SS1Id = 26, Val3 = 26 },
                new Seconds1() {SS1Id = 27, Val3 = 27 },
                new Seconds1() {SS1Id = 28, Val3 = 28 },
                new Seconds1() {SS1Id = 29, Val3 = 29 },
                new Seconds1() {SS1Id = 30, Val3 = 30 },
                new Seconds1() {SS1Id = 31, Val3 = 31 },
                new Seconds1() {SS1Id = 32, Val3 = 32 },
                new Seconds1() {SS1Id = 33, Val3 = 33 },
                new Seconds1() {SS1Id = 34, Val3 = 34 },
                new Seconds1() {SS1Id = 35, Val3 = 35 },
                new Seconds1() {SS1Id = 36, Val3 = 36 },
                new Seconds1() {SS1Id = 37, Val3 = 37 },
                new Seconds1() {SS1Id = 38, Val3 = 38 },
                new Seconds1() {SS1Id = 39, Val3 = 39 },
                new Seconds1() {SS1Id = 40, Val3 = 40 },
                new Seconds1() {SS1Id = 41, Val3 = 41 },
                new Seconds1() {SS1Id = 42, Val3 = 42 },
                new Seconds1() {SS1Id = 43, Val3 = 43 },
                new Seconds1() {SS1Id = 44, Val3 = 44 },
                new Seconds1() {SS1Id = 45, Val3 = 45 },
                new Seconds1() {SS1Id = 46, Val3 = 46 },
                new Seconds1() {SS1Id = 47, Val3 = 47 },
                new Seconds1() {SS1Id = 48, Val3 = 48 },
                new Seconds1() {SS1Id = 49, Val3 = 49 },
                new Seconds1() {SS1Id = 50, Val3 = 50 },
                new Seconds1() {SS1Id = 51, Val3 = 51 },
                new Seconds1() {SS1Id = 52, Val3 = 52 },
                new Seconds1() {SS1Id = 53, Val3 = 53 },
                new Seconds1() {SS1Id = 54, Val3 = 54 },
                new Seconds1() {SS1Id = 55, Val3 = 55 },
                new Seconds1() {SS1Id = 56, Val3 = 56 },
                new Seconds1() {SS1Id = 57, Val3 = 57 },
                new Seconds1() {SS1Id = 58, Val3 = 58 },
                new Seconds1() {SS1Id = 59, Val3 = 59 },
            };
            ComboSS1.DataSource = SS1;
            ComboSS1.DisplayMember = "SS1Id";
            ComboSS1.ValueMember = "Val3";
            var SS2 = new List<Seconds2>
            {
                new Seconds2() {SS2Id = 0, Val4 = 0 },
                new Seconds2() {SS2Id = 1, Val4 = 1 },
                new Seconds2() {SS2Id = 2, Val4 = 2 },
                new Seconds2() {SS2Id = 3, Val4 = 3 },
                new Seconds2() {SS2Id = 4, Val4 = 4 },
                new Seconds2() {SS2Id = 5, Val4 = 5 },
                new Seconds2() {SS2Id = 6, Val4 = 6 },
                new Seconds2() {SS2Id = 7, Val4 = 7 },
                new Seconds2() {SS2Id = 8, Val4 = 8 },
                new Seconds2() {SS2Id = 9, Val4 = 9 },
                new Seconds2() {SS2Id = 10, Val4 = 10 },
                new Seconds2() {SS2Id = 11, Val4 = 11 },
                new Seconds2() {SS2Id = 12, Val4 = 12 },
                new Seconds2() {SS2Id = 13, Val4 = 13 },
                new Seconds2() {SS2Id = 14, Val4 = 14 },
                new Seconds2() {SS2Id = 15, Val4 = 15 },
                new Seconds2() {SS2Id = 16, Val4 = 16 },
                new Seconds2() {SS2Id = 17, Val4 = 17 },
                new Seconds2() {SS2Id = 18, Val4 = 18 },
                new Seconds2() {SS2Id = 19, Val4 = 19 },
                new Seconds2() {SS2Id = 20, Val4 = 20 },
                new Seconds2() {SS2Id = 21, Val4 = 21 },
                new Seconds2() {SS2Id = 22, Val4 = 22 },
                new Seconds2() {SS2Id = 23, Val4 = 23 },
                new Seconds2() {SS2Id = 24, Val4 = 24 },
                new Seconds2() {SS2Id = 25, Val4 = 25 },
                new Seconds2() {SS2Id = 26, Val4 = 26 },
                new Seconds2() {SS2Id = 27, Val4 = 27 },
                new Seconds2() {SS2Id = 28, Val4 = 28 },
                new Seconds2() {SS2Id = 29, Val4 = 29 },
                new Seconds2() {SS2Id = 30, Val4 = 30 },
                new Seconds2() {SS2Id = 31, Val4 = 31 },
                new Seconds2() {SS2Id = 32, Val4 = 32 },
                new Seconds2() {SS2Id = 33, Val4 = 33 },
                new Seconds2() {SS2Id = 34, Val4 = 34 },
                new Seconds2() {SS2Id = 35, Val4 = 35 },
                new Seconds2() {SS2Id = 36, Val4 = 36 },
                new Seconds2() {SS2Id = 37, Val4 = 37 },
                new Seconds2() {SS2Id = 38, Val4 = 38 },
                new Seconds2() {SS2Id = 39, Val4 = 39 },
                new Seconds2() {SS2Id = 40, Val4 = 40 },
                new Seconds2() {SS2Id = 41, Val4 = 41 },
                new Seconds2() {SS2Id = 42, Val4 = 42 },
                new Seconds2() {SS2Id = 43, Val4 = 43 },
                new Seconds2() {SS2Id = 44, Val4 = 44 },
                new Seconds2() {SS2Id = 45, Val4 = 45 },
                new Seconds2() {SS2Id = 46, Val4 = 46 },
                new Seconds2() {SS2Id = 47, Val4 = 47 },
                new Seconds2() {SS2Id = 48, Val4 = 48 },
                new Seconds2() {SS2Id = 49, Val4 = 49 },
                new Seconds2() {SS2Id = 50, Val4 = 50 },
                new Seconds2() {SS2Id = 51, Val4 = 51 },
                new Seconds2() {SS2Id = 52, Val4 = 52 },
                new Seconds2() {SS2Id = 53, Val4 = 53 },
                new Seconds2() {SS2Id = 54, Val4 = 54 },
                new Seconds2() {SS2Id = 55, Val4 = 55 },
                new Seconds2() {SS2Id = 56, Val4 = 56 },
                new Seconds2() {SS2Id = 57, Val4 = 57 },
                new Seconds2() {SS2Id = 58, Val4 = 58 },
                new Seconds2() {SS2Id = 59, Val4 = 59 },
            };
            ComboSS2.DataSource = SS2;
            ComboSS2.DisplayMember = "SS2Id";
            ComboSS2.ValueMember = "Val4";
        }
        private void ComboBoxInst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instance Instances1 = ComboBoxInst1.SelectedItem as Instance;
            MaxTime1 = Instances1.Intime;
            var timespan = TimeSpan.FromSeconds(Instances1.Intime);
            TxtInTime1.Text = timespan.ToString(@"mm\:ss");
            var timespan2 = TimeSpan.FromSeconds(Instances1.Plus2Time);
            Txt1Plus2.Text = timespan2.ToString(@"mm\:ss");
            var timespan3 = TimeSpan.FromSeconds(Instances1.Plus3Time);
            Txt1Plus3.Text = timespan3.ToString(@"mm\:ss");
        }
        private void ComboBoxInst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instance2 Instances2 = ComboBoxInst2.SelectedItem as Instance2;
            MaxTime2 = Instances2.Intime2;
            var timespan4 = TimeSpan.FromSeconds(Instances2.Intime2);
            TxtInTime2.Text = timespan4.ToString(@"mm\:ss");
            var timespan5 = TimeSpan.FromSeconds(Instances2.Plus2Time2);
            Txt2Plus2.Text = timespan5.ToString(@"mm\:ss");
            var timespan6 = TimeSpan.FromSeconds(Instances2.Plus3Time2);
            Txt2Plus3.Text = timespan6.ToString(@"mm\:ss");
        }

        private void ComboMM1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Minutes1 MM1 = ComboMM1.SelectedItem as Minutes1;
            Minut1 = MM1.Val1*60;
        }
        private void ComboSS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seconds1 SS1 = ComboSS1.SelectedItem as Seconds1;
            Secon1 = SS1.Val3;
        }
        private void ComboMM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Minutes2 MM2 = ComboMM2.SelectedItem as Minutes2;
            Minut2 = MM2.Val2*60;
        }

        private void ComboSS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seconds2 SS2 = ComboSS2.SelectedItem as Seconds2;
            Secon2 = SS2.Val4;
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            decimal Max1 = MaxTime1;
            decimal Max2 = MaxTime2;
            decimal Total1 = Minut1 + Secon1;
            decimal Total2 = Minut2 + Secon2;
            decimal Const = 1;
            decimal Percent1 = (Const / Max1) * Total1;
            decimal Percent2 = (Const / Max2) * Total2;
            TxtPercent1.Text = Percent1.ToString("P", CultureInfo.InvariantCulture);
            TxtPercent2.Text = Percent2.ToString("P", CultureInfo.InvariantCulture);
            if (Percent1 > Percent2)
            {
                TxtWinLose1.Text = "Schneller";
                TxtWinLose1.BackColor = Color.Green;
                TxtWinLose2.Text = "Langsamer";
                TxtWinLose2.BackColor = Color.Red;
            }
            else if (Percent1 < Percent2)
            {
                TxtWinLose2.Text = "Schneller";
                TxtWinLose2.BackColor = Color.Green;
                TxtWinLose1.Text = "Langsamer";
                TxtWinLose1.BackColor = Color.Red;
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ComboBoxInst1.SelectedIndex = 0;
            ComboBoxInst2.SelectedIndex = 0;
            ComboMM1.SelectedIndex = 0;
            ComboMM2.SelectedIndex = 0;
            ComboSS1.SelectedIndex = 0;
            ComboSS2.SelectedIndex = 0;
            TxtPercent1.Text = "";
            TxtPercent2.Text = "";
            TxtWinLose1.Text = "";
            TxtWinLose2.Text = "";
            TxtWinLose1.BackColor = Color.Navy;
            TxtWinLose2.BackColor = Color.Navy;
        }
    }
    public class Instance
    {
        public int InstanceID { get; set; }
        public string Name { get; set; }
        public int Intime { get; set; }
        public int Plus2Time { get; set; }
        public int Plus3Time { get; set; }
    }
    public class Instance2
    {
        public int InstanceID2 { get; set; }
        public string Name2 { get; set; }
        public int Intime2 { get; set; }
        public int Plus2Time2 { get; set; }
        public int Plus3Time2 { get; set; }
    }
    public class Minutes1
    {
        public int MM1Id { get; set; }
        public int Val1 { get; set; }
    }
    public class Minutes2
    {
        public int MM2Id { get; set; }
        public int Val2 { get; set; }
    }
    public class Seconds1
    {
        public int SS1Id { get; set; }
        public int Val3 { get; set; }
    }
    public class Seconds2
    {
        public int SS2Id { get; set; }
        public int Val4 { get; set; }
    }
}
