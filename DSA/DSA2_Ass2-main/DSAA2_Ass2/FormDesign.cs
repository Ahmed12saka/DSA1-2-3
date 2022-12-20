namespace DSA2_Ass2
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.MapImage = new System.Windows.Forms.PictureBox();
            this.Initialize = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1024, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find Path!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(947, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(950, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1012, 308);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 20);
            this.Start.TabIndex = 3;
            this.Start.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(1012, 359);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(100, 20);
            this.Destination.TabIndex = 4;
            this.Destination.TextChanged += new System.EventHandler(this.Destination_TextChanged);
            // 
            // MapImage
            // 
            this.MapImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MapImage.ErrorImage")));
            this.MapImage.ImageLocation = "Map.png";
            this.MapImage.Location = new System.Drawing.Point(12, -15);
            this.MapImage.Name = "MapImage";
            this.MapImage.Size = new System.Drawing.Size(929, 654);
            this.MapImage.TabIndex = 5;
            this.MapImage.TabStop = false;
            this.MapImage.Click += new System.EventHandler(this.MapImage_Click);
            // 
            // Initialize
            // 
            this.Initialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Initialize.Location = new System.Drawing.Point(983, 37);
            this.Initialize.Name = "Initialize";
            this.Initialize.Size = new System.Drawing.Size(186, 59);
            this.Initialize.TabIndex = 6;
            this.Initialize.Text = "Click me to show the map roads";
            this.Initialize.UseVisualStyleBackColor = true;
            this.Initialize.Click += new System.EventHandler(this.button2_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(953, 176);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(245, 86);
            this.Message.TabIndex = 7;
            this.Message.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1051, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Info box:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Initialize);
            this.Controls.Add(this.MapImage);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Start;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.PictureBox MapImage;
        private System.Windows.Forms.Button Initialize;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
    }
}