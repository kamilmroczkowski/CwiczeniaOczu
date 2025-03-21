using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Cwieczenie1
{
    public partial class Form1 : Form
    {
        private RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        private bool run = false;
        private string charsLiteryMale = "abcdefghijklmnopqrstuvwxyz";
        private string charsLiteryDuze = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string charsCyfry = "1234567890";
        private string charsSpolgloski = "bcdfghjklmnprstwz";
        private string charsSamogloski = "aeiouy";
        private string slownikWyrazow3 = "kot, kok, lok, tok, tak, rak, mak, osa, lis, las, lew, kos, zez, wóz, bok, sok, sos, oko, nie, mam, tam, noc, moc, koń, bal, dom, nos, hak, tor, por, rak";
        private string chars;
        List<string> wyrazy3literowe = new List<string>();
        public Form1()
        {
            InitializeComponent();
            labelTime.Text = "";
            this.wyrazy3literowe = slownikWyrazow3.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private void startStop()
        {
            //STOP
            if (this.run)
            {
                this.run = false;
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                    labelTime.Text = "";
                    labelText.Font = new Font(labelText.Font.FontFamily, 36, FontStyle.Bold);
                    labelText.Text = "Naciśnij start";
                    button1.Text = "Start";
                }
            }
            //START
            else
            {
                labelText.Text = "";
                this.chars = "";
                if (rbCyfry.Checked)
                {
                    this.chars = this.charsCyfry;
                }
                else if (rbLitery.Checked)
                {
                    this.chars = this.charsLiteryMale + this.charsLiteryDuze;
                }
                else if (rbLiteryCyfry.Checked)
                {
                    this.chars = this.charsLiteryMale + this.charsCyfry + this.charsLiteryDuze;
                }
                if (rbRysunki.Checked)
                {
                    labelText.Visible = false;
                    pictureBox1.Visible = true;
                }
                else
                {
                    labelText.Visible = true;
                    pictureBox1.Visible = false;
                }
                this.run = true;
                button1.Text = "Stop";
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.startStop();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.startStop();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rand = new Random();
            int num = 0, num2 = 0;
            string napis = "";
            decimal time = 0;
            decimal totalTime = numericUpDownTotalTime.Value * 1000;
            if (rbRysunki.Checked)
            {
                //OBRAZY
                string imgDir = AppDomain.CurrentDomain.BaseDirectory + "img";
                if (Directory.Exists(imgDir))
                {
                    var ext = new List<string> { "jpg", "gif", "png" };
                    List<string> myFiles = new List<string>(Directory
                        .EnumerateFiles(imgDir, "*.*", SearchOption.AllDirectories)
                        .Where(s => ext.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant())));
                    if (myFiles.Count() > 0)
                    {
                        while (this.run && time < totalTime)
                        {
                            num = rand.Next(0, myFiles.Count());
                            pictureBox1.Invoke((MethodInvoker)delegate
                            {
                                pictureBox1.Image = Image.FromFile(myFiles[num]);
                            });
                            Thread.Sleep((int)numericUpDownTime1.Value);
                            time += numericUpDownTime1.Value;
                            labelTime.Invoke((MethodInvoker)delegate
                            {
                                labelTime.Text = (time / 1000).ToString();
                            });
                            pictureBox1.Invoke((MethodInvoker)delegate
                            {
                                pictureBox1.Image = null;
                            });
                            Thread.Sleep((int)numericUpDownTime2.Value);
                            time += numericUpDownTime2.Value;
                            labelTime.Invoke((MethodInvoker)delegate
                            {
                                labelTime.Text = (time / 1000).ToString();
                            });
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak obrazów (jpg, gif, png) w katalogu: " + imgDir);
                    }
                }
                else
                {
                    MessageBox.Show("Brak katalogu z plikami w: " + imgDir);
                }
            }
            else
            {
                //ZNAKI, Sylaby i wyraz 3 znakowe
                labelText.Font = new Font(labelText.Font.FontFamily, (float)numericUpDownFontSize.Value, FontStyle.Bold);
                while (this.run && time < totalTime)
                {
                    if (rbSylaby.Checked)
                    {
                        num2 = rand.Next(0, this.charsSamogloski.Length);
                        num = rand.Next(0, this.charsSamogloski.Length);
                        napis = this.charsSpolgloski[num].ToString() + this.charsSamogloski[num2].ToString();
                    }
                    else if (rb3Lw.Checked)
                    {
                        num = rand.Next(0, this.wyrazy3literowe.Count);
                        napis = this.wyrazy3literowe[num];
                    }
                    else
                    {
                        num = rand.Next(0, this.chars.Length);
                        napis = this.chars[num].ToString();
                    }
                    labelText.Invoke((MethodInvoker)delegate
                    {
                        labelText.Text = napis;
                    });
                    Thread.Sleep((int)numericUpDownTime1.Value);
                    time += numericUpDownTime1.Value;
                    labelTime.Invoke((MethodInvoker)delegate
                    {
                        labelTime.Text = (time / 1000).ToString();
                    });
                    labelText.Invoke((MethodInvoker)delegate
                    {
                        labelText.Text = "";
                    });
                    Thread.Sleep((int)numericUpDownTime2.Value);
                    time += numericUpDownTime2.Value;
                    labelTime.Invoke((MethodInvoker)delegate
                    {
                        labelTime.Text = (time / 1000).ToString();
                    });
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.run = false;
            labelText.Font = new Font(labelText.Font.FontFamily, 36, FontStyle.Bold);
            labelText.Text = "Naciśnij start";
            button1.Text = "Start";
            labelTime.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (key.GetValueNames().Contains("fontSize") == true)
            {
                numericUpDownFontSize.Value = decimal.Parse(key.GetValue("fontSize").ToString());
            }
            if (key.GetValueNames().Contains("time1") == true)
            {
                numericUpDownTime1.Value = decimal.Parse(key.GetValue("time1").ToString());
            }
            if (key.GetValueNames().Contains("time2") == true)
            {
                numericUpDownTime2.Value = decimal.Parse(key.GetValue("time2").ToString());
            }
            if (key.GetValueNames().Contains("totalTime") == true)
            {
                numericUpDownTotalTime.Value = decimal.Parse(key.GetValue("totalTime").ToString());
            }
            if (key.GetValueNames().Contains("lastType") == true)
            {
                string w = key.GetValue("lastType").ToString();
                if (w == "2")
                {
                    rbLitery.Checked = true;
                }
                else if (w == "3")
                {
                    rbCyfry.Checked = true;
                }
                else if (w == "4")
                {
                    rbRysunki.Checked = true;
                }
                else if (w == "5")
                {
                    rbSylaby.Checked = true;
                }
                else if (w == "6")
                {
                    rb3Lw.Checked = true;
                }
                else
                {
                    rbLiteryCyfry.Checked = true;
                }
            }
        }

        private void numericUpDownFontSize_Leave(object sender, EventArgs e)
        {
            key.SetValue("fontSize", numericUpDownFontSize.Value);
        }

        private void numericUpDownTime1_Leave(object sender, EventArgs e)
        {
            key.SetValue("time1", numericUpDownTime1.Value);
        }

        private void numericUpDownTime2_Leave(object sender, EventArgs e)
        {
            key.SetValue("time2", numericUpDownTime2.Value);
        }

        private void numericUpDownTotalTime_Leave(object sender, EventArgs e)
        {
            key.SetValue("totalTime", numericUpDownTotalTime.Value);
        }

        private void rbLiteryCyfry_CheckedChanged(object sender, EventArgs e)
        {
            key.SetValue("lastType", 1);
        }

        private void rbLitery_CheckedChanged(object sender, EventArgs e)
        {
            key.SetValue("lastType", 2);
        }

        private void rbCyfry_CheckedChanged(object sender, EventArgs e)
        {
            key.SetValue("lastType", 3);
        }

        private void rbRysunki_CheckedChanged(object sender, EventArgs e)
        {
            key.SetValue("lastType", 4);
        }

        private void rbSylaby_CheckedChanged(object sender, EventArgs e)
        {
            key.SetValue("lastType", 5);
        }

        private void rb3Lw_CheckedChanged(object sender, EventArgs e)
        {
            key.SetValue("lastType", 6);
        }
    }
}
