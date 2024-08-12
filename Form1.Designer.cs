namespace FormularioContacto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button SendButton;
            LabelNombre = new Label();
            LabelEmail = new Label();
            LabelMensaje = new Label();
            TextBoxName = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxMessage = new RichTextBox();
            LabelEstado = new Label();
            SendButton = new Button();
            SuspendLayout();
            // 
            // SendButton
            // 
            SendButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendButton.Location = new Point(39, 337);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(329, 43);
            SendButton.TabIndex = 3;
            SendButton.Text = "Enviar";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += button1_Click;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Century Gothic", 9F);
            LabelNombre.Location = new Point(39, 36);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(72, 20);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Font = new Font("Century Gothic", 9F);
            LabelEmail.Location = new Point(39, 103);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(148, 20);
            LabelEmail.TabIndex = 1;
            LabelEmail.Text = "Correo Eléctronico";
            // 
            // LabelMensaje
            // 
            LabelMensaje.AutoSize = true;
            LabelMensaje.Font = new Font("Century Gothic", 9F);
            LabelMensaje.Location = new Point(39, 184);
            LabelMensaje.Name = "LabelMensaje";
            LabelMensaje.Size = new Size(76, 20);
            LabelMensaje.TabIndex = 2;
            LabelMensaje.Text = "Mensaje:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(39, 59);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(329, 27);
            TextBoxName.TabIndex = 4;
            TextBoxName.TextChanged += TextBoxName_TextChanged;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(39, 126);
            TextBoxEmail.Multiline = true;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(329, 27);
            TextBoxEmail.TabIndex = 5;
            // 
            // TextBoxMessage
            // 
            TextBoxMessage.Location = new Point(39, 207);
            TextBoxMessage.Name = "TextBoxMessage";
            TextBoxMessage.Size = new Size(329, 115);
            TextBoxMessage.TabIndex = 6;
            TextBoxMessage.Text = "";
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(39, 401);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 20);
            LabelEstado.TabIndex = 8;
            LabelEstado.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(LabelEstado);
            Controls.Add(TextBoxMessage);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxName);
            Controls.Add(SendButton);
            Controls.Add(LabelMensaje);
            Controls.Add(LabelEmail);
            Controls.Add(LabelNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNombre;
        private Label LabelEmail;
        private Label LabelMensaje;
        private Button SendButton;
        private TextBox TextBoxName;
        private TextBox TextBoxEmail;
        private RichTextBox TextBoxMessage;
        private Label LabelEstado;
    }
}
