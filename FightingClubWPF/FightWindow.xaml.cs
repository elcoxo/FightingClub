using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Moq;

namespace FightingClubWPF
{
    /// <summary>
    /// Interaction logic for FightWindow.xaml
    /// </summary>
    public partial class FightWindow : Window
    {
        int test = 0;
        int cnt = 0;
        Entity Player = new Entity();
        Level level = new Level(3);
        public FightWindow(Entity sender)
        {
            InitializeComponent();
            OutputConsole wr = new OutputConsole(ConsoleList);
            Player.CopyData(sender);
        }

        private void ConsoleList_Loaded(object sender, RoutedEventArgs e)
        {
            OutputConsole wr = new OutputConsole(ConsoleList);
            var listBox = (ListBox)sender;

            var scrollViewer = FindScrollViewer(listBox);

            if (scrollViewer != null)
            {
                scrollViewer.ScrollChanged += (o, args) =>
                {
                    if (args.ExtentHeightChange > 0)
                        scrollViewer.ScrollToBottom();
                };
            }

            wr.Write("test");

        }


        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        private async void ActionBTN_Click(object sender, RoutedEventArgs e)
        {
            OutputConsole wr = new OutputConsole(ConsoleList);
            AllocConsole();

            wr.Write(Player.name+": *кликает*");
            wr.Write(Player.getItems().Count == 0 ? "No avaliable items" : Player.getItems().ToString());
           
            while (level.numLevel != 0)
            {
                Thread.Sleep(4000);
                Console.WriteLine(level.numLevel);
                
                level.numLevel--;
            }
            /*foreach (var item in Player.getItems())
            {
                wr.Write(item.ToString() ?? "NullItem");
            }*/

        }

        // Search for ScrollViewer, breadth-first
        private static ScrollViewer FindScrollViewer(DependencyObject root)
        {
            var queue = new Queue<DependencyObject>(new[] { root });

            do
            {
                var item = queue.Dequeue();

                if (item is ScrollViewer)
                    return (ScrollViewer)item;

                for (var i = 0; i < VisualTreeHelper.GetChildrenCount(item); i++)
                    queue.Enqueue(VisualTreeHelper.GetChild(item, i));
            } while (queue.Count > 0);

            return null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OutputConsole wr = new OutputConsole(ConsoleList);

        }

        private void SelectBTN_Click(object sender, RoutedEventArgs e)
        {
            OutputConsole wr = new OutputConsole(ConsoleList);

            Mock<IWeapon> mock = new Mock<IWeapon>();

            mock.Setup(r => r.GetWeapon(1)).Returns(Weapon.testListWeapon[0]);
            mock.Setup(r => r.GetWeapon(It.Is<int>(v => v > 1))).Returns(Weapon.testListWeapon[2]);

            IWeapon testmoq = mock.Object;
            Weapon w0 = testmoq.GetWeapon(0);
            Weapon w1 = testmoq.GetWeapon(1);
            Weapon w2 = testmoq.GetWeapon(2);
            Weapon w3 = testmoq.GetWeapon(3);

            
            wr.Write("w1: " + w1.Name);
            wr.Write("w2: " + w2.Name);
            wr.Write("w3: " + w3.Name);
        }
    }
}
