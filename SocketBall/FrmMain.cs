using SocketBall.CLASSES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SocketBall
{
    public partial class FrmMain : Form
    {
        private ClXarxa xarxa = new ClXarxa();
        private List<ClBola> llistaBoles = new List<ClBola>();
        private clPala pala;
        private Random rnd = new Random();
        private System.Windows.Forms.Timer gameTimer;

        public FrmMain()
        {
            InitializeComponent();

            // Refresco de pantalla cada 20ms (50 FPS)
            gameTimer = new System.Windows.Forms.Timer { Interval = 20 };
            gameTimer.Tick += GameTimer_Tick;

            // Cuando la red recibe una bola, la crea y la añade a la lista
            xarxa.AlRebreMissatge += (msg) => this.Invoke(new Action(() => {
                llistaBoles.Add(new ClBola(msg, this.ClientSize.Width, this.ClientSize.Height));
            }));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true; // Evita el parpadeo de la pantalla
            this.WindowState = FormWindowState.Maximized;
            pala = new clPala(this.Width / 2, this.Height / 2);
        }

        // BUCLE PRINCIPAL DEL JUEGO
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            for (int i = llistaBoles.Count - 1; i >= 0; i--)
            {
                var b = llistaBoles[i];
                b.Moure();

                // 1. Rebot Techo y Suelo
                if (b.Y <= 0 || b.Y + (b.Radio * 2) >= this.ClientSize.Height) b.VelY *= -1;

                // 2. Rebot con la Pala
                if (b.XocaAmb(pala.Rect))
                {
                    b.VelX *= -1; // Cambia de dirección horizontal
                    b.VelY = rnd.Next(-15, 16); // Ángulo aleatorio para que sea divertido
                }

                // 3. Gestionar si sale por los lados
                GestionarSortida(b, i);
            }
            this.Invalidate(); // Fuerza a ejecutar el OnPaint
        }

        private void GestionarSortida(ClBola b, int index)
        {
            // Sale por la Izquierda
            if (b.X <= 0)
            {
                if (chkEsquerre.Checked) b.VelX = Math.Abs(b.VelX); // Si es pared, rebota
                else
                {
                    xarxa.EnviarBola(b.ToSocketString(this.Height), true); // Si no, viaja al vecino
                    llistaBoles.RemoveAt(index);
                }
            }
            // Sale por la Derecha
            else if (b.X + (b.Radio * 2) >= this.ClientSize.Width)
            {
                if (chkDret.Checked) b.VelX = -Math.Abs(b.VelX); // Rebota
                else
                {
                    xarxa.EnviarBola(b.ToSocketString(this.Height), false); // Viaja al vecino
                    llistaBoles.RemoveAt(index);
                }
            }
        }

        // Mover la pala siguiendo al ratón
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (pala != null)
            {
                pala.Moure(e.X, e.Y, ClientSize.Width, ClientSize.Height);
                this.Invalidate(); // Necesario para que la pala se mueva fluido
            }
        }

        // Dibujar todo en pantalla
        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var b in llistaBoles) b.Dibuixar(e.Graphics);
            pala?.Dibuixar(e.Graphics);
        }

        // Botón Servidor (Escuchar)
        private async void btPort_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nupPort.Text, out int port))
            {
                btPort.Enabled = false;
                await xarxa.IniciarServidorAsync(port);
            }
        }

        // Botón Conectar a vecinos
        private async void btConnectar_Click(object sender, EventArgs e)
        {
            bool okE = chkEsquerre.Checked || await xarxa.ConnectarVeiAsync(tbEsquerre.Text, nupEsquerre.Text, true);
            bool okD = chkDret.Checked || await xarxa.ConnectarVeiAsync(tbDret.Text, nupDret.Text, false);

            if (okE && okD) gameTimer.Start();
        }

        // Atajo Ctrl+N para crear bolas
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                Color[] c = { Color.Red, Color.Blue, Color.Lime, Color.Yellow };
                llistaBoles.Add(new ClBola(c[rnd.Next(4)], Width / 2, Height / 2, 20, 12, 12, 20));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}