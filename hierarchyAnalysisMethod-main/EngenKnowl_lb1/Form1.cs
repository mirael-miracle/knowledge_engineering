using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngenKnowl_lb1
{
    public partial class Form1 : Form
    {
        public static bool endInit = false;
        public static float[,] critTable;
        public static int criteriaAmount = 7;
        public static int itemsAmount = 3;
        public static int criteriaCounter = 0;
        DataGridView dataGridView2;
        // ІУ для випадкових матриць різного порядку
        public static Dictionary<int, float> CrValues = new Dictionary<int, float>
        {
            { 1, 0},
            { 2, 0},
            { 3, 0.58f},
            { 4, 0.9f},
            { 5, 1.12f},
            { 6, 1.24f},
            { 7, 1.32f},
            { 8, 1.41f},
            { 9, 1.45f},
            { 10, 1.49f}
        };

        public static List<float[,]> desigionList = new List<float[,]>();

        public Form1()
        {
            InitializeComponent();
            // Створення головної форми, заповнення першої таблиці діагонально одиницями.
            for (int i = 0; i < criteriaAmount + 1; i++)
            {
                dataGridView1.Rows.Add();
            }
            for(int i = 0; i < criteriaAmount; i++)
            {
                dataGridView1.Rows[i].Cells[i].Value = 1;
            }
            dataGridView1.Rows[criteriaAmount].DefaultCellStyle.BackColor = Color.Aquamarine;
            endInit = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

      
        // Шкала відносної важливості, ця функція рахує обернені величини чисел.
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (endInit)
            {
                dataGridView1.Rows[dataGridView1.CurrentCell.ColumnIndex].Cells[dataGridView1.CurrentCell.RowIndex].Value =
                    1/(float.Parse(dataGridView1.CurrentCell.Value.ToString()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                endInit = false;
                //BB для локальних пріоритетів
                for (int i = 0; i < criteriaAmount; i++)
                {
                    float mul = 1;
                    for (int j = 0; j < criteriaAmount; j++)
                    {
                        mul *= float.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    dataGridView1.Rows[i].Cells["BB"].Value = Math.Pow(mul, 1.0 / criteriaAmount);
                }

                //сума колонок
                float sum = 0;
                for (int i = 0; i < criteriaAmount + 1; i++)
                {
                    sum = 0;
                    for (int j = 0; j < criteriaAmount; j++)
                    {
                        sum += float.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                    }
                    dataGridView1.Rows[criteriaAmount].Cells[i].Value = sum;
                }

                //BP для локальних пріоритетів
                for (int i = 0; i < criteriaAmount; i++)
                {
                    dataGridView1.Rows[i].Cells["BP"].Value =
                        float.Parse(dataGridView1.Rows[i].Cells["BB"].Value.ToString()) /
                        float.Parse(dataGridView1.Rows[criteriaAmount].Cells["BB"].Value.ToString());
                }

                //BP сума для локальних пріоритетів
                sum = 0;
                for (int i = 0; i < criteriaAmount; i++)
                {
                    sum += float.Parse(dataGridView1.Rows[i].Cells["BP"].Value.ToString());
                }
                dataGridView1.Rows[criteriaAmount].Cells["BP"].Value = Math.Round(sum, 1);

                //розрахунок лямбдамакс для локальних пріоритетів
                float res = 0;
                for (int i = 0; i < criteriaAmount; i++)
                {
                    res += float.Parse(dataGridView1.Rows[i].Cells["BP"].Value.ToString()) *
                        float.Parse(dataGridView1.Rows[criteriaAmount].Cells[i].Value.ToString());
                }
                label1.Text = $"λ max = {res}";
                label2.Text = $"Відношення Узгодженності = {(res - criteriaAmount) / (criteriaAmount - 1) / CrValues[criteriaAmount] * 100}";

                //збереження даних
                critTable = new float[criteriaAmount + 1, criteriaAmount + 2];
                for (int i = 0; i < criteriaAmount + 1; i++)
                {
                    for (int j = 0; j < criteriaAmount + 2; j++)
                    {
                        critTable[i, j] = float.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                }


                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                endInit = true;
            }
            catch {
                MessageBox.Show("Заповніть усі колонки!!");
            }
        }

        private void smallTablesProcess(int criteriaIndex)
        {
            panel1.Controls.Clear();
            desigionList.Add(new float[itemsAmount + 1, itemsAmount + 2]);
            dataGridView2 = new DataGridView();
            endInit = false;
            
            dataGridView2.Width = 600;
            dataGridView2.Height = 150;
            dataGridView2.AllowUserToAddRows = false;

            dataGridView2.CellValueChanged += (object sender, DataGridViewCellEventArgs e) =>
            {
                if (endInit)
                {
                    dataGridView2.Rows[dataGridView2.CurrentCell.ColumnIndex].Cells[dataGridView2.CurrentCell.RowIndex].Value =
                        1 / (float.Parse(dataGridView2.CurrentCell.Value.ToString()));
                }
            };

            for (int i = 0; i < itemsAmount + 2; i++)
            {
                dataGridView2.Columns.Add($"K{i}", $"K{i}");
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView2.Columns[itemsAmount].HeaderCell.Value = "BB";
            dataGridView2.Columns[itemsAmount].Name = "BB";
            dataGridView2.Columns[itemsAmount + 1].HeaderCell.Value = "BP";
            dataGridView2.Columns[itemsAmount + 1].Name = "BP";
            for (int i = 0; i < itemsAmount + 1; i++)
            {
                dataGridView2.Rows.Add();
            }
            dataGridView2.Columns[itemsAmount].DefaultCellStyle.BackColor = Color.FromArgb(68, 171, 98);
            dataGridView2.Columns[itemsAmount + 1].DefaultCellStyle.BackColor = Color.FromArgb(140, 117, 135);
            dataGridView2.Rows[itemsAmount].DefaultCellStyle.BackColor = Color.Aquamarine;
            for (int i = 0; i < itemsAmount; i++)
            {
                dataGridView2.Rows[i].Cells[i].Value = 1;
            }
            endInit = true;
            panel1.Controls.Add(dataGridView2);

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            endInit = false;
            //BB розрахунок для критеріїв
            for (int i = 0; i < itemsAmount; i++)
            {
                float mul = 1;
                for (int j = 0; j < itemsAmount; j++)
                {
                    mul *= float.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                }
                dataGridView2.Rows[i].Cells["BB"].Value = Math.Pow(mul, 1.0 / itemsAmount);
            }

            //розрахунок суми
            float sum = 0;
            for (int i = 0; i < itemsAmount + 1; i++)
            {
                sum = 0;
                for (int j = 0; j < itemsAmount; j++)
                {
                    sum += float.Parse(dataGridView2.Rows[j].Cells[i].Value.ToString());
                }
                dataGridView2.Rows[itemsAmount].Cells[i].Value = sum;
            }

            //BP для критеріїв
            for (int i = 0; i < itemsAmount; i++)
            {
                dataGridView2.Rows[i].Cells["BP"].Value =
                    float.Parse(dataGridView2.Rows[i].Cells["BB"].Value.ToString()) /
                    float.Parse(dataGridView2.Rows[itemsAmount].Cells["BB"].Value.ToString());
            }

            //BP сума для критеріїв
            sum = 0;
            for (int i = 0; i < itemsAmount; i++)
            {
                sum += float.Parse(dataGridView2.Rows[i].Cells["BP"].Value.ToString());
            }
            dataGridView2.Rows[itemsAmount].Cells["BP"].Value = Math.Round(sum, 1);

            //Розрахунок лямбдамакс для альтернатив
            float res = 0;
            for (int i = 0; i < itemsAmount; i++)
            {
                res += float.Parse(dataGridView2.Rows[i].Cells["BP"].Value.ToString()) *
                    float.Parse(dataGridView2.Rows[itemsAmount].Cells[i].Value.ToString());
            }
            label1.Text = $"λ max(до крит.) = {res}";
            label2.Text = $"Відношення Узгодженності = {(res - itemsAmount) / (itemsAmount - 1) / CrValues[itemsAmount] * 100}";

            //Збереження даних
            for (int i = 0; i < itemsAmount + 1; i++)
            {
                for (int j = 0; j < itemsAmount + 2; j++)
                {
                    desigionList[criteriaCounter][i,j] = float.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                }
            }
            criteriaCounter++;
            if(criteriaCounter == criteriaAmount)
            {
                 button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
            }
        }
        //Виклик функції МПП 
        private void button3_Click(object sender, EventArgs e)
        {
            
                smallTablesProcess(criteriaCounter);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float[] desigion = new float[3];
            for (int i = 0; i < itemsAmount; i++) 
            {
                float sum = 0;
                for (int j = 0; j < criteriaAmount; j++)
                {
                    sum += desigionList[j][i, itemsAmount + 1] * critTable[j, criteriaAmount + 1];
                }
                desigion[i] = sum;
            }
            MessageBox.Show("Результат розрахунків:" + "\n" + desigion[0] + "\t" + desigion[1] + "\t" + desigion[2]);
            MessageBox.Show("Альтернативний варіант: " + desigion.Max().ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "Спочатку заповнюємо таблицю векторів матриці попарних рівнянь,після цього натискаємо на кнопку 'Синтез локальних пріоритетів'.\n Отримавши результат натискаємо кнопку 'МПП для критерію',\n після чого заповнюємо їх своїми даними. По завершенню натискаємо 'Порахувати'. Робити циклічно операцію доки не стане доступною кнопка 'Отримати результат'.",
       "Інструкція",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1);
        }
    }
}
