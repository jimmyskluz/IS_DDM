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
using System.Diagnostics;


namespace PresentationLayer
{
    public partial class Classrooms : Form
    {
        ClassroomActiveRecord classrooms = null;

        public Classrooms(int capacity)
        {
            InitializeComponent();
            /*
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            classrooms =  ClassroomActiveRecord.ShowRooms(capacity, connection);
            Debug.WriteLine(classrooms.capacity);
            */
        }
    }
}
