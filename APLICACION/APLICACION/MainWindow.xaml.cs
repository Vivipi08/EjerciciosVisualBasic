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
using System.Windows.Threading;

namespace APLICACION
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] botones;
        private const int alto = 4, ancho = 4;
        private int numero1, numero2;
        private int filanum, colnum;
        private int numaciertos, numfallos;
        private DispatcherTimer tiempojuego;
        private Image[,] imagenes;
        private Grid[,] ph;
        private TextBlock[,] numero;
        public MainWindow()
        {
            tiempojuego = new DispatcherTimer();
            tiempojuego.Tick += new EventHandler(segundosjuego);
            tiempojuego.Interval = new TimeSpan(0, 0, 1);
            tiempojuego.Start();
            numero1 = -1;
            numero2 = -1;
            InitializeComponent();
            ph = new Grid[alto, ancho];
            imagenes = new Image[alto, ancho];
            numero = new TextBlock[alto, ancho];
            botones = new Button[alto, ancho];

            botones = new Button[alto, ancho];
            Numeros num = new Numeros(); 
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    botones[i, j] = new Button();
                    botones[i,j].Click += clickBoton;
                    int numeros = num.obtenernumero();
                    botones[i,j].Content = numero.ToString();
                    botones[i, j].Foreground = new SolidColorBrush(Colors.Transparent);
                    Grid.SetColumn(botones[i, j], i);
                    Grid.SetRow(botones[i, j], j);
                    pantalladejuego.Children.Add(botones[i, j]);
                    ph[i, j] = new Grid();
                    numero[i, j] = new TextBlock();
                    numero[i, j].Text = numeros.ToString();
                    numero[i, j].Visibility = Visibility.Collapsed;
                    botones[i, j].Content = ph[i, j];
                    imagenes[i, j] = new Image();
                    imagenes[i, j].Source = new BitmapImage(new Uri(num.conseguirimagenes(numeros), UriKind.Relative));
                    ph[i, j].Children.Add(imagenes [i, j]);
                }
            }
        }


        
            
            
            
          private async  void clickBoton(object sender, RoutedEventArgs e)
        {
            
            ((Button)sender).Foreground = new SolidColorBrush(Colors.Blue);
            ((Button)sender).IsEnabled = false;
            if (numero1 == -1)
            {
                numero1 = int.Parse(((Button)sender).Content.ToString());
                colnum = Grid.GetColumn((Button)sender);
                filanum = Grid.GetRow((Button)sender);
            }
            else
            {
                numero2 = int.Parse(((Button)sender).Content.ToString());
                await Task.Delay(1000);
                if (numero1 == numero2)
                {
                    numaciertos++;
                    aciertos.Text = numaciertos.ToString();
                    MessageBox.Show("usted acerto");
                    ((Button)sender).IsEnabled = false;
                }

                else
                {
                    numfallos++;
                    fallidos.Text = numfallos.ToString();
                    ((Button)sender).Foreground = new SolidColorBrush(Colors.Transparent);
                    ((Button)sender).IsEnabled = true;
                    botones[colnum, filanum].IsEnabled = true;
                    MessageBox.Show("usted fallo");
                    botones[colnum, filanum].Foreground = new SolidColorBrush(Colors.Transparent);
                }
                numero1 = -1;
            }
            if (numaciertos == 8)
            {
                tiempojuego.Stop();
                MessageBox.Show("usted ha ganado");
            }

          

            }
          private int segundos = 0;
          private void segundosjuego(object sender, EventArgs e)
          {

              tiempo.Text = segundos.ToString();
              segundos++; 
          }

        }
    }
