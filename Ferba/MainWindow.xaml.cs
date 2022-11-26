using Ferba.Tools;
using System;
using System.IO;
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

namespace Ferba
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundManager _bgSound;
        int _tabIndex = 1;
        public MainWindow()
        {
            InitializeComponent();
            //Sound
            _bgSound = new(Properties.Resources.Music, true);
            _bgSound.PlaySound();
        }

        private void ClosePic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();

        }

        private void SoundPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (_bgSound.IsPlaying)
                {
                    _bgSound.StopSound();
                    SoundPic.Source = new BitmapImage(new Uri("./Assets/Images/SoundOn.png", UriKind.Relative));
                }
                else
                {
                    _bgSound.PlaySound();
                    SoundPic.Source = new BitmapImage(new Uri("./Assets/Images/SoundOff.png", UriKind.Relative));
                }
            }
        }


        private void RightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (ItemTabs.SelectedIndex <= ItemTabs.Items.Count)
                    ++ItemTabs.SelectedIndex;

            }

        }

        private void LeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (ItemTabs.SelectedIndex >= 1)
                    --ItemTabs.SelectedIndex;
            }
        }
    }
}
