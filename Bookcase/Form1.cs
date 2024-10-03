using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookcase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ACCESSConneciton conn = new ACCESSConneciton();

        string status = " ";

        void list()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from Books", conn.connection());
            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            TxtId.Clear();
            TxtName.Clear();
            TxtAuthor.Clear();
            TxtPage.Clear();
            RbNew.Checked = false;
            RbUsed.Checked = false;
            CmbType.SelectedIndex = 0;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand("insert into Books (BookName,BookAuthor,BookType,BookPages,Status) values(@p1,@p2,@p3,@p4,@p5)", conn.connection());
                oleDbCommand.Parameters.AddWithValue("@p1", TxtName.Text);
                oleDbCommand.Parameters.AddWithValue("@p2", TxtAuthor.Text);
                oleDbCommand.Parameters.AddWithValue("@p3", CmbType.Text);
                oleDbCommand.Parameters.AddWithValue("@p4", TxtPage.Text);
                if (LblStatus.Text == "True")
                {

                    oleDbCommand.Parameters.AddWithValue("@p5", status);
                }
                else
                {

                    oleDbCommand.Parameters.AddWithValue("@p5", status);
                }
                oleDbCommand.ExecuteNonQuery();
                list();
                conn.connection().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invaild value");

                throw;
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("update Books set BookName=@p1, BookAuthor=@p2,BookType=@3,BookPages=@p4,Status=@p5 where BookId = @p6", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtAuthor.Text);
                cmd.Parameters.AddWithValue("@p3", CmbType.Text);
                cmd.Parameters.AddWithValue("@p4", TxtPage.Text);
                if (LblStatus.Text == "True")
                {

                    cmd.Parameters.AddWithValue("@p5", status);
                }
                else
                {

                    cmd.Parameters.AddWithValue("@p5", status);
                }
                cmd.Parameters.AddWithValue("@p6", TxtId.Text);
                cmd.ExecuteNonQuery();
                list();
                conn.connection().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invaild value");

                throw;
            }
            
        }

        private void BtnDelate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand("delete from Books where BookId = @p1", conn.connection());
                oleDbCommand.Parameters.AddWithValue("@p1", TxtId.Text);
                oleDbCommand.ExecuteNonQuery();
                list();
                conn.connection().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invaild value for BookId");

                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbType.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtPage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            LblStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (LblStatus.Text == "True")
            {
                RbUsed.Checked = true;
            }
            else
            {
                RbNew.Checked = true;
            }
        }

        private void RbUsed_CheckedChanged(object sender, EventArgs e)
        {
            status = "1";
        }

        private void RbNew_CheckedChanged(object sender, EventArgs e)
        {
            status = "0";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand("select * from Books where BookName = @p1", conn.connection());
                oleDbCommand.Parameters.AddWithValue("@p1", TxtBookName.Text);

                DataTable dt = new DataTable();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
                oleDbDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invaild value");

                throw;
            }
        }

        private void TxtBookName_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand oleDbCommand = new OleDbCommand("select * from Books where  BookName like '%" + TxtBookName.Text + "%'", conn.connection());

            DataTable dt = new DataTable();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}