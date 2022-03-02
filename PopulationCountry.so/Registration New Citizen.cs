using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace PopulationCountry.so
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
        private void textNew_Click(object sender, EventArgs e)
        {
            MyConnection obj = new MyConnection();
            obj.Con.Open();

            obj.quy ="select case when max (ID) is null then  1 else max (ID)+1 end From Popolation1 ";

            obj.cmd=new SqlCommand(obj.quy, obj.Con);
            int x = System.Convert.ToInt32(obj.cmd.ExecuteScalar());
            textId.Text=x.ToString();
            obj.Con.Close();
            textName.Focus();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyConnection obj = new MyConnection();
            obj.Con.Open();
            obj.quy ="insert into Popolation1 values (@Id,@Name ,@Gender,@PersonalColor,@Age,@Phone,@Address)";
            obj.cmd= new SqlCommand(obj.quy, obj.Con);
            obj.cmd.Parameters.AddWithValue("@Id", textId.Text);
            obj.cmd.Parameters.AddWithValue("@Name", textName.Text);
            obj.cmd.Parameters.AddWithValue("@Gender", comboGender.Text);
            obj.cmd.Parameters.AddWithValue("@PersonalColor", comboBoxColor.Text);
            obj.cmd.Parameters.AddWithValue("@Age", textAge.Text);
            
            obj.cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
            obj.cmd.Parameters.AddWithValue("@Address", textAddress.Text);
            obj.cmd.ExecuteNonQuery();
            obj.Con.Close();
            FillDta();

            MessageBox.Show("New Citizen Added With Somali Population1");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillDta();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textLenght_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textGender_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label0_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FillDta();
        }

        void FillDta()
        {
            MyConnection obj = new MyConnection();
            obj.Con.Open();
            obj.quy="select * from Popolation1 order by Id";
            obj.cmd=new SqlCommand(obj.quy, obj.Con);
            obj.dr=obj.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(obj.dr);
            dataGridView1.AutoGenerateColumns=true;
            dataGridView1.DataSource=dt;
            dataGridView1.Refresh();
            obj.Con.Close();


        }
        void clear()
        {
            textId.Text=("");
            textName.Text=("");
            comboGender.SelectedIndex=-1;
            comboBoxColor.Text=("");
            textAge.Text=("");
            
            textPhone.Text=("");
            textAddress.Text=("");


        }





        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dataGridView1.RowCount > 1)
            {
                textId.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textName.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboGender.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBoxColor.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textAge.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
                
                textPhone.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textAddress.Text=dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MyConnection obj =new  MyConnection();
            obj.Con.Open();


            obj.quy="update Popolation1 set Name= @Name, Gender= @Gender, PersonalColor= @PersonalColor, Age= @Age, Phone= @Phone, Address= @Address where Id= @Id";
            obj.cmd=new SqlCommand(obj.quy, obj.Con);
            obj.cmd.Parameters.AddWithValue("@Id",textId.Text);
            obj.cmd.Parameters.AddWithValue("@Name",textName.Text);
            obj.cmd.Parameters.AddWithValue("@Gender",comboGender.Text);
            obj.cmd.Parameters.AddWithValue("@PersonalColor", comboBoxColor.Text);
            obj.cmd.Parameters.AddWithValue("@Age",textAge.Text);
           
            obj.cmd.Parameters.AddWithValue("@Phone",textPhone.Text);
            obj.cmd.Parameters.AddWithValue("@Address",textAddress.Text);
            obj.cmd.ExecuteNonQuery();
            obj.Con.Close();
            MessageBox.Show("Updated !");
            FillDta();
            clear();





        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        
          
        {

        }

        private void comboGender_Click(object sender, EventArgs e)
        {

        }

        private void comboGender_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            MyConnection obj = new MyConnection();
            obj.Con.Open();
            obj.quy="delete from Popolation1 where Id='"+textId.Text+"'";
                obj.cmd=new SqlCommand(obj.quy, obj.Con);
            obj.cmd.ExecuteNonQuery();
            obj.Con.Close();
            MessageBox.Show("Deleted ");
            clear();
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyConnection obj = new MyConnection();
            obj.Con.Open();
            obj.quy="select * from Popolation1 where Name=@Name";
            obj.cmd.Parameters.AddWithValue("Name", char.Parse(textName.Text));
          
            obj.cmd = new System.Data.SqlClient.SqlCommand(obj.quy, obj.Con);
            DataTable dt = new DataTable();
            dt.Load(obj.dr);
            FillDta();
            dataGridView1.DataSource= dt;


        }
    }
}
