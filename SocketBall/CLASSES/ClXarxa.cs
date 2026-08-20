using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketBall.CLASSES
{
    public class ClXarxa
    {
        private TcpListener xafarder; // Servidor que escucha
        private TcpClient xerraireEsquerre; // Cliente para enviar a la izquierda
        private TcpClient xerraireDret; // Cliente para enviar a la derecha
        private CancellationTokenSource cts;
        private const int MAX_BUFFER = 4096;

        // Evento que avisará al Formulario cada vez que llegue una bola
        public event Action<string> AlRebreMissatge;

        // Inicia el servidor para recibir conexiones de otros
        public async Task IniciarServidorAsync(int port)
        {
            cts = new CancellationTokenSource();
            xafarder = new TcpListener(IPAddress.Any, port);
            xafarder.Start();

            try
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    TcpClient client = await xafarder.AcceptTcpClientAsync();
                    _ = GestionarClientAsync(client, cts.Token); // Hilo aparte por cada vecino
                }
            }
            catch { }
        }

        // Bucle que lee constantemente lo que llega por la red
        private async Task GestionarClientAsync(TcpClient client, CancellationToken token)
        {
            byte[] buffer = new byte[MAX_BUFFER];
            NetworkStream stream = client.GetStream();
            string acumulado = ""; // IMPORTANTE: Guarda mensajes incompletos o pegados

            try
            {
                while (!token.IsCancellationRequested)
                {
                    int bytesLlegits = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                    if (bytesLlegits == 0) break;

                    // Convertimos bytes a texto y lo añadimos al acumulado
                    acumulado += Encoding.UTF8.GetString(buffer, 0, bytesLlegits);

                    // Mientras haya un salto de línea (\n), hay un mensaje completo
                    while (acumulado.Contains("\n"))
                    {
                        int pos = acumulado.IndexOf("\n");
                        string msg = acumulado.Substring(0, pos); // Extraemos la bola
                        acumulado = acumulado.Substring(pos + 1); // Dejamos el resto para después

                        if (!string.IsNullOrWhiteSpace(msg))
                            AlRebreMissatge?.Invoke(msg); // Avisamos al Form
                    }
                }
            }
            catch { }
            finally { client.Close(); }
        }

        // Conecta con el vecino (Izquierda o Derecha)
        public async Task<bool> ConnectarVeiAsync(string ipStr, string portStr, bool esEsquerre)
        {
            try
            {
                if (IPAddress.TryParse(ipStr, out IPAddress ip) && int.TryParse(portStr, out int port))
                {
                    TcpClient nouClient = new TcpClient();
                    await nouClient.ConnectAsync(ip, port);

                    if (esEsquerre) xerraireEsquerre = nouClient;
                    else xerraireDret = nouClient;
                    return true;
                }
            }
            catch { }
            return false;
        }

        // Envía el string de la bola añadiendo un \n al final
        public async void EnviarBola(string dades, bool aEsquerre)
        {
            TcpClient destino = aEsquerre ? xerraireEsquerre : xerraireDret;
            if (destino != null && destino.Connected)
            {
                try
                {
                    byte[] msg = Encoding.UTF8.GetBytes(dades + "\n");
                    await destino.GetStream().WriteAsync(msg, 0, msg.Length);
                }
                catch { }
            }
        }
    }
}