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

namespace ProceduarColorGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double middarkslidervalue { get; set; }
        double darkslidervalue { get; set; }
        double extremedarkslidervalue { get; set; }

        double midlightslidervalue { get; set; }
        double lightslidervalue { get; set; }
        double extremelightslidervalue { get; set; }



        public MainWindow()
        {
            InitializeComponent();

            middarkslider.Value = 0.25;
            darkslider.Value = 0.5;
            extremedarkslider.Value = 0.75;
            midlightslider.Value = 0.25;
            lightslider.Value = 0.5;
            extremelightslider.Value = 0.75;

        }

        private void updatevalues()
        {
            middarkslidervalue = middarkslider.Value;
            darkslidervalue = darkslider.Value;
            extremedarkslidervalue = extremedarkslider.Value;

            midlightslidervalue = midlightslider.Value;
            lightslidervalue = lightslider.Value;
            extremelightslidervalue = extremelightslider.Value;

            if (slider.Value <= 1.66666666667)
            {
                double convertedrgb = slider.Value / 1.66666666667 * 255;
                int rgbval = (int)Math.Round(convertedrgb);
                Red.Text = "255";
                Green.Text = rgbval.ToString();
                Blue.Text = "0";

                int red = 255;
                int green = rgbval;
                int blue = 0;

                Color bg = Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue));
                Color middarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * middarkslidervalue)), Convert.ToByte(green - ((green - 0) * middarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * middarkslidervalue)));
                Color darkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * darkslidervalue)), Convert.ToByte(green - ((green - 0) * darkslidervalue)), Convert.ToByte(blue - ((blue - 0) * darkslidervalue)));
                Color extremedarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * extremedarkslidervalue)), Convert.ToByte(green - ((green - 0) * extremedarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * extremedarkslidervalue)));

                Color midlightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * midlightslidervalue)), Convert.ToByte(green + ((255 - green) * midlightslidervalue)), Convert.ToByte(blue + ((255 - blue) * midlightslidervalue)));
                Color lightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * lightslidervalue)), Convert.ToByte(green + ((255 - green) * lightslidervalue)), Convert.ToByte(blue + ((255 - blue) * lightslidervalue)));
                Color extremelightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * extremelightslidervalue)), Convert.ToByte(green + ((255 - green) * extremelightslidervalue)), Convert.ToByte(blue + ((255 - blue) * extremelightslidervalue)));

                SolidColorBrush brush = new SolidColorBrush(bg);
                SolidColorBrush middarkbrush = new SolidColorBrush(middarkbg);
                SolidColorBrush darkbrush = new SolidColorBrush(darkbg);
                SolidColorBrush extremedarkbrush = new SolidColorBrush(extremedarkbg);

                SolidColorBrush midlightbrush = new SolidColorBrush(midlightbg);
                SolidColorBrush lightbrush = new SolidColorBrush(lightbg);
                SolidColorBrush extremelightbrush = new SolidColorBrush(extremelightbg);

                output.Fill = brush;
                middarkoutput.Fill = middarkbrush;
                darkoutput.Fill = darkbrush;
                extremedarkoutput.Fill = extremedarkbrush;

                midlightoutput.Fill = midlightbrush;
                lightoutput.Fill = lightbrush;
                extremelightoutput.Fill = extremelightbrush;

            }
            else if (slider.Value <= 3.3333333333 && slider.Value > 1.66666666667)
            {
                double convertedrgb = (slider.Value / 1.66666666667 * 255) - 255;
                int rgbval = (int)Math.Round(255 - convertedrgb);
                Red.Text = rgbval.ToString();
                Green.Text = "255";
                Blue.Text = "0";

                int red = rgbval;
                int green = 255;
                int blue = 0;

                Color bg = Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue));
                Color middarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * middarkslidervalue)), Convert.ToByte(green - ((green - 0) * middarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * middarkslidervalue)));
                Color darkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * darkslidervalue)), Convert.ToByte(green - ((green - 0) * darkslidervalue)), Convert.ToByte(blue - ((blue - 0) * darkslidervalue)));
                Color extremedarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * extremedarkslidervalue)), Convert.ToByte(green - ((green - 0) * extremedarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * extremedarkslidervalue)));

                Color midlightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * midlightslidervalue)), Convert.ToByte(green + ((255 - green) * midlightslidervalue)), Convert.ToByte(blue + ((255 - blue) * midlightslidervalue)));
                Color lightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * lightslidervalue)), Convert.ToByte(green + ((255 - green) * lightslidervalue)), Convert.ToByte(blue + ((255 - blue) * lightslidervalue)));
                Color extremelightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * extremelightslidervalue)), Convert.ToByte(green + ((255 - green) * extremelightslidervalue)), Convert.ToByte(blue + ((255 - blue) * extremelightslidervalue)));

                SolidColorBrush brush = new SolidColorBrush(bg);
                SolidColorBrush middarkbrush = new SolidColorBrush(middarkbg);
                SolidColorBrush darkbrush = new SolidColorBrush(darkbg);
                SolidColorBrush extremedarkbrush = new SolidColorBrush(extremedarkbg);

                SolidColorBrush midlightbrush = new SolidColorBrush(midlightbg);
                SolidColorBrush lightbrush = new SolidColorBrush(lightbg);
                SolidColorBrush extremelightbrush = new SolidColorBrush(extremelightbg);

                output.Fill = brush;
                middarkoutput.Fill = middarkbrush;
                darkoutput.Fill = darkbrush;
                extremedarkoutput.Fill = extremedarkbrush;

                midlightoutput.Fill = midlightbrush;
                lightoutput.Fill = lightbrush;
                extremelightoutput.Fill = extremelightbrush;

            }
            else if (slider.Value <= 5.0 && slider.Value > 3.3333333333)
            {
                double convertedrgb = (slider.Value / 1.66666666667 * 255) - (255 * 2);
                int rgbval = (int)Math.Round(convertedrgb);
                Red.Text = "0";
                Green.Text = "255";
                Blue.Text = rgbval.ToString();

                int red = 0;
                int green = 255;
                int blue = rgbval;

                Color bg = Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue));
                Color middarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * middarkslidervalue)), Convert.ToByte(green - ((green - 0) * middarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * middarkslidervalue)));
                Color darkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * darkslidervalue)), Convert.ToByte(green - ((green - 0) * darkslidervalue)), Convert.ToByte(blue - ((blue - 0) * darkslidervalue)));
                Color extremedarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * extremedarkslidervalue)), Convert.ToByte(green - ((green - 0) * extremedarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * extremedarkslidervalue)));

                Color midlightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * midlightslidervalue)), Convert.ToByte(green + ((255 - green) * midlightslidervalue)), Convert.ToByte(blue + ((255 - blue) * midlightslidervalue)));
                Color lightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * lightslidervalue)), Convert.ToByte(green + ((255 - green) * lightslidervalue)), Convert.ToByte(blue + ((255 - blue) * lightslidervalue)));
                Color extremelightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * extremelightslidervalue)), Convert.ToByte(green + ((255 - green) * extremelightslidervalue)), Convert.ToByte(blue + ((255 - blue) * extremelightslidervalue)));

                SolidColorBrush brush = new SolidColorBrush(bg);
                SolidColorBrush middarkbrush = new SolidColorBrush(middarkbg);
                SolidColorBrush darkbrush = new SolidColorBrush(darkbg);
                SolidColorBrush extremedarkbrush = new SolidColorBrush(extremedarkbg);

                SolidColorBrush midlightbrush = new SolidColorBrush(midlightbg);
                SolidColorBrush lightbrush = new SolidColorBrush(lightbg);
                SolidColorBrush extremelightbrush = new SolidColorBrush(extremelightbg);

                output.Fill = brush;
                middarkoutput.Fill = middarkbrush;
                darkoutput.Fill = darkbrush;
                extremedarkoutput.Fill = extremedarkbrush;

                midlightoutput.Fill = midlightbrush;
                lightoutput.Fill = lightbrush;
                extremelightoutput.Fill = extremelightbrush;
            }
            else if (slider.Value <= 6.6666666 && slider.Value > 0.5)
            {
                double convertedrgb = (slider.Value / 1.66666666667 * 255) - (255 * 3);
                int rgbval = (int)Math.Round(255 - convertedrgb);
                Red.Text = "0";
                Green.Text = rgbval.ToString();
                Blue.Text = "255";

                int red = 0;
                int green = rgbval;
                int blue = 255;

                Color bg = Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue));
                Color middarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * middarkslidervalue)), Convert.ToByte(green - ((green - 0) * middarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * middarkslidervalue)));
                Color darkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * darkslidervalue)), Convert.ToByte(green - ((green - 0) * darkslidervalue)), Convert.ToByte(blue - ((blue - 0) * darkslidervalue)));
                Color extremedarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * extremedarkslidervalue)), Convert.ToByte(green - ((green - 0) * extremedarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * extremedarkslidervalue)));

                Color midlightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * midlightslidervalue)), Convert.ToByte(green + ((255 - green) * midlightslidervalue)), Convert.ToByte(blue + ((255 - blue) * midlightslidervalue)));
                Color lightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * lightslidervalue)), Convert.ToByte(green + ((255 - green) * lightslidervalue)), Convert.ToByte(blue + ((255 - blue) * lightslidervalue)));
                Color extremelightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * extremelightslidervalue)), Convert.ToByte(green + ((255 - green) * extremelightslidervalue)), Convert.ToByte(blue + ((255 - blue) * extremelightslidervalue)));

                SolidColorBrush brush = new SolidColorBrush(bg);
                SolidColorBrush middarkbrush = new SolidColorBrush(middarkbg);
                SolidColorBrush darkbrush = new SolidColorBrush(darkbg);
                SolidColorBrush extremedarkbrush = new SolidColorBrush(extremedarkbg);

                SolidColorBrush midlightbrush = new SolidColorBrush(midlightbg);
                SolidColorBrush lightbrush = new SolidColorBrush(lightbg);
                SolidColorBrush extremelightbrush = new SolidColorBrush(extremelightbg);

                output.Fill = brush;
                middarkoutput.Fill = middarkbrush;
                darkoutput.Fill = darkbrush;
                extremedarkoutput.Fill = extremedarkbrush;

                midlightoutput.Fill = midlightbrush;
                lightoutput.Fill = lightbrush;
                extremelightoutput.Fill = extremelightbrush;
            }
            else if (slider.Value <= 8.33333333 && slider.Value > 6.6666666)
            {
                double convertedrgb = (slider.Value / 1.66666666667 * 255) - (255 * 4);
                int rgbval = (int)Math.Round(convertedrgb);
                Red.Text = rgbval.ToString();
                Green.Text = "0";
                Blue.Text = "255";

                int red = rgbval;
                int green = 0;
                int blue = 255;

                Color bg = Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue));
                Color middarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * middarkslidervalue)), Convert.ToByte(green - ((green - 0) * middarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * middarkslidervalue)));
                Color darkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * darkslidervalue)), Convert.ToByte(green - ((green - 0) * darkslidervalue)), Convert.ToByte(blue - ((blue - 0) * darkslidervalue)));
                Color extremedarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * extremedarkslidervalue)), Convert.ToByte(green - ((green - 0) * extremedarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * extremedarkslidervalue)));

                Color midlightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * midlightslidervalue)), Convert.ToByte(green + ((255 - green) * midlightslidervalue)), Convert.ToByte(blue + ((255 - blue) * midlightslidervalue)));
                Color lightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * lightslidervalue)), Convert.ToByte(green + ((255 - green) * lightslidervalue)), Convert.ToByte(blue + ((255 - blue) * lightslidervalue)));
                Color extremelightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * extremelightslidervalue)), Convert.ToByte(green + ((255 - green) * extremelightslidervalue)), Convert.ToByte(blue + ((255 - blue) * extremelightslidervalue)));

                SolidColorBrush brush = new SolidColorBrush(bg);
                SolidColorBrush middarkbrush = new SolidColorBrush(middarkbg);
                SolidColorBrush darkbrush = new SolidColorBrush(darkbg);
                SolidColorBrush extremedarkbrush = new SolidColorBrush(extremedarkbg);

                SolidColorBrush midlightbrush = new SolidColorBrush(midlightbg);
                SolidColorBrush lightbrush = new SolidColorBrush(lightbg);
                SolidColorBrush extremelightbrush = new SolidColorBrush(extremelightbg);

                output.Fill = brush;
                middarkoutput.Fill = middarkbrush;
                darkoutput.Fill = darkbrush;
                extremedarkoutput.Fill = extremedarkbrush;

                midlightoutput.Fill = midlightbrush;
                lightoutput.Fill = lightbrush;
                extremelightoutput.Fill = extremelightbrush;
            }
            else if (slider.Value <= 10 && slider.Value > 8.33333333)
            {
                double convertedrgb = (slider.Value / 1.66666666667 * 255) - (255 * 5);
                int rgbval = (int)Math.Round(255 - convertedrgb);
                Red.Text = "255";
                Green.Text = "0";
                Blue.Text = rgbval.ToString();

                int red = 255;
                int green = 0;
                int blue = rgbval;

                Color bg = Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue));
                Color middarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * middarkslidervalue)), Convert.ToByte(green - ((green - 0) * middarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * middarkslidervalue)));
                Color darkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * darkslidervalue)), Convert.ToByte(green - ((green - 0) * darkslidervalue)), Convert.ToByte(blue - ((blue - 0) * darkslidervalue)));
                Color extremedarkbg = Color.FromRgb(Convert.ToByte(red - ((red - 0) * extremedarkslidervalue)), Convert.ToByte(green - ((green - 0) * extremedarkslidervalue)), Convert.ToByte(blue - ((blue - 0) * extremedarkslidervalue)));

                Color midlightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * midlightslidervalue)), Convert.ToByte(green + ((255 - green) * midlightslidervalue)), Convert.ToByte(blue + ((255 - blue) * midlightslidervalue)));
                Color lightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * lightslidervalue)), Convert.ToByte(green + ((255 - green) * lightslidervalue)), Convert.ToByte(blue + ((255 - blue) * lightslidervalue)));
                Color extremelightbg = Color.FromRgb(Convert.ToByte(red + ((255 - red) * extremelightslidervalue)), Convert.ToByte(green + ((255 - green) * extremelightslidervalue)), Convert.ToByte(blue + ((255 - blue) * extremelightslidervalue)));

                SolidColorBrush brush = new SolidColorBrush(bg);
                SolidColorBrush middarkbrush = new SolidColorBrush(middarkbg);
                SolidColorBrush darkbrush = new SolidColorBrush(darkbg);
                SolidColorBrush extremedarkbrush = new SolidColorBrush(extremedarkbg);

                SolidColorBrush midlightbrush = new SolidColorBrush(midlightbg);
                SolidColorBrush lightbrush = new SolidColorBrush(lightbg);
                SolidColorBrush extremelightbrush = new SolidColorBrush(extremelightbg);

                output.Fill = brush;
                middarkoutput.Fill = middarkbrush;
                darkoutput.Fill = darkbrush;
                extremedarkoutput.Fill = extremedarkbrush;

                midlightoutput.Fill = midlightbrush;
                lightoutput.Fill = lightbrush;
                extremelightoutput.Fill = extremelightbrush;
            }
        }

        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updatevalues();
        }

        private void edvaluechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updatevalues();
        }

        private void dvaluechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updatevalues();
        }

        private void mdvaluechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updatevalues();
        }

        private void mlvaluechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updatevalues();
        }

        private void lvaluechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updatevalues();
        }

        private void elvaluechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updatevalues();
        }
    }
}
