using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace PhasmoHelper
{
    public partial class MainForm : Form
    {
        public CheckBox[] evidenceList;
        public Label[] typeList;
        private Label[] hotkeylist;

        bool typeClicked = true;
        bool hotkey_enable;

        think think = new think();
        globalKeyboardHook gkh = new globalKeyboardHook();
        INIManager settings = new INIManager(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\phasmohelper.settings.ini");

        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;

            // Массивы элементов
            evidenceList = new CheckBox[6] { emp, print, term, radio, notes, orb };
            typeList = new Label[12] { banshi, revenant, phantom, oni, jin, shadow, mirage, spirit, polterheist, demon, mara, urei };
            hotkeylist = new Label[7] { emp_key, print_key, term_key, radio_key, notes_key, orb_key, reset_key };

            label1.Text = $"Прозрачность {trackBar1.Value}%";

            // Проверка целостности файла настроек
            if (!File.Exists(settings.Path))
            {
                while (File.Exists(settings.Path))
                    File.Create(settings.Path);

                foreach(Label k in hotkeylist)
                    settings.WritePrivateString("keys", k.Name, k.Tag.ToString());

                settings.WritePrivateString("params", "hotkey_enable", "true");
            }

            // Установка горячих клавиш из файла
            foreach (Label k in hotkeylist)
            {
                k.Text = think.KeyCodeName(settings.GetPrivateString("keys", k.Name));
                k.Tag = settings.GetPrivateString("keys", k.Name);
                gkh.HookedKeys.Add((Keys)Enum.Parse(typeof(Keys), settings.GetPrivateString("keys", k.Name)));
            }

            hotkey_enable = Convert.ToBoolean(settings.GetPrivateString("params", "hotkey_enable"));
            if (hotkey_enable) HotkeyStatusLabel1.Text = "Горячие клавиши включены, для изменения нажмите";
            else HotkeyStatusLabel1.Text = "Горячие клавиши выключены, для изменения нажмите";

            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }

        private void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (hotkey_enable)
            {
                if (e.KeyCode.ToString() == reset_key.Tag.ToString())
                    ResetButton_Click(sender, e);

                else if (e.KeyCode.ToString() == emp_key.Tag.ToString() & emp.Enabled)
                    emp.Checked = !emp.Checked;

                else if (e.KeyCode.ToString() == print_key.Tag.ToString() & print.Enabled)
                    print.Checked = !print.Checked;

                else if (e.KeyCode.ToString() == term_key.Tag.ToString() & term.Enabled)
                    term.Checked = !term.Checked;

                else if (e.KeyCode.ToString() == radio_key.Tag.ToString() & radio.Enabled)
                    radio.Checked = !radio.Checked;

                else if (e.KeyCode.ToString() == notes_key.Tag.ToString() & notes.Enabled)
                    notes.Checked = !notes.Checked;

                else if (e.KeyCode.ToString() == orb_key.Tag.ToString() & orb.Enabled)
                    orb.Checked = !orb.Checked;
            }

        }

        /// <summary>
        /// Считывает клавиши в фокусе программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.F6 && e.Shift) // Перезапуск программы со сбросом настроек
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите сбросить настройки горячих клавиш?", ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    File.Delete(settings.Path);
                    Application.Restart();
                }
            }

            else if (e.KeyCode == Keys.F7 && e.Shift)
            {
                hotkey_enable = !hotkey_enable;

                settings.WritePrivateString("params", "hotkey_enable", hotkey_enable.ToString());
                if (hotkey_enable) HotkeyStatusLabel1.Text = "Горячие клавиши включены, для изменения нажмите";
                else HotkeyStatusLabel1.Text = "Горячие клавиши выключены, для изменения нажмите";
            }
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            KeyUp -= new KeyEventHandler(Form_KeyUp);

            foreach (Label k in hotkeylist) 
                if(k.BorderStyle == BorderStyle.FixedSingle)
                {
                    if(e.KeyCode == Keys.Escape)
                    {
                        k.BorderStyle = BorderStyle.Fixed3D;
                        continue;
                    }
                    k.Text = think.KeyCodeName(e.KeyCode.ToString());
                    k.Tag = e.KeyCode;
                    k.BorderStyle = BorderStyle.Fixed3D;

                    if (!gkh.HookedKeys.Contains(e.KeyCode))
                        gkh.HookedKeys.Add(e.KeyCode); // иницилизация клавиши

                    // Изменение файла настроек
                    settings.WritePrivateString("keys", k.Name, e.KeyCode.ToString());
                }

        }

        /// <summary>
        /// Событие установки хотекя
        /// </summary>
        private void key_init(object sender, EventArgs e)
        {
            KeyUp += new KeyEventHandler(Form_KeyUp);
            (sender as Label).BorderStyle = BorderStyle.FixedSingle;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            typeClicked = true;
            for (int i = 0; i < evidenceList.Length; i++)
            {
                evidenceList[i].Checked = false;
                evidenceList[i].Enabled = true;
                evidenceList[i].BackColor = Color.Empty;
            }
            for (int i = 0; i < typeList.Length; i++)
            {
                typeList[i].Enabled = true;
                typeList[i].BackColor = Color.Empty;
            }
            descriptionTextBox.Text = "Выберите тип призрака, и здесь появиться его описание и особенности.";
        }

        private void CheckBox_Changed(object sender, EventArgs e)
        {
            string[] evidence = new string[3] { null, null, null }; 
            
            int j = 0; // Счётчик улик
            for (int i = 0; i < evidenceList.Length; i++)
            {
                if (evidenceList[i].Checked & j < 3)
                {
                    evidence[j] = evidenceList[i].Name;
                    j++;
                }
            }

            string[] temp = think.typeIDN(evidence, j);

            // Вывод типов призрака
            for (int i = 0; i < typeList.Length; i++)
            {
                if (typeList[i].Name == temp[i])
                {
                    typeList[i].Enabled = true;
                    if (j == 3) 
                        descriptionTextBox.Text = think.getDescription(typeList[i].Name);
                    else
                        descriptionTextBox.Text = "Выберите тип призрака, и здесь появиться его описание и особенности."; ;
                }
                else
                {
                    if(j == 0)
                        typeList[i].Enabled = true;
                    else
                        typeList[i].Enabled = false;
                }
            }

            // Подсвечивание улик
            if (j == 2)
            {
                int n = 0;
                for (int i = 0; i < typeList.Length; i++)
                    if (typeList[i].Enabled) {
                        // Цвет призрака
                        switch (n)
                        {
                            case 0:
                                typeList[i].BackColor = Color.LightCoral;
                                break;
                            case 1:
                                typeList[i].BackColor = Color.Orange;
                                break;
                            case 2:
                                typeList[i].BackColor = Color.DarkSeaGreen;
                                break;
                            case 3:
                                typeList[i].BackColor = Color.MediumPurple;
                                break;
                        }

                        // Цвет недостоющей улики
                        for(int k = 0; k < evidenceList.Length; k++)
                            if (!evidenceList[k].Checked)
                            {
                                if (
                                    evidenceList[k].Name == think.evidIDN(typeList[i].Name)[0] ||
                                    evidenceList[k].Name == think.evidIDN(typeList[i].Name)[1] ||
                                    evidenceList[k].Name == think.evidIDN(typeList[i].Name)[2]
                                  )
                                {
                                    switch (n)
                                    {
                                        case 0:
                                            evidenceList[k].BackColor = Color.LightCoral;
                                            break;
                                        case 1:
                                            evidenceList[k].BackColor = Color.Orange;
                                            break;
                                        case 2:
                                            evidenceList[k].BackColor = Color.DarkSeaGreen;
                                            break;
                                        case 3:
                                            evidenceList[k].BackColor = Color.MediumPurple; 
                                            break;
                                    }
                                }
                                else evidenceList[k].Enabled = false;
                            }

                        n++;
                    }
            }
            else
            {
                for (int i = 0; i < typeList.Length; i++)
                    typeList[i].BackColor = Color.Empty;
                for (int i = 0; i < evidenceList.Length; i++)
                    evidenceList[i].BackColor = Color.Empty;
            }

            // Блокирование и разблокирование чекбоксов
            if (j == 3) for (int g = 0; g < evidenceList.Length; g++) evidenceList[g].Enabled = evidenceList[g].Checked;
            else for (int g = 0; g < evidenceList.Length; g++) evidenceList[g].Enabled = true;
        }

        private void Type_Click(object sender, EventArgs e)
        {
            typeClicked = !typeClicked;
            if (typeClicked)
                ResetButton_Click(sender, e);
            else
            {
                // Определение улик призрака
                string[] evidence = think.evidIDN((sender as Label).Name);
                for (int i = 0; i < evidenceList.Length; i++)
                    if (evidenceList[i].Name == evidence[0] || evidenceList[i].Name == evidence[1] || evidenceList[i].Name == evidence[2]) evidenceList[i].Checked = true;

                // Вывод описания призрака
                descriptionTextBox.Text = think.getDescription((sender as Label).Name);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = $"Прозрачность {trackBar1.Value}%";
            ActiveForm.Opacity = trackBar1.Value * 0.01;
        }
    }
}
