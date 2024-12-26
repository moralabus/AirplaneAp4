using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO; // Add this namespace for file operations

namespace AirplaneAp4
{
    public partial class Form1 : Form
    {
        private List<Airplane> airplanes = new List<Airplane>();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
            buttonAddAirplaneWithFoto.Click += buttonAddAirplaneWithFoto_Click;
            buttonSort.Click += buttonSortByFuelConsumption_Click_1;
            this.BackColor = Airplane.BackColor;

            // Настройка OpenFileDialog
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog1.Multiselect = false; // Позволяет выбрать только один файл
            buttonSelectFoto.Click += buttonSelectFoto_Click;

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";

            comboBoxModel.Items.AddRange(new string[] { "Boeing 737", "Airbus A320", "Embraer 190" });

            buttonLoadFromFile.Click += buttonLoadFromFile_Click;
            buttonSaveToFile.Click += buttonSaveToFile_Click;
            buttonShowAirplaneInfo.Click += buttonShowAirplaneInfo_Click;
            buttonCalculateAverageConsumption.Click += buttonCalculateAverageConsumption_Click;
        }

        private void buttonSelectFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void buttonAddAirplaneWithFoto_Click(object sender, EventArgs e)
        {
            string airplaneName = textBoxAirplaneName.Text?.Trim();
            string model = comboBoxModel.SelectedItem?.ToString();
            int range = (int)numericUpDownRange.Value;
            decimal fuelConsumption = numericUpDownFuelConsumption.Value;
            DateTime manufactureDate = dateTimePickerManufactureDate.Value;
            string foto = openFileDialog1.FileName;

            if (string.IsNullOrEmpty(airplaneName) || string.IsNullOrEmpty(model) ||  string.IsNullOrEmpty(foto)) // Добавьте проверку для foto
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            Airplane newAirplane = new Airplane(airplaneName, model, range, fuelConsumption, manufactureDate, foto);
            airplanes.Add(newAirplane);
            UpdateListBox();
            ClearForm();
            newAirplane.ShowFoto(pictureBoxFoto);
        }

        private void ClearForm()
        {
            textBoxAirplaneName.Clear();
            comboBoxModel.SelectedIndex = -1;
            numericUpDownRange.Value = 0;
            numericUpDownFuelConsumption.Value = 0;
            dateTimePickerManufactureDate.Value = DateTime.Now;
            pictureBoxFoto.Image = null;
        }

        private void buttonSortByFuelConsumption_Click_1(object sender, EventArgs e)
        {
            SortAirplanesByFuelConsumption();
        }

        private void SortAirplanesByFuelConsumption()
        {
            airplanes = airplanes.OrderBy(a => a.FuelConsumption).ToList();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxAirplanes.Items.Clear();
            foreach (var airplane in airplanes)
            {
                string airplaneInfo = string.Format("Имя: {0}, Модель: {1}, Дальность: {2} км, Расход: {3} л/100 км, Возраст: {4} лет",
                  airplane.Name, airplane.Model, airplane.Range, airplane.FuelConsumption, airplane.GetAge());

                listBoxAirplanes.Items.Add(airplaneInfo);
            }
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog loadFileDialog = new OpenFileDialog())
            {
                loadFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (loadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = loadFileDialog.FileName;
                    try
                    {
                        airplanes = Airplane.ReadFromFile(filePath);
                        UpdateListBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
                    }
                }
            }
        }


        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                Airplane.WriteToFile(airplanes, filePath);
            }
        }

        private void buttonShowAirplaneInfo_Click(object sender, EventArgs e)
        {
            if (listBoxAirplanes.SelectedIndex != -1)
            {
                Airplane selectedAirplane = airplanes[listBoxAirplanes.SelectedIndex];
                string airplaneInfo = string.Format(
                  "Имя: {0}, Модель: {1}, Дальность: {2} км, Расход: {3} л/100 км, Возраст: {4} лет",
                  selectedAirplane.Name, selectedAirplane.Model, selectedAirplane.Range,
                  selectedAirplane.FuelConsumption, selectedAirplane.GetAge());

                textBoxOutput.Text = airplaneInfo;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите самолет из списка.");
            }
        }

        public void AverageFuelConsumption(List<Airplane> airplanes, out decimal averageConsumption, out string resume)
        {
            if (airplanes.Count > 0)
            {
                averageConsumption = airplanes.Average(a => a.FuelConsumption);
                resume = averageConsumption > 20 ? "Расход выше нормы" : "Расход ниже нормы";
            }
            else
            {
                averageConsumption = 0;
                resume = "Нет данных для расчета";
            }
        }

        private void buttonCalculateAverageConsumption_Click(object sender, EventArgs e)
        {
            decimal averageConsumption;
            string resume;

            AverageFuelConsumption(airplanes, out averageConsumption, out resume);

            textBoxOutput.Text = $"Средний расход топлива: {averageConsumption} л/100 км\n{resume}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}