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

/**
2                                    _ooOoo_
3                                   o8888888o
4                                   88" . "88
5                                   (| -_- |)
6                                    O\ = /O
7                                ____/`---'\____
8                              .   ' \\| |// `.
9                               / \\||| : |||// \
10                             / _||||| -:- |||||- \
11                               | | \\\ - /// | |
12                             | \_| ''\---/'' | |
13                              \ .-\__ `-` ___/-. /
14                           ___`. .' /--.--\ `. . __
15                        ."" '< `.___\_<|>_/___.' >'"".
16                       | | : `- \`.;`\ _ /`;.`/ - ` : | |
17                         \ \ `-. \_ __\ /__ _/ .-` / /
18                 ======`-.____`-.___\_____/___.-`____.-'======
19                                    `=---='
20                 .............................................
21                          佛祖保佑             永无BUG
22                  佛曰:
23                          写字楼里写字间，写字间里程序员；
24                          程序人员写程序，又拿程序换酒钱。
25                          酒醒只在网上坐，酒醉还来网下眠；
26                          酒醉酒醒日复日，网上网下年复年。
27                          但愿老死电脑间，不愿鞠躬老板前；
28                          奔驰宝马贵者趣，公交自行程序员。
29                          别人笑我忒疯癫，我笑自己命太贱；
30                          不见满街漂亮妹，哪个归得程序员？
31               __------__
32             /~          ~\                       ,%%%%%%%%,
33            |    //^\\//^\|                     ,%%/\%%%%/\%%
34          /~~\  ||  o| |o|:~\                  ,%%%\c "" J/%%%
35         | |6   ||___|_|_||:|         %.       %%%%/ o  o \%%%
36          \__.  /      o  \/'         `%%.     %%%%    _  |%%%
37           |   (       O   )           `%%     `%%%%(__Y__)%%'
38  /~~~~\    `\  \         /            //       ;%%%%`\-/%%%'
39| |~~\ |     )  ~------~`\            ((       /  `%%%%%%%'
40/' |  | |   /     ____ /~~~)\          \\    .'          |
41(_/'   | | |     /'    |    ( |         \\  /       \  | |
42      | | |     \    /   __)/ \          \\/         ) | |
43      \  \ \      \/    /' \   `\         \         /_ | |__
44        \  \|\        /   | |\___|        (___________)))))))  攻城狮
45          \ |  \____/     | |
46          /^~  \        _/ <
47         |  |         \       \                神兽保佑，通通AC
48         |  | \        \        \
49         -^-\  \       |         )
50              `\_______/^\______/   程序猿
51*/


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
