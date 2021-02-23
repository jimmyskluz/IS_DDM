using DataLayer;
using DataLayer.TableDataGateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            updateCourses();
        }

        DataTable courses;
        private void showCourses(object sender, EventArgs e)
        {


        }

        private void updateCourses(string x = null)
        {
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            courses = CourseTableGateway.Find(connection);
            string level;
            DataTable lector;
            foreach (DataRow row in courses.Rows)
            {
                level = row["difficulty"].ToString() == "Z"?  "Zacatecnici" :  "Pokrocili";
                lector = LectorTableGateway.FindByID((int)row["lector_idlector"], connection);
                string[] r = { row["course_name"].ToString(), lector.Rows[0]["first_name"].ToString() + " " + lector.Rows[0]["last_name"].ToString(), level };
                listView1.Items.Add(new ListViewItem(r));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vloz cas !");
        }

        private void createCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCourse cc = new CreateCourse();
            cc.ShowDialog();
            this.Close();
        }
        /*            SqlConnection connection = DBConnector.GetInstance().GetConnection();

courses = LectorTableGateway.Find(connection);
BindingSource bindingSource = new BindingSource
{
DataSource = courses
};
listBox1.DataSource = bindingSource;
listBox1.DisplayMember = "first_name";
*/
    }
}
