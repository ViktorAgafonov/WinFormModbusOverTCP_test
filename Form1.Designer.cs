namespace WinFormModbusOverTCP_test
{
    partial class WinFormModbusOverTCP_test
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ipAddress = new MaskedTextBox();
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            buttonSend = new Button();
            byte0 = new TextBox();
            byte1 = new TextBox();
            byte2 = new TextBox();
            byte3 = new TextBox();
            byte4 = new TextBox();
            byte5 = new TextBox();
            byte6 = new TextBox();
            richTextBoxRead = new RichTextBox();
            byte7 = new TextBox();
            checkBox1 = new CheckBox();
            buttonClear = new Button();
            portNumber = new MaskedTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ipAddress
            // 
            ipAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ipAddress.Location = new Point(12, 21);
            ipAddress.Mask = "990\\.990\\.990\\.990";
            ipAddress.Name = "ipAddress";
            ipAddress.Size = new Size(133, 33);
            ipAddress.TabIndex = 1;
            ipAddress.Text = "127000000001";
            ipAddress.ValidatingType = typeof(System.Net.IPAddress);
            // 
            // buttonConnect
            // 
            buttonConnect.Font = new Font("Segoe UI", 9.75F);
            buttonConnect.Location = new Point(244, 22);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(70, 33);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += ButtonConnect_Click;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Font = new Font("Segoe UI", 9.75F);
            buttonDisconnect.Location = new Point(320, 22);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(79, 33);
            buttonDisconnect.TabIndex = 3;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += ButtonDisconnect_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSend.Location = new Point(295, 71);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(49, 33);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "SEND";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += ButtonSend_Click;
            // 
            // byte0
            // 
            byte0.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte0.Location = new Point(13, 71);
            byte0.Name = "byte0";
            byte0.Size = new Size(33, 33);
            byte0.TabIndex = 12;
            byte0.Text = "01";
            byte0.TextAlign = HorizontalAlignment.Center;
            byte0.WordWrap = false;
            // 
            // byte1
            // 
            byte1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte1.Location = new Point(46, 71);
            byte1.Name = "byte1";
            byte1.Size = new Size(33, 33);
            byte1.TabIndex = 13;
            byte1.Text = "03";
            byte1.TextAlign = HorizontalAlignment.Center;
            byte1.WordWrap = false;
            // 
            // byte2
            // 
            byte2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte2.Location = new Point(79, 71);
            byte2.Name = "byte2";
            byte2.Size = new Size(33, 33);
            byte2.TabIndex = 14;
            byte2.Text = "00";
            byte2.TextAlign = HorizontalAlignment.Center;
            byte2.WordWrap = false;
            // 
            // byte3
            // 
            byte3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte3.Location = new Point(112, 71);
            byte3.Name = "byte3";
            byte3.Size = new Size(33, 33);
            byte3.TabIndex = 15;
            byte3.Text = "0E";
            byte3.TextAlign = HorizontalAlignment.Center;
            byte3.WordWrap = false;
            // 
            // byte4
            // 
            byte4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte4.Location = new Point(145, 71);
            byte4.Name = "byte4";
            byte4.Size = new Size(33, 33);
            byte4.TabIndex = 16;
            byte4.Text = "00";
            byte4.TextAlign = HorizontalAlignment.Center;
            byte4.WordWrap = false;
            // 
            // byte5
            // 
            byte5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte5.Location = new Point(178, 71);
            byte5.Name = "byte5";
            byte5.Size = new Size(33, 33);
            byte5.TabIndex = 17;
            byte5.Text = "01";
            byte5.TextAlign = HorizontalAlignment.Center;
            byte5.WordWrap = false;
            // 
            // byte6
            // 
            byte6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte6.Location = new Point(211, 71);
            byte6.Name = "byte6";
            byte6.Size = new Size(33, 33);
            byte6.TabIndex = 18;
            byte6.Text = "E5";
            byte6.TextAlign = HorizontalAlignment.Center;
            byte6.WordWrap = false;
            // 
            // richTextBoxRead
            // 
            richTextBoxRead.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxRead.Location = new Point(13, 127);
            richTextBoxRead.Name = "richTextBoxRead";
            richTextBoxRead.ReadOnly = true;
            richTextBoxRead.Size = new Size(386, 311);
            richTextBoxRead.TabIndex = 19;
            richTextBoxRead.Text = "";
            // 
            // byte7
            // 
            byte7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            byte7.Location = new Point(244, 71);
            byte7.Name = "byte7";
            byte7.Size = new Size(33, 33);
            byte7.TabIndex = 20;
            byte7.Text = "C9";
            byte7.TextAlign = HorizontalAlignment.Center;
            byte7.WordWrap = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoCheck = false;
            checkBox1.AutoSize = true;
            checkBox1.CausesValidation = false;
            checkBox1.Location = new Point(220, 33);
            checkBox1.MaximumSize = new Size(20, 20);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 21;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(350, 71);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(49, 33);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonClear_Click;
            // 
            // portNumber
            // 
            portNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            portNumber.Location = new Point(158, 22);
            portNumber.Mask = "9999";
            portNumber.Name = "portNumber";
            portNumber.Size = new Size(53, 33);
            portNumber.TabIndex = 23;
            portNumber.Text = "502";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(145, 24);
            label1.Name = "label1";
            label1.Size = new Size(16, 25);
            label1.TabIndex = 24;
            label1.Text = ":";
            // 
            // WinFormModbusOverTCP_test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(label1);
            Controls.Add(portNumber);
            Controls.Add(buttonClear);
            Controls.Add(checkBox1);
            Controls.Add(byte7);
            Controls.Add(richTextBoxRead);
            Controls.Add(byte6);
            Controls.Add(byte5);
            Controls.Add(byte4);
            Controls.Add(byte3);
            Controls.Add(byte2);
            Controls.Add(byte1);
            Controls.Add(byte0);
            Controls.Add(buttonSend);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonConnect);
            Controls.Add(ipAddress);
            MaximizeBox = false;
            Name = "WinFormModbusOverTCP_test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormModbusOverTCP_test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox ipAddress;
        private Button buttonConnect;
        private Button buttonDisconnect;
        private Button buttonSend;
        private TextBox byte0;
        private TextBox byte1;
        private TextBox byte2;
        private TextBox byte3;
        private TextBox byte4;
        private TextBox byte5;
        private TextBox byte6;
        private RichTextBox richTextBoxRead;
        private TextBox byte7;
        private CheckBox checkBox1;
        private Button buttonClear;
        private MaskedTextBox portNumber;
        private Label label1;
    }
}
