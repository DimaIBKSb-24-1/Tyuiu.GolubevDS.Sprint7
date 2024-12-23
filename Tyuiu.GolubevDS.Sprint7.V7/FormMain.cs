namespace Tyuiu.GolubevDS.Sprint7.V7;

using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GolubevDS.Sprint7.V7.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    static int rows;
    static int columns;
    static string openFilePath;
    DataService ds = new DataService();

    public static string[,] LoadFromFileData(string filePath)
    {
        string FileData = File.ReadAllText(filePath);

        FileData = FileData.Replace('\n', '\r');
        string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

        rows = lines.Length;
        columns = lines[0].Split(';').Length;

        string[,] arrayValues = new string[rows, columns];

        for (int r = 0; r < rows; r++)
        {
            string[] line_r = lines[r].Split(';');
            for (int c = 0; c < columns; c++)
            {
                arrayValues[r, c] = line_r[c];
            }
        }
        return arrayValues;
    }
    private void groupBoxHelper_GDS_Enter(object sender, EventArgs e)
    {

    }
    private void textBoxMax_GDS_TextChanged(object sender, EventArgs e)
    {
          
    }

    private void FormMain_Load(object sender, EventArgs e)
    {

    }

    private void buttonOpenBase_GDS_Click(object sender, EventArgs e)
    {
        openFileDialogMain_GDS.ShowDialog();
        openFilePath = openFileDialogMain_GDS.FileName;

        string[,] arrayValues = new string[rows, columns];

        arrayValues = LoadFromFileData(openFilePath);


        arrayValues = ds.GetBase(openFilePath);

        buttonViewBase_GDS.Enabled = true;
    }

    private void buttonSave_GDS_Click(object sender, EventArgs e)
    {
        saveFileDialogMain_GDS.FileName = "Home_Base.csv";
        saveFileDialogMain_GDS.InitialDirectory = Directory.GetCurrentDirectory();
        saveFileDialogMain_GDS.ShowDialog();

        string path = saveFileDialogMain_GDS.FileName;

        FileInfo fileInfo = new FileInfo(path);
        bool FileExists = fileInfo.Exists;

        if (FileExists)
        {
            File.Delete(path);
        }

        int rows = dataGridViewBase_GDS.RowCount;
        int columns = dataGridViewBase_GDS.ColumnCount;

        string str = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    str = str + dataGridViewBase_GDS.Rows[i].Cells[j].Value + ";";
                }
                else
                {
                    str = str + dataGridViewBase_GDS.Rows[i].Cells[j].Value;
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }
    }

    private void buttonDelete_GDS_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridViewBase_GDS.CurrentRow.Index >= 0)
            {
                int a = dataGridViewBase_GDS.CurrentRow.Index;
                dataGridViewBase_GDS.Rows.Remove(dataGridViewBase_GDS.Rows[a]);
                if (dataGridViewBase_GDS.Rows.Count == 1)
                {
                    dataGridViewBase_GDS.Rows.Clear();
                }
            }
            if (dataGridViewBase_GDS.Rows.Count <= 1)
            {
                buttonDelete_GDS.Enabled = false;
                buttonFind_GDS.Enabled = false;
            }
            if (dataGridViewBase_GDS.Rows.Count > 1)
            {
                buttonDelete_GDS.Enabled = true;
            }

        }
        catch
        {
            MessageBox.Show("Ошибка при удалении комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonViewBase_GDS_Click(object sender, EventArgs e)
    {
        dataGridViewBase_GDS.ColumnCount = columns;
        dataGridViewBase_GDS.RowCount = rows;


        dataGridViewBase_GDS.Rows[0].ReadOnly = true;
        dataGridViewBase_GDS.Columns[0].ReadOnly = true;

        string[,] arrayValues = new string[rows, columns];
        arrayValues = LoadFromFileData(openFilePath);

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                dataGridViewBase_GDS.Rows[r].Cells[c].Value = arrayValues[r, c];
            }
        }

        arrayValues = ds.GetBase(openFilePath);

        buttonFind_GDS.Enabled = true;
        buttonDelete_GDS.Enabled = true;
        buttonSave_GDS.Enabled = true;
        buttonArea_GDS.Enabled = true;
        buttonKids_GDS.Enabled = true;
        buttonEdit_GDS.Enabled = true;
        buttonAdd_GDS.Enabled = true;
        buttonAreaGr_GDS.Enabled = true;
        buttonMin_GDS.Enabled = true;
        buttonAverage_GDS.Enabled = true;
        buttonMax_GDS.Enabled = true;
        buttonFilterCansel_GDS.Enabled = true;
        buttonFilter_GDS.Enabled = true;
        textBoxFind_GDS.Enabled = true;
        textBoxMax_GDS.Enabled = true;
        textBoxMin_GDS.Enabled = true;
        textBoxAverage_GDS.Enabled = true;
        comboBoxFilter_GDS.Enabled = true;


    }

    private void buttonFind_GDS_Click(object sender, EventArgs e)
    {
        try
        {
            for (int i = 0; i < dataGridViewBase_GDS.RowCount; i++)
            {
                dataGridViewBase_GDS.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewBase_GDS.ColumnCount; j++)
                    if (dataGridViewBase_GDS.Rows[i].Cells[j].Value != null)
                        if (dataGridViewBase_GDS.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind_GDS.Text))
                        {
                            dataGridViewBase_GDS.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        catch
        {
            MessageBox.Show("Ошибка поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonArea_GDS_Click(object sender, EventArgs e)
    {
        dataGridViewBase_GDS.Sort(dataGridViewBase_GDS.Columns[3], ListSortDirection.Descending);
    }

    private void buttonKids_GDS_Click(object sender, EventArgs e)
    {
        dataGridViewBase_GDS.Sort(dataGridViewBase_GDS.Columns[4], ListSortDirection.Descending);
    }

    private void buttonAreaGr_GDS_Click(object sender, EventArgs e)
    {
        chartGr_GDS.Series.Clear();
        Series series = new Series();
        series.ChartType = SeriesChartType.Area;


        foreach (DataGridViewRow row in dataGridViewBase_GDS.Rows)
        {

            double area = Convert.ToDouble(row.Cells[2].Value);
            int roomCount = Convert.ToInt32(row.Cells[3].Value);
            series.Points.AddXY(roomCount, area);
        }
        chartGr_GDS.Series.Add(series);
        chartGr_GDS.Show();
    }

    private void buttonEdit_GDS_Click(object sender, EventArgs e)
    {
        try
        {
            int a = dataGridViewBase_GDS.CurrentRow.Index;
            FormEdit fed = new FormEdit(this);
            fed.textBoxEntranceEnter_GDS.Text = dataGridViewBase_GDS.Rows[a].Cells[0].Value.ToString();
            fed.textBoxFlatEnter_GDS.Text = dataGridViewBase_GDS.Rows[a].Cells[1].Value.ToString();
            fed.textBoxRoomsEnter_GDS.Text = dataGridViewBase_GDS.Rows[a].Cells[2].Value.ToString();
            fed.textBoxSquareEnter_GDS.Text = dataGridViewBase_GDS.Rows[a].Cells[3].Value.ToString();
            fed.textBoxKidsEnter_GDS.Text = dataGridViewBase_GDS.Rows[a].Cells[4].Value.ToString();
            fed.textBoxDebtEnter_GDS.Text = dataGridViewBase_GDS.Rows[a].Cells[5].Value.ToString();

            fed.ShowDialog();
        }
        catch
        {
            MessageBox.Show("Ошибка при редактировании комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonMin_GDS_Click(object sender, EventArgs e)
    {
        double minValue = double.MaxValue;
        foreach (DataGridViewRow row in dataGridViewBase_GDS.Rows)
        {
            if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
            {
                double cellValue = Convert.ToDouble(row.Cells[3].Value);
                if (cellValue < minValue)
                {
                    minValue = cellValue;
                }
            }
        }
        textBoxMin_GDS.Text = minValue.ToString();
    }

    private void buttonAverage_GDS_Click(object sender, EventArgs e)
    {
        double sum = 0;
        int count = 0;

        foreach (DataGridViewRow row in dataGridViewBase_GDS.Rows)
        {
            // Проверка, что значение в ячейке не является пустым или нулевым
            if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
            {
                double cellValue = Convert.ToDouble(row.Cells[3].Value);
                sum += cellValue;
                count++;
            }
        }

        double average = sum / count;
        textBoxAverage_GDS.Text = Convert.ToString(Math.Round(average, 2));
    }

    private void buttonMax_GDS_Click(object sender, EventArgs e)
    {
        double maxValue = double.MinValue;
        foreach (DataGridViewRow row in dataGridViewBase_GDS.Rows)
        {
            if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
            {
                double cellValue = Convert.ToDouble(row.Cells[3].Value);
                if (cellValue > maxValue)
                {
                    maxValue = cellValue;
                }
            }
        }
        textBoxMax_GDS.Text = maxValue.ToString();
    }

    private void buttonFilter_GDS_Click(object sender, EventArgs e)
    {
        string filterValue = comboBoxFilter_GDS.SelectedItem?.ToString();   
        foreach (DataGridViewRow row in dataGridViewBase_GDS.Rows)
        {
             
            if (row.Cells[5].Value != null && int.TryParse(row.Cells[5].Value.ToString(), out int cellValue))
            {
                 
                if (cellValue == 0)
                {
                    
                    row.Cells[5].Value = "Нету"; 
                    row.Visible = true; 
                }
                 
                else if (cellValue > 0)
                {
                      
                    row.Cells[5].Value = cellValue;   
                    row.Visible = true;   
                }
                else
                {
                    row.Visible = false;   
                }
            }
            else
            {
                row.Visible = false;   
            }
        }
    }

    private void buttonFilterCansel_GDS_Click(object sender, EventArgs e)
    {
        string filterValue = comboBoxFilter_GDS.SelectedItem.ToString();
        foreach (DataGridViewRow row in dataGridViewBase_GDS.Rows)
        {
            string cellValue = row.Cells[5].Value.ToString();
            if (cellValue == filterValue)
            {
                row.Visible = true;
            }
            else
            {
                row.Visible = true;
            }
        }
    }

    private void dataGridViewBase_GDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void buttonHelp_GDS_Click(object sender, EventArgs e)
    {
        FormHelp formHelp = new FormHelp();
        formHelp.ShowDialog();
    }

    private void buttonAdd_GDS_Click(object sender, EventArgs e)
    {
        FormAdd formAdd = new FormAdd(this);
        formAdd.ShowDialog();
    }
}



