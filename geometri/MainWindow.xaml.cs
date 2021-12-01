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

namespace Геометрические_фигуры
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    private void TextRadius_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (LabelRadius.Foreground != Brushes.Black)
            LabelRadius.Foreground = Brushes.Black;
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        if (RadioCircle.IsChecked.Value)
        {

            try
            {
                //создаем новый объект класса круг
                Circle myCircle = new Circle();

                //вызываем метод этого объекта
                //устанавливаем радиус для круга
                myCircle.SetRadius(Double.Parse(TextRadius.Text));

                //создаем новый блок с текстом, который отправится в StackPanel для кругов
                TextBlock myTextBlock = new TextBlock();
                myTextBlock.Text = "Площадь: " + myCircle.Area(); //здесь получаем площадь созданного объекта круга
                StackCircles.Children.Add(myTextBlock);
            }
            catch (Exception ex)
            {
                LabelRadius.Foreground = Brushes.Red;
            }
        }
        
        if (RadioIcylinder.IsChecked.Value)
        {
            try
            {
                Icylinder myIcylinder = new Icylinder();

                myIcylinder.SetRadius(Double.Parse(TextRadius.Text));
                myIcylinder.SetHeight(Double.Parse(TextHeightText));

                TextBlock myTextBlock = new TextBlock();
                myTextBlock.Text = "Объем: " + myIcylinder.Voleum();
                StackIcylinder.Children.Add(myTextBlock);

            }
             catch (Exception ex)
            {
                LabelRadius.Foreground = Brushes.Red;
            } 
       
        }
        
        if (RadioSfera.IsChecked.Value)
        {
            try
            {
                Sfera mySfera = new Sfera();

                mySfera.SetRadius(Double.Parse(TextRadius.Text));

                TextBlock myTextBlock = new TextBlock();
                myTextBlock.Text = "Объем: " + mySfera.Voleum();
                StackSfera.Children.Add(myTextBlock);
            }
            catch (Exception ex)
            {
                LabelRadius.Foreground = Brushes.Red;
            }

        }
    
    
    }  

    
    class Icylinder
    {
        private double _radius;
        private double _height;

        public void SetHeight(double height)
        {
            _height = height;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double Voleum()
        {
            return _radius * _radius * _height * Math.PI;
        }
    }

    class Circle 
    {
        private double _radius;

        public double Area()
        {
            return _radius * _radius * Math.PI;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }
    }
    
    class Sfera
    {
        private double _radius;

        public void SetRadius(double radius)
        {
            _radius = radius;
        }
   
        public double Voleum()
        {
            return 4/3 * Math.PI * _radius * _radius * _radius;
        }
    
    }

}
