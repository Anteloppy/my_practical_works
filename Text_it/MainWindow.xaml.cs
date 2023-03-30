using Microsoft.Win32;
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

namespace Text_it
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        }
        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
                rtb.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
        }
        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        { rtb.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text); }
        private void rtb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = rtb.Selection.GetPropertyValue(Inline.FontWeightProperty);
            bBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = rtb.Selection.GetPropertyValue(Inline.FontStyleProperty);
            bItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = rtb.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            bUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = rtb.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = rtb.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();
        }
        private void Open_Executed(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }
        }
        private void Save_Executed(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "TXT (*.txt)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }
        private void Line_Spacing (object sender, RoutedEventArgs e)
        {
            par.LineHeight++;
        }
        private void Line_Doesnt_Spacing(object sender, RoutedEventArgs e)
        {
            if (par.LineHeight == 1) { }
            else par.LineHeight--;
        }
        private void BlackText(object sender, RoutedEventArgs e)
        {
            TextSelection selectedText = rtb.Selection;
            if (selectedText != null && !selectedText.IsEmpty)
            { selectedText.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black); }
        }
        private void RedText(object sender, RoutedEventArgs e)
        {
            TextSelection selectedText = rtb.Selection;
            if (selectedText != null && !selectedText.IsEmpty)
            { selectedText.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red); }
        }
        private void GreenText(object sender, RoutedEventArgs e)
        {
            TextSelection selectedText = rtb.Selection;
            if (selectedText != null && !selectedText.IsEmpty)
            { selectedText.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.LawnGreen); }
        }
        private void BlueText(object sender, RoutedEventArgs e)
        {
            TextSelection selectedText = rtb.Selection;
            if (selectedText != null && !selectedText.IsEmpty)
            { selectedText.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue); }
        }
    }
}
