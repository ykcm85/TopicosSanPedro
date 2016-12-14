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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace juego_gato
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int contador = 0;
        private int [,] mapa = new int[,] { {-1,-2,-3},
                                            {-4,-5,-6},
                                            {-1,-2,-3}
                                          };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            evento(0, 0); 
            comprobar();      
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            evento(0, 1); 
            comprobar();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            evento(0, 2); 
            comprobar();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            evento(1, 0); 
            comprobar();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            evento(1, 1); 
            comprobar();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            evento(1, 2); 
            comprobar();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            evento(2, 0); 
            comprobar();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            evento(2, 1); 
            comprobar();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            evento(2, 2); 
            comprobar();
        }

        private void evento(int fila, int columna)
        {
            
            switch (fila)
            {
                case 0:
                    switch (columna)
                    {
                        case 0: this.mapa[0, 0] = seteoImagen(this.image1, this.btn1); break;
                        case 1: this.mapa[0, 1] = seteoImagen(this.image2, this.btn2); break;
                        case 2: this.mapa[0, 2] = seteoImagen(this.image3, this.btn3); break;
                    }; break;
                case 1:
                    switch (columna)
                    {
                        case 0: this.mapa[1, 0] = seteoImagen(this.image4, this.btn4); break;
                        case 1: this.mapa[1, 1] = seteoImagen(this.image5, this.btn5); break;
                        case 2: this.mapa[1, 2] = seteoImagen(this.image6, this.btn6); break;
                    }; break;
                case 2:
                    switch (columna)
                    {
                        case 0: this.mapa[2, 0] = seteoImagen(this.image7, this.btn7); break;
                        case 1: this.mapa[2, 1] = seteoImagen(this.image8, this.btn8); break;
                        case 2: this.mapa[2, 2] = seteoImagen(this.image9, this.btn9); break;
                    }; break;
            }

        }

        private void  comprobar() 
        {

            for(int fila = 0; fila < 3; fila++) 
            {
                if (mapa[fila, 0] == mapa[fila, 1] && mapa[fila, 1] == mapa[fila, 2]) 
                {
                    MessageBox.Show("Gano jugador "+mapa[fila,0]);
                    bloqueoElmentos();
                    reset();
                    this.contador = 0;
                    return;
                }
                if (mapa[0, fila] == mapa[1, fila] && mapa[1, fila] == mapa[2, fila]) 
                {
                    MessageBox.Show("Gano jugador "+mapa[0,fila]);
                    bloqueoElmentos();
                    reset();
                    this.contador = 0;
                    return;
                }
            }
            if (mapa[0, 0] == mapa[1, 1] && mapa[1, 1] == mapa[2, 2]) 
            {
                MessageBox.Show("Gano jugador " + mapa[0, 0]);
                bloqueoElmentos();
                reset();
                this.contador = 0;
                return;
            }
            if (mapa[2, 0] == mapa[1, 1] && mapa[1, 1] == mapa[0, 2]) 
            {
                MessageBox.Show("Gano jugador " + mapa[2, 0]);
                bloqueoElmentos();
                reset();
                this.contador = 0;
                return;
            }
            if (contador %9 == 0) {
                MessageBox.Show("Empate");
                reset();
                return;
            }
        }

        private int seteoImagen(Image image, Button button)
        {
            int user = -1;
            if (contador % 2 == 0)
            {
                user = 1;
                image.Source = new BitmapImage(new Uri("src/img/circulo.png", UriKind.Relative));
            }
            else
            {
                user = 2;
                image.Source = new BitmapImage(new Uri("src/img/equis.png", UriKind.Relative));
            }
            button.Visibility = Visibility.Hidden;
            this.contador++;

            return user;
        }

        private void bloqueoElmentos() 
        {
            foreach (var c in this.grid_principal.Children) 
            {
                if (c is Button) 
                {
                    ((Button)c).Visibility = Visibility.Hidden;
                }
            }
        }

        private void reset()
        {
            foreach (var c in this.grid_principal.Children) 
            {
                if (c is Button)
                {
                    ((Button)c).Visibility = Visibility.Visible;
                }
                if (c is Image) {
                    ((Image)c).Source = null;
                }
            }

            this.mapa = new int[,] { {-1,-2,-3},
                                     {-4,-5,-6},
                                     {-1,-2,-3}
                                   };
        }
        

       

       
    }
}
