using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// que boton precionamos?
        /// </summary>
        int presionado;

        /// <summary>
        /// aca vamos a cargar el orden de las luces
        /// </summary>
        List<int> juego = new List<int>();

        /// <summary>
        /// es el numero que vamos a usar para recorrer la lista
        /// </summary>
        int i = 0;


        public Form1()
        {
            InitializeComponent();
            agregarAleatorio();
        }

        /// <summary>
        /// vuelve todos los botones a sus colores originales
        /// </summary>
        public void apagarTodo()
        {
            btnAmarrillo.BackColor = Color.Yellow;
            btnAzul.BackColor = Color.Blue;
            btnRojo.BackColor = Color.Red;
            btnVerde.BackColor = Color.Green;
        }

        /// <summary>
        /// inicia el juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJugar_Click(object sender, EventArgs e)
        {            
            timer1.Start();
        }

        /// <summary>
        /// agrega un numero a la lista entre 1 y 4
        /// </summary>
        public void agregarAleatorio()
        {
            Random random = new Random();

            juego.Add(random.Next(1,5));
        }

        /// <summary>
        /// cuando el timer este prendido esto se va a ejecutar cada segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrar(juego.ElementAt(i));

            if (i < juego.Count - 1) i++; //si aun quedan elementos para mostrar pasamos al sgte
            else
            {
                //sino detenemos todo y volvemos al elemento inicial
                timer1.Stop();
                i = 0;
            }

            timer2.Start(); //apaga la luz que hayamos prendido despues de medio segundo
        }

        /// <summary>
        /// apaga las luces despues de medio segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            apagarTodo();
            timer2.Stop();
        }

        /// <summary>
        /// prende el boton que le pasemos
        /// </summary>
        /// <param name="boton">numero entre 1 y 4</param>
        public void mostrar(int boton)
        {
            if (boton == 1) btnAzul.BackColor = Color.DodgerBlue;
            else if (boton == 2) btnAmarrillo.BackColor = Color.Khaki;
            else if (boton == 3) btnVerde.BackColor = Color.LightGreen;
            else if (boton == 4) btnRojo.BackColor = Color.IndianRed;
        }

        /// <summary>
        /// se fija que boton presionamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                Control control = (Control)sender;

                if (control == btnAzul)
                {
                    presionado = 1;
                }
                else if (control == btnAmarrillo)
                {
                    presionado = 2;
                }
                else if (control == btnVerde)
                {
                    presionado = 3;
                }
                else if (control == btnRojo)
                {
                    presionado = 4;
                }

                if (apretoBien())
                {
                    if (i < juego.Count - 1) i++;
                    else
                    {
                        agregarAleatorio();
                        i = 0;
                        buttonJugar_Click(sender, e);

                    }
                }
                else
                {
                    mostrarMensaje("Perdiste");
                    i = 0;
                    timer1.Stop();
                    timer2.Stop();
                    juego.Clear();
                    agregarAleatorio();
                }
               

            }
        }

        /// <summary>
        /// muestra un mensaje 
        /// </summary>
        /// <param name="mensaje"></param>
        public void mostrarMensaje(string mensaje)
        {
            const string caption = "Fin Del Juego";
            var result = MessageBox.Show(mensaje, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
        }


        /// <summary>
        /// verifica que el boton apretado se el que tenia que apretar
        /// </summary>
        /// <returns></returns>
        public bool apretoBien()
        {
            return presionado == juego.ElementAt(i);
        }

        
    }
}
