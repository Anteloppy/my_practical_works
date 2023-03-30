using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Ink;

namespace all_is_painted
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void HandleEsc(Object sender, KeyEventArgs e)
        { if (e.Key == Key.Escape) Close(); }
        public MainWindow()
        {
            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }
        public ColorRGB mcolor { get; set; }
        public Color clr { get; set; }
        bool b2 = false;
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name; //Определяем имя контрола, который покрутили
            double value = slider.Value; // Получаем значение контрола
                                         //В зависимости от выбранного контрола, меняем ту или иную компоненту и переводим ее в тип byte
            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }

            //Задаем значение переменной класса clr 
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            //Устанавливаем фон для контрола Label 
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            // Задаем цвет кисти для контрола InkCanvas
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }
        private void Fivepx_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Width = 5;
            inkCanvas1.DefaultDrawingAttributes.Height = 5;
        }
        private void Tenpx_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Width = 10;
            inkCanvas1.DefaultDrawingAttributes.Height = 10;
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.None;
            string imgPath = @"/file.bmp"; //Куда сохраняется файл
            MemoryStream ms = new MemoryStream();  //Поток памяти :)
            FileStream fs = new FileStream(imgPath, FileMode.Create); //  Поток файла :)

            //rtb - объект класса RenderTargetBitmap
            RenderTargetBitmap bmp = new RenderTargetBitmap(1920, 1080, 96, 96, PixelFormats.Default);
            bmp.Render(inkCanvas1);

            GifBitmapEncoder gifEnc = new GifBitmapEncoder(); //сохраняем в формате GIF
            gifEnc.Frames.Add(BitmapFrame.Create(bmp));
            gifEnc.Save(fs);
            fs.Close();
            MessageBox.Show("Файл сохранен, " + imgPath); //Для информации
        }
        private void Lasso_Click(object sender, RoutedEventArgs e)
        {
            if (b2 == false)
            { b2 = true;
                this.inkCanvas1.EditingMode = InkCanvasEditingMode.Select; }
            else
            { b2 = false;
                this.inkCanvas1.EditingMode = InkCanvasEditingMode.Ink; }
        }
        private void Text_Click(object sender, RoutedEventArgs e)
        {

            //Инициализация контрола tb типа TextBox
            TextBox tb = new TextBox
            {
                Height = 100,
                Width = 50,
                BorderThickness = new Thickness(1),
                BorderBrush = new SolidColorBrush(Color.FromRgb(5, 5, 5)),
                Margin = new Thickness(20, 20, 0, 0)
            };
            //var Pos = Mouse.GetPosition(this);
            //int x = Convert.ToInt32(Pos.X);
            //int y = Convert.ToInt32(Pos.Y);
            //Добавление контрола tb
            this.inkCanvas1.Children.Add(tb);
            //Переключение фокуса на элемент, чтоб можно было сразу ввести текст с клавиатуры
            tb.Focus();
        }
        private void Red_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Red;
            Brush myBrush = new SolidColorBrush(Colors.Red);
            lbl1.Background = myBrush;
        }
        private void Green_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Green;
            Brush myBrush = new SolidColorBrush(Colors.Green);
            lbl1.Background = myBrush;
        }
        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Blue;
            Brush myBrush = new SolidColorBrush(Colors.Blue);
            lbl1.Background = myBrush;
        }
        private void Black_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Black;
            Brush myBrush = new SolidColorBrush(Colors.Black);
            lbl1.Background = myBrush;
        }
        private void White_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.White;
            Brush myBrush = new SolidColorBrush(Colors.White);
            lbl1.Background = myBrush;
        }
        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Yellow;
            Brush myBrush = new SolidColorBrush(Colors.Yellow);
            lbl1.Background = myBrush;
        }
        private void Cian_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Cyan;
            Brush myBrush = new SolidColorBrush(Colors.Cyan);
            lbl1.Background = myBrush;
        }
        private void Pink_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Magenta;
            Brush myBrush = new SolidColorBrush(Colors.Magenta);
            lbl1.Background = myBrush;
        }
    }
    public class ColorRGB
    {
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }
    }
    
}
