using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppForVisualProgramming;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Line vertLine = new Line();
        vertLine.Stroke = Brushes.Black;
        vertLine.X1 = 10;
        vertLine.Y1 = 0;
        vertLine.X2 = 10;
        vertLine.Y2 = 450;
        Line horizLine = new Line();
        horizLine.Stroke = Brushes.Black;
        horizLine.X1 = 0;
        horizLine.Y1 = 10;
        horizLine.X2 = 800;
        horizLine.Y2 = 10;
        grid1.Children.Add(vertLine);
        grid1.Children.Add(horizLine);
        for (int i = 20; i < 800; i+=10)
        {
            Line a = new Line();
            a.Stroke = Brushes.Black;
            a.X1 += i;
            a.X2 += i;
            a.Y1 = vertLine.Y1;
            a.Y2 = vertLine.Y2;
            grid1.Children.Add(a);
        }
        for (int i = 20; i < 450; i+=10)
        {
            Line a = new Line(); 
            a.Stroke = Brushes.Black;
            a.Y1 += i;
            a.Y2 += i;
            a.X1 = horizLine.X1;
            a.X2 = horizLine.X2;
            grid1.Children.Add(a);
        }
        Polyline horizDirection = new Polyline();
        horizDirection.Points = new PointCollection();
        horizDirection.Points.Add(new Point(25,15));
        horizDirection.Points.Add(new Point(30,20));
        horizDirection.Points.Add(new Point(25, 25));
        horizDirection.Stroke = Brushes.DarkRed;
        grid1.Children.Add(horizDirection);
        Polyline vertDirection = new Polyline();
        vertDirection.Points = new PointCollection();
        vertDirection.Points.Add(new Point(5, 95));
        vertDirection.Points.Add(new Point(10, 100));
        vertDirection.Points.Add(new Point(15, 95));
        vertDirection.Stroke = Brushes.DarkRed;
        grid1.Children.Add(vertDirection);
    }
}