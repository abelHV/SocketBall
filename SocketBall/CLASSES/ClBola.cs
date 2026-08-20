using System;
using System.Drawing;

namespace SocketBall.CLASSES
{
    public class ClBola
    {
        // Propiedades básicas de la bola
        public Color ColorBola { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public int Radio { get; set; }
        public int VelX { get; set; }
        public int VelY { get; set; }
        public int Interval { get; set; }

        // CONSTRUCTOR 1: Para crear bolas nuevas localmente (ej. al pulsar Ctrl+N)
        public ClBola(Color color, float x, float y, int radio, int velX, int velY, int interval)
        {
            ColorBola = color; X = x; Y = y; Radio = radio;
            VelX = velX; VelY = velY; Interval = interval;
        }

        // CONSTRUCTOR 2: Para reconstruir una bola que viene de otro ordenador (Red)
        public ClBola(string datos, int formWidth, int formHeight)
        {
            // Separamos el string por los puntos y coma
            string[] d = datos.Split(';');

            this.ColorBola = Color.FromName(d[0]); // Nombre del color
            this.Radio = int.Parse(d[2]);
            this.VelX = int.Parse(d[3]);
            this.VelY = int.Parse(d[4]);
            this.Interval = int.Parse(d[5]);

            // POSICIÓN X: Si la velocidad es positiva, la bola entra por la izquierda (X=10).
            // Si es negativa, entra por la derecha (X = ancho total - tamaño bola).
            this.X = (this.VelX > 0) ? 10 : formWidth - (this.Radio * 2) - 10;

            // POSICIÓN Y: Recibimos un porcentaje (0-100). Lo convertimos a píxeles 
            // multiplicando por el alto de nuestra ventana actual.
            float posYPercent = float.Parse(d[1]);
            this.Y = (posYPercent / 100) * formHeight;
        }

        // Mueve la bola sumando su velocidad a la posición actual
        public void Moure() { X += VelX; Y += VelY; }

        // Detecta si el círculo de la bola toca el rectángulo de la pala
        public bool XocaAmb(Rectangle rectPala)
        {
            Rectangle rectBola = new Rectangle((int)X, (int)Y, Radio * 2, Radio * 2);
            return rectBola.IntersectsWith(rectPala);
        }

        // Dibuja la bola en el formulario
        public void Dibuixar(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(ColorBola))
            {
                g.FillEllipse(brush, X, Y, Radio * 2, Radio * 2);
            }
        }

        // Convierte los datos de la bola en un string para enviar por Socket
        public string ToSocketString(int formHeight)
        {
            // Calculamos la posición Y como un porcentaje relativo al alto de la ventana
            float posYPercent = (Y / formHeight) * 100;
            // Estructura: Color;PosicionY%;Radio;VelX;VelY;Interval
            return $"{ColorBola.Name};{posYPercent.ToString("F1")};{Radio};{VelX};{VelY};{Interval}";
        }
    }
}