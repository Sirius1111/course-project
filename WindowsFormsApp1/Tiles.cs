using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void textInput_TextChanged_1(object sender, EventArgs e)
        {
            textLabel.Text = textInput.Text;
        }
        private void changeAction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Сконструировать делегат.
            GuitarTitleMod guitarTitle;
            string str = textInput.Text;
            switch (changeAction.SelectedItem)
            {
                case "Перевести в нижний регистр":
                    guitarTitle = new GuitarTitleMod(GuitarActionsTitleList.ToLowerCaseTitle);
                    guitarTitle(ref str);
                    MessageBox.Show("Результат перевода в нижний регистр: " + str);
                    break;
                case "Перевести в верхний регистр":
                    guitarTitle = new GuitarTitleMod(GuitarActionsTitleList.ToUpperCaseTitle);
                    guitarTitle(ref str);
                    MessageBox.Show("Результат перевода в верхний регистр: " + str);
                    break;
                case "Удалить пробелы":
                    guitarTitle = new GuitarTitleMod(GuitarActionsTitleList.DeleteSpaces);
                    guitarTitle(ref str);
                    MessageBox.Show("Результат Удаление пробелов: " + str);
                    break;
                case "Заменить пробелы на переносы":
                    guitarTitle = new GuitarTitleMod(GuitarActionsTitleList.ReplaceSpaces);
                    guitarTitle(ref str);
                    MessageBox.Show("Результат замены пробелов: " + str);
                    break;
            }
        }
        private void TextChanged_Click(object sender, EventArgs e)
        {
            string str = textInput.Text;
            string text = (sender as Button).Text;
            GuitarActionsTitleButtons actionsTitleButtons = new GuitarActionsTitleButtons();
            actionsTitleButtons.Notify += DisplayMessage;
            switch (text)
            {
                case "Нижний регистр":
                    actionsTitleButtons.ToLowerCaseTitle(ref str);
                    MessageBox.Show("Резальтат перевода в нижний регистр: " + str);
                    break;
                case "Верхний регистр":
                    actionsTitleButtons.ToUpperCaseTitle(ref str);
                    MessageBox.Show("Резальтат перевода в верхний регистр: " + str);
                    break;
                case "Заменить пробелы":
                    actionsTitleButtons.ReplaceSpaces(ref str);
                    MessageBox.Show("Резальтат замены пробелов: " + str);
                    break;
                case "Удалить пробелы":
                    actionsTitleButtons.DeleteSpaces(ref str);
                    MessageBox.Show("Резальтат удаления пробелов: " + str);
                    break;
            }
            actionsTitleButtons.Notify -= DisplayMessage;

        }
        private static void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
    // Объявить тип делегата
    delegate void GuitarTitleMod(ref string str);
    public class GuitarActionsTitleList
    {
        //Замена пробелов на переносы строк
        public static void ReplaceSpaces(ref string title)
        {
            title = title.Replace(' ', '\n');
        }
        //Перевод текста в нижний регистр
        public static void ToLowerCaseTitle(ref string title)
        {
            title = title.ToLower();
        }
        //Перевод текста в вержний регистр
        public static void ToUpperCaseTitle(ref string title)
        {
            title = title.ToUpper();
        }
        //Полное удаление пробелов
        public static void DeleteSpaces(ref string title)
        {
            title = title.Trim().Replace(" ", string.Empty);
        }

    }






    public class GuitarActionsTitleButtons
    {
        // Создание делигата
        public delegate void GuitarNameHandler(string message);
        // 1.Определение события
        public event GuitarNameHandler Notify;              
        //Замена пробелов на переносы строк
        public void ReplaceSpaces(ref string title)
        {
            title = title.Replace(' ', '\n');
            Notify?.Invoke("У текста были заменены пробелы");  // 2.Вызов события 
        }
        //Перевод текста в нижний регистр
        public void ToLowerCaseTitle(ref string title)
        {
            title = title.ToLower();
            Notify?.Invoke("Текст был переведен в нижний регистр");  // 2.Вызов события 
        }
        //Перевод текста в верхний регистр
        public void ToUpperCaseTitle(ref string title)
        {
            title = title.ToUpper();
            Notify?.Invoke("Текст был переведен в верхний регистр");  // 2.Вызов события
        }
        //Полное удаление пробелов
        public void DeleteSpaces(ref string title)
        {
            title = title.Trim().Replace(" ", string.Empty);
            Notify?.Invoke("Их текста были удалены пробелы");  // 2.Вызов события
        }

    }
  

}
