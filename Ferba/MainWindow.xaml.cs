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
using Ferba.Data;
using System.IO.Packaging;
using System.Media;

namespace Ferba
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundManager _bgSound;
        public Lazy<List<Items>> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //Lazy Init
            Items = new Lazy<List<Items>>(Data.Data.GetData());
            DataContext = this;
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
            {
                try
                {
                    DragMove();
                }
                catch { }
            }
                

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

        private void AnimalBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 1;
            _bgSound.StopSound();
        }

        private void HomePic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 0;
            _bgSound.PlaySound();

        }

        private void SoundPlay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var index = AnimalTabItems.SelectedIndex;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }

        }
        private void AnimalLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (AnimalTabItems.SelectedIndex >= 1)
                    --AnimalTabItems.SelectedIndex;
            }
        }

        private void AnimalRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (AnimalTabItems.SelectedIndex <= AnimalTabItems.Items.Count)
                    ++AnimalTabItems.SelectedIndex;

            }

        }

        private void NumbersBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ClothesBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 2;
            _bgSound.StopSound();
        }

        private void NatureBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 3;
            _bgSound.StopSound();
        }

        private void NumbersBarPic_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 4;
            _bgSound.StopSound();
        }

        private void AlphabetsBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 5;
            _bgSound.StopSound();
        }

        private void ColorsBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 6;
            _bgSound.StopSound();
        }

        private void BodyBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 7;
            _bgSound.StopSound();
        }

        private void MomentsBarPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTabs.SelectedIndex = 8;
            _bgSound.StopSound();
        }

        private void SoundPlayClothes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var index = ClothesTabItems.SelectedIndex + 9;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }
        }

        private void ClothesRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (ClothesTabItems.SelectedIndex <= ClothesTabItems.Items.Count)
                    ++ClothesTabItems.SelectedIndex;

            }
        }

        private void ClothesLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (ClothesTabItems.SelectedIndex >= 1)
                    --ClothesTabItems.SelectedIndex;
            }
        }

        private void NatureLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (NatureTabItems.SelectedIndex >= 1)
                    --NatureTabItems.SelectedIndex;
            }
        }

        private void NatureRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (NatureTabItems.SelectedIndex <= NatureTabItems.Items.Count)
                    ++NatureTabItems.SelectedIndex;

            }
        }

        private void SoundPlayNature_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //bgora index
            var index = NatureTabItems.SelectedIndex + 26;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }
        }

        private void NumbersLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (NumbersTabItems.SelectedIndex >= 1)
                    --NumbersTabItems.SelectedIndex;
            }
        }

        private void NumbersRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (NumbersTabItems.SelectedIndex <= NumbersTabItems.Items.Count)
                    ++NumbersTabItems.SelectedIndex;

            }
        }

        private void SoundPlayNumbers_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var index = NumbersTabItems.SelectedIndex + 16;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }
        }

        private void ColorsLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (ColorsTabItems.SelectedIndex >= 1)
                    --ColorsTabItems.SelectedIndex;
            }
        }

        private void ColorsRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (ColorsTabItems.SelectedIndex <= ColorsTabItems.Items.Count)
                    ++ColorsTabItems.SelectedIndex;

            }
        }

        private void SoundPlayColors_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var index = ColorsTabItems.SelectedIndex + 35;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }
        }

        private void BodyLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (BodyTabItems.SelectedIndex >= 1)
                    --BodyTabItems.SelectedIndex;
            }
        }

        private void BodyRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (BodyTabItems.SelectedIndex <= BodyTabItems.Items.Count)
                    ++BodyTabItems.SelectedIndex;

            }
        }

        private void SoundPlayBody_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var index = BodyTabItems.SelectedIndex + 40;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }
        }

        private void MomentsLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (MomentsTabItems.SelectedIndex >= 1)
                    --MomentsTabItems.SelectedIndex;
            }
        }

        private void MomentsRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (MomentsTabItems.SelectedIndex <= MomentsTabItems.Items.Count)
                    ++MomentsTabItems.SelectedIndex;

            }
        }

        private void SoundPlayMoments_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var index = MomentsTabItems.SelectedIndex + 45;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }
        }

        private void AlphabetsLeftArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (AlphabetsTabItems.SelectedIndex >= 1)
                    --AlphabetsTabItems.SelectedIndex;
            }
        }

        private void AlphabetsRightArrowPic_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (e.ChangedButton == MouseButton.Left)
            {
                if (AlphabetsTabItems.SelectedIndex <= AlphabetsTabItems.Items.Count)
                    ++AlphabetsTabItems.SelectedIndex;

            }
        }

        private void SoundPlayAlphabets_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var index = AlphabetsTabItems.SelectedIndex + 49;
            var path = Items.Value[index].Sound;
            using (SoundPlayer sound = new(path))
            {
                sound.Stream.Position = 0;
                sound.Play();
            }
        }
    }
}
