using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace Lec6_Task
{
    public partial class Form1 : Form
    {
        _Application excelapp = new _excel.Application();
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-V5POTD0;Initial Catalog=Lec2;Integrated Security=True");
        SqlCommand sqlCommand = null;
        List<Employee> employees;
        OleDbConnection connection;
        OleDbCommand selectCommand, deleteCommand;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }

        bool validNumber(string number)
        {
            Regex rg = new Regex("[0-9]+");
            return rg.IsMatch(number);
        }

        bool validName(string name)
        {
            Regex rg = new Regex("[A-Za-z]+");
            return rg.IsMatch(name);
        }

        bool validAddress(string address)
        {
            Regex rg = new Regex("[0-9]*[A-Za-z]+[0-9]*");
            return rg.IsMatch(address);
        }

        bool validDate(string date)
        {
            Regex rg = new Regex("[0-3]*[0-9](/)[0-1]*[0-9](/)[0-2][0-9][0-9][0-9]");
            return rg.IsMatch(date);
        }

        void WriteXML(string filename)
        {
            XmlWriter writer = XmlWriter.Create(filename);
            writer.WriteStartElement("Employees");
            foreach (Employee employee in CleanList())
            {
                writer.WriteStartElement("Employee");
                writer.WriteAttributeString("ID", employee.ID);
                writer.WriteElementString("Name", employee.Name);
                writer.WriteElementString("Address", employee.Address);
                writer.WriteElementString("Tel", employee.Tel);
                writer.WriteElementString("Date", employee.Date);
                writer.WriteElementString("Salary", employee.Salary);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        List<Employee> CleanList()
        {
            List<Employee> cleanedList = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                Employee employee = new Employee();
                int count = 0, emLines = 0;
                if (!employees[i].Name.Equals("") && validName(employees[i].Name))
                    employee.Name = employees[i].Name;
                else
                    employee.Name = "NULL";
                if (!employees[i].Address.Equals("") && validAddress(employees[i].Address))
                    employee.Address = employees[i].Address;
                else
                    employee.Address = "NULL";
                if (!employees[i].Tel.Equals("") && validNumber(employees[i].Tel))
                    employee.Tel = employees[i].Tel;
                else
                    employee.Tel = "NULL";
                if (!employees[i].Salary.Equals("") && validNumber(employees[i].Salary))
                    employee.Salary = employees[i].Salary;
                else
                    employee.Salary = "0";
                if (!employees[i].Date.Equals("") && validDate(employees[i].Date))
                    employee.Date = employees[i].Date;
                else
                    employee.Date = DateTime.Now.ToString();
                if (!validNumber(employees[0].ID))
                {
                    while (!validNumber(employees[count].ID))
                    {
                        if (!employees[count].Name.Equals("") | !employees[count].Address.Equals("") | !employees[count].Tel.Equals("") | !employees[count].Date.Equals("") | !employees[count].Salary.Equals(""))
                            emLines++;
                        count++;
                    }
                    employees[0].ID = (int.Parse(employees[count].ID) - count + emLines).ToString();
                }
                if (i == 0)
                    employee.ID = employees[i].ID;
                else
                {
                    employees[i].ID = (int.Parse(employees[i - 1].ID) + 1).ToString();
                    employee.ID = employees[i].ID;
                }
                if (!employees[i].Name.Equals("") | !employees[i].Address.Equals("") | !employees[i].Tel.Equals("") | !employees[i].Date.Equals("") | !employees[i].Salary.Equals(""))
                    cleanedList.Add(employee);
            }
            return cleanedList;
        }

        void WriteExcel(string filename)
        {
            List<Employee> ems = CleanList();
            Workbook workbook = excelapp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet sheet = workbook.Worksheets[1];
            sheet.Cells[1, 1] = "ID"; sheet.Cells[1, 2] = "Name"; sheet.Cells[1, 3] = "Address"; sheet.Cells[1, 4] = "Tel"; sheet.Cells[1, 5] = "Date"; sheet.Cells[1, 6] = "Salary";
            for (int i = 2; i <= ems.Count + 1; i++)
            {
                sheet.Cells[i, 1] = ems[i - 2].ID; sheet.Cells[i, 2] = ems[i - 2].Name; sheet.Cells[i, 3] = ems[i - 2].Address; sheet.Cells[i, 4] = ems[i - 2].Tel; sheet.Cells[i, 5] = ems[i - 2].Date; sheet.Cells[i, 6] = ems[i - 2].Salary;
            }
            excelapp.ActiveWorkbook.SaveAs(filename);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            foreach (Employee employee in CleanList())
            {
                dataGridView1.Rows.Add(employee.ID, employee.Name, employee.Address, employee.Tel, employee.Date, employee.Salary);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Save XLSX Files";
            openFileDialog1.DefaultExt = "xlsx";
            openFileDialog1.Filter = "XLSX files (*.xlsx)|*.xlsx|XLS files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=" + openFileDialog1.FileName + ";" + "Extended Properties=\"Excel 12.0;HDR=YES\";");
                selectCommand = new OleDbCommand("select * from [Sheet1$]", connection);

                connection.Open();
                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    employees.Add(new Employee() { ID = reader[0].ToString(), Name = reader[1].ToString(), Address = reader[2].ToString(), Tel = reader[3].ToString(), Date = reader[4].ToString(), Salary = reader[5].ToString() });
                }

                connection.Close();
            }
            WriteExcel(openFileDialog1.FileName);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string query = "";
            foreach (Employee employee in CleanList())
            {
                query += "INSERT INTO Employees (ID, Name, Address, Tel, DoB, Salary) VALUES (" + int.Parse(employee.ID) + ", '" + employee.Name + "', '" + employee.Address + "', '" + employee.Tel + "', CONVERT(DATETIME, '" + employee.Date + "', 102), " + int.Parse(employee.Salary) + ")\n";
            }
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Title = "Save JSON Files";
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(CleanList().ToArray()));
                MessageBox.Show("Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Title = "Save XML Files";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteXML(saveFileDialog1.FileName);
                MessageBox.Show("Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
