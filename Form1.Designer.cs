
namespace RSA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publicKeyEdit = new System.Windows.Forms.TextBox();
            this.privateKeyEdit = new System.Windows.Forms.TextBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.generateKeys = new System.Windows.Forms.Button();
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.updateKeys = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Публічний ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Приватний ключ";
            // 
            // publicKeyEdit
            // 
            this.publicKeyEdit.Location = new System.Drawing.Point(9, 25);
            this.publicKeyEdit.Name = "publicKeyEdit";
            this.publicKeyEdit.Size = new System.Drawing.Size(275, 20);
            this.publicKeyEdit.TabIndex = 3;
            this.publicKeyEdit.TextChanged += new System.EventHandler(this.publicKeyEdit_TextChanged);
            // 
            // privateKeyEdit
            // 
            this.privateKeyEdit.Location = new System.Drawing.Point(300, 25);
            this.privateKeyEdit.Name = "privateKeyEdit";
            this.privateKeyEdit.Size = new System.Drawing.Size(274, 20);
            this.privateKeyEdit.TabIndex = 4;
            this.privateKeyEdit.TextChanged += new System.EventHandler(this.privateKeyEdit_TextChanged);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(9, 60);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(275, 125);
            this.inputText.TabIndex = 5;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(300, 60);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(275, 125);
            this.outputText.TabIndex = 6;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // generateKeys
            // 
            this.generateKeys.Location = new System.Drawing.Point(9, 199);
            this.generateKeys.Name = "generateKeys";
            this.generateKeys.Size = new System.Drawing.Size(106, 28);
            this.generateKeys.TabIndex = 7;
            this.generateKeys.Text = "Створити ключі";
            this.generateKeys.UseVisualStyleBackColor = true;
            this.generateKeys.Click += new System.EventHandler(this.generateKeys_Click);
            // 
            // encode
            // 
            this.encode.Enabled = false;
            this.encode.Location = new System.Drawing.Point(300, 199);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(106, 28);
            this.encode.TabIndex = 8;
            this.encode.Text = "Зашифрувати";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.Enabled = false;
            this.decode.Location = new System.Drawing.Point(468, 199);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(106, 28);
            this.decode.TabIndex = 9;
            this.decode.Text = "Розшифрувати";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // updateKeys
            // 
            this.updateKeys.Enabled = false;
            this.updateKeys.Location = new System.Drawing.Point(178, 199);
            this.updateKeys.Name = "updateKeys";
            this.updateKeys.Size = new System.Drawing.Size(106, 28);
            this.updateKeys.TabIndex = 10;
            this.updateKeys.Text = "Оновити ключі";
            this.updateKeys.UseVisualStyleBackColor = true;
            this.updateKeys.Click += new System.EventHandler(this.updateKeys_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 259);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Kadzup/RSA";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.updateKeys);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.generateKeys);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.privateKeyEdit);
            this.Controls.Add(this.publicKeyEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox publicKeyEdit;
        private System.Windows.Forms.TextBox privateKeyEdit;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button generateKeys;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Button updateKeys;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

