using System;
using System.Collections.Generic;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Function()
        {
            using (AppContext db = new AppContext())
            {
                Student student = new Student("Bradali", "Pitov", new DateTime(1963, 12, 18));
                db.Students.Add(student);
                db.SaveChanges();
            }

            using (AppContext db = new AppContext())
            {
                var student = db.Students.FirstOrDefault(x => x.Id == 1);
                MessageBox.Show(student.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) { Function(); }

    }
}
