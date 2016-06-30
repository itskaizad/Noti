using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Noti
{
    /// <summary>
    /// Interaction logic for ReminderPage.xaml
    /// </summary>
    public partial class ReminderPage : Page
    {
        private ObservableCollection<Reminder> ReminderList;

        public ReminderPage()
        {
            InitializeComponent();
            ReminderList = new ObservableCollection<Reminder>();

            //test code
            ReminderList.Add(new Reminder());
            ReminderList.Add(new Reminder());
            ReminderList.Add(new Reminder());

            ReminderListBox.ItemsSource = ReminderList;
        }

        private void ReminderListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
