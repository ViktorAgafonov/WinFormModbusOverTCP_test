using System.Net.Sockets;

namespace WinFormModbusOverTCP_test
{
    public partial class WinFormModbusOverTCP_test : Form
    {
        private TcpClient tcpClient; private NetworkStream networkStream;
        private Thread readThread;
        private volatile bool continueReading = false;
        public WinFormModbusOverTCP_test() => InitializeComponent();

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = ipAddress.Text.Trim();
                int port = int.Parse(portNumber.Text);

                tcpClient = new TcpClient(ip, port);
                networkStream = tcpClient.GetStream();


                readThread = new Thread(ReadData);
                continueReading = true;
                readThread.Start();

                checkBox1.Checked = true;
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
        }



        private void ReadData()
        {
            try
            {
                byte[] buffer = new byte[1];
                while (continueReading)
                {
                    if (networkStream.DataAvailable)
                    {
                        int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {
                            string receivedData = BitConverter.ToString(buffer, 0, bytesRead);
                            Invoke(new Action(() =>
                            {
                                richTextBoxRead.AppendText(receivedData);
                            }));
                        }
                    }
                    else
                    {
                        Thread.Sleep(10); // Задержка, чтобы не загружать процессор, надо ли асинхронно?
                    }
                }
            }
            catch (Exception ex)
            {
                if (continueReading)
                {
                    MessageBox.Show($"Ошибка чтения данных: {ex.Message}");
                }
            }
        }
        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
        private void Disconnect()
        {
            try
            {
                continueReading = false;
                readThread?.Join();
                networkStream?.Close();
                tcpClient?.Close();
                checkBox1.Checked = false;

                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отключения: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Disconnect();
            base.OnFormClosing(e);
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBoxRead.Text.Length > 0) richTextBoxRead.AppendText(Environment.NewLine + $"{DateTime.Now:HH:mm:ss}: ");
                else richTextBoxRead.AppendText($"{DateTime.Now:HH:mm:ss}: ");

                if (networkStream != null && networkStream.CanWrite)
                {
                    byte[] request =
                        [   Convert.ToByte(byte0.Text.Trim(), 16),
                            Convert.ToByte(byte1.Text.Trim(), 16),
                            Convert.ToByte(byte2.Text.Trim(), 16),
                            Convert.ToByte(byte3.Text.Trim(), 16),
                            Convert.ToByte(byte4.Text.Trim(), 16),
                            Convert.ToByte(byte5.Text.Trim(), 16),
                            Convert.ToByte(byte6.Text.Trim(), 16),
                            Convert.ToByte(byte7.Text.Trim(), 16) ];

                    networkStream.Write(request, 0, request.Length);
                }
                else
                {
                    MessageBox.Show("Соединение с сервером отсутствует.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке данных: {ex.Message}");
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            richTextBoxRead.Clear();
        }
    }
}

