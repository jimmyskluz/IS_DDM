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
using DataLayer;
using DataLayer.TableDataGateway;
using DomainLayer.DomainModelActiveRecord;

namespace PresentationLayer
{
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }

        string c_name;
        char c_level;
        int c_capacity;
        int c_class;
        private void create_Click(object sender, EventArgs e)
        {
            c_name = name.Text;
            c_level = char.Parse(level.Text);
            string c_lector = lector.Text;
            c_capacity = int.Parse(capacity.Text);
            c_class = int.Parse(room.Text);

            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            CourseActiveRecord.AddCourse(c_name, c_level, c_capacity, c_lector, c_class, connection);
        }

        private void validCouse_Click(object sender, EventArgs e)
        {
            c_name = name.Text;
            c_level = char.Parse(level.Text);
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            if (CourseActiveRecord.CourseIsValid(c_name, c_level, connection))
            {
                name.BackColor = Color.Green;
                level.BackColor = Color.Green;
                name.ForeColor = Color.White;
                level.ForeColor = Color.White;
            }
            else
                MessageBox.Show("spatne");

        }

        private void validClassroom_Click(object sender, EventArgs e)
        {
            c_capacity = int.Parse(capacity.Text);
            c_class = int.Parse(room.Text);
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            if (CourseActiveRecord.ClassroomIsValid(c_capacity, c_class, connection))
            {
                capacity.BackColor = Color.Green;
                room.BackColor = Color.Green;
                capacity.ForeColor = Color.White;
                room.ForeColor = Color.White;
            }
            else
            {
                Classrooms cr = new Classrooms(c_capacity);
                cr.ShowDialog();
            }
        }
    }
}
