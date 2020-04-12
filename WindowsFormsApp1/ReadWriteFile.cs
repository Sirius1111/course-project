using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ReadWriteFile
    {
        public void Write(string text, string fileName = "file-input", string nameDir = "Results")
        {
            string writePath = $"../../../{nameDir}/{fileName}.txt";
            if(!Directory.Exists($"../../../" + nameDir + "/") )
            { 
                Directory.CreateDirectory($"../../../{nameDir}");
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                MessageBox.Show("Запись выполнена");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public string ReadFileName(string fileName = "file-read", string nameDir = "Results")
        {
            string writePath = $"../../../{nameDir}/{fileName}.txt";
            string data = "";
            if (Directory.Exists(writePath)){
                try{
                    using (StreamReader sr = new StreamReader(writePath))
                    {
                        while (sr.EndOfStream)
                        {
                            data += sr.ReadLine() + "|";
                        }
                    }
                    MessageBox.Show("Данные успешно загружены");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            } else {
                MessageBox.Show("Такого файла не существует");
            }
            return data;
        }
        public ArrayList ReadFilePath(string path)
        {
            var data = new ArrayList();
            string writePath = path;
            try
            {
                using (StreamReader sr = new StreamReader(writePath, Encoding.GetEncoding("windows-1251")))
                {
                    while (!sr.EndOfStream)
                    {
                        data.Add(sr.ReadLine());
                    }
                }
                MessageBox.Show("Данные успешно загружены");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return data;
        }
    }
}
