using System.ComponentModel;
using System.Data;

namespace EmployeeInfos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _code;
        private string _firstName;
        private string _lastName;

        public Form1(int code, string firstName, string lastName, IContainer components, TextBox textBox1, TextBox textBox2, TextBox textBox3, Button btnCountAll, Button btnCountFemale, Button btnCountMale, RadioButton radiobtnFemale, RadioButton radiobtnMale, Label lblCode, Label lblFirstName, Label lblLastName, DataGridView dataGridView1, DataGridView dataGridView2)
        {
            _code = code;
            _firstName = firstName;
            _lastName = lastName;
            this.components = components;
            this.txtCode = textBox1;
            this.txtFirstName = textBox2;
            this.txtLastName = textBox3;
            this.btnCountAll = btnCountAll;
            this.btnCountFemale = btnCountFemale;
            this.btnCountMale = btnCountMale;
            this.radiobtnFemale = radiobtnFemale;
            this.radiobtnMale = radiobtnMale;
            this.lblCode = lblCode;
            this.lblFirstName = lblFirstName;
            this.lblLastName = lblLastName;
            this.dataGridViewFemale = dataGridView1;
            this.dataGridViewMale = dataGridView2;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        DataTable femaleTable = new DataTable();
        DataTable maleTable = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            femaleTable.Rows.Add(txtCode.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void radiobtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnFemale.Checked)
            {
                radiobtnMale.Checked = false;
            }
        }

        private void radiobtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnMale.Checked)
            {
                radiobtnFemale.Checked = false;
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radiobtnFemale.Checked == true)
            {
                _code = Convert.ToInt32(txtCode.Text);
                _firstName = txtFirstName.Text;
                _lastName = txtLastName.Text;

                dataGridViewFemale.Rows.Add(_code, _firstName, _lastName);


                txtCode.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
            }
            else
            {
                _code = Convert.ToInt32(txtCode.Text);
                _firstName = txtFirstName.Text;
                _lastName = txtLastName.Text;

                dataGridViewMale.Rows.Add(_code, _firstName, _lastName);

                txtCode.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
            }
            txtCode.Focus();
            radiobtnFemale.Checked = false;
            radiobtnMale.Checked = false;

        }

        private void btnCountMale_Click(object sender, EventArgs e)
        {
            string messageMale = string.Empty;
            foreach (DataGridViewRow item in dataGridViewMale.Rows)
            {
                if (!item.IsNewRow)
                {
                    messageMale += $"Code: {item.Cells[0].Value}, First Name: {item.Cells[1].Value}, Last Name: {item.Cells[2].Value}.\n";
                }
            }
            MessageBox.Show(Convert.ToString(messageMale));
            txtCode.Focus();
            radiobtnFemale.Checked = false;
            radiobtnMale.Checked = false;
        }

        private void btnCountFemale_Click(object sender, EventArgs e)
        {
            string messageFemale = string.Empty;
            foreach (DataGridViewRow item in dataGridViewFemale.Rows)
            {
                if (!item.IsNewRow)
                {
                    messageFemale += $"Code: {item.Cells[0].Value}, First Name: {item.Cells[1].Value}, Last Name: {item.Cells[2].Value}.\n";
                }
            }
            MessageBox.Show(Convert.ToString(messageFemale));
            txtCode.Focus(); 
            radiobtnFemale.Checked = false;
            radiobtnMale.Checked = false;

        }

        private void dataGridViewMale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCountAll_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (DataGridViewRow item in dataGridViewFemale.Rows)
            {
                if (!item.IsNewRow)
                {
                    message += $"Code: {item.Cells[0].Value}, First Name: {item.Cells[1].Value}, Last Name: {item.Cells[2].Value}.\n";
                }
            }
          

            foreach (DataGridViewRow item in dataGridViewMale.Rows)
            {
                if (!item.IsNewRow)
                {
                    message += $"Code: {item.Cells[0].Value}, First Name: {item.Cells[1].Value}, Last Name: {item.Cells[2].Value}.\n";
                }
            }
            MessageBox.Show(message);


            txtCode.Focus();
            radiobtnFemale.Checked = false;
            radiobtnMale.Checked = false;

        }
    }
}
