﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace тРПО
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void method();
        method async;
        public async void CheckFileAsync()
        {
            await
                Task.Run(() => CheckFile());
        }

        public void CheckFile()
        { 
            DateTime a = DateTime.MinValue;
            while (true)
            {
                try
                {
                    string pt = FilePath.Text;
                    if (pt != String.Empty)
                    {
                        FileInfo s = new FileInfo(pt);
                        if (s.LastWriteTime > a)
                        {
                            tablo.Invoke(async);
                        }
                        a = s.LastWriteTime;
                        s = null;
                    }
                    
                }
                catch(Exception)
                {

                }
                System.Threading.Thread.Sleep(500);
            }
        }
        public void WriteTablo()
        {
            using (StreamReader stream = new StreamReader(FilePath.Text))
            {
                tablo.Text = "";
                while (!stream.EndOfStream)
                    tablo.Text += stream.ReadLine() + Environment.NewLine;
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Текстовые файлы(*.txt)|*.txt" };
            if (ofd.ShowDialog() == DialogResult.OK)
                FilePath.Text = ofd.FileName;
            
        }

        private void Write_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != String.Empty)
            {
                string s = TextBox.Text;
                TextBox.Text = "";
                string file = "";
                using (StreamReader stream = new StreamReader(FilePath.Text))
                {
                    while (!stream.EndOfStream)
                        file = stream.ReadToEnd();
                }
                StreamWriter sw = new StreamWriter(FilePath.Text);
                sw.Write($"{DateTime.Now} | {Environment.UserName} | {s}\n" + file);
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            async = WriteTablo;
            CheckFileAsync();
        }
    }
}
