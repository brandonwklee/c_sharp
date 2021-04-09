using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace gp_surgery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection SQLConnection;
        SqlDataAdapter dataAdapter;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["gp_surgery.Properties.Settings.gp_surgeryConnectionString"].ConnectionString;
            SQLConnection = new SqlConnection(connectionString);
            showDefaultData();

        }
        private void showDefaultData()
        {
            string query = "SELECT * from patient_information";
            dataAdapter = new SqlDataAdapter(query, SQLConnection);

            using (dataAdapter)
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                infoTable.DisplayMemberPath = "Forename";
                infoTable.SelectedValuePath = "Id";
                infoTable.ItemsSource = table.DefaultView;
            }
        }
    }
}