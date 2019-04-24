namespace rysowator
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
            this.Pencil_Button = new System.Windows.Forms.Button();
            this.Line_Button = new System.Windows.Forms.Button();
            this.Rect_Button = new System.Windows.Forms.Button();
            this.print_panel = new System.Windows.Forms.Panel();
            this.Color_Name = new System.Windows.Forms.Button();
            this.Pick_Color = new System.Windows.Forms.ColorDialog();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pencil_Button
            // 
            this.Pencil_Button.Image = global::rysowator.Properties.Resources.pencil;
            this.Pencil_Button.Location = new System.Drawing.Point(12, 192);
            this.Pencil_Button.Name = "Pencil_Button";
            this.Pencil_Button.Size = new System.Drawing.Size(58, 57);
            this.Pencil_Button.TabIndex = 2;
            this.Pencil_Button.UseVisualStyleBackColor = true;
            this.Pencil_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pencil_Button_MouseClick);
            this.Pencil_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pencil_Button_MouseDown);
            this.Pencil_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pencil_Button_MouseMove);
            this.Pencil_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pencil_Button_MouseUp);
            // 
            // Line_Button
            // 
            this.Line_Button.Image = global::rysowator.Properties.Resources.line;
            this.Line_Button.Location = new System.Drawing.Point(12, 35);
            this.Line_Button.Name = "Line_Button";
            this.Line_Button.Size = new System.Drawing.Size(58, 57);
            this.Line_Button.TabIndex = 0;
            this.Line_Button.UseVisualStyleBackColor = true;
            this.Line_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Line_Button_MouseClick);
            this.Line_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Line_Button_MouseDown);
            this.Line_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Line_Button_MouseUp);
            // 
            // Rect_Button
            // 
            this.Rect_Button.Image = global::rysowator.Properties.Resources.rect;
            this.Rect_Button.Location = new System.Drawing.Point(12, 112);
            this.Rect_Button.Name = "Rect_Button";
            this.Rect_Button.Size = new System.Drawing.Size(58, 57);
            this.Rect_Button.TabIndex = 1;
            this.Rect_Button.UseVisualStyleBackColor = true;
            this.Rect_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Rect_Button_MouseClick);
            this.Rect_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rect_Button_MouseDown);
            this.Rect_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rect_Button_MouseUp);
            // 
            // print_panel
            // 
            this.print_panel.BackColor = System.Drawing.SystemColors.Window;
            this.print_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.print_panel.Location = new System.Drawing.Point(94, 35);
            this.print_panel.Name = "print_panel";
            this.print_panel.Size = new System.Drawing.Size(672, 386);
            this.print_panel.TabIndex = 3;
            this.print_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Print_Panel_Paint);
            this.print_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Print_Panel_MouseDown);
            this.print_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Print_Panel_MouseMove);
            this.print_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Print_Panel_MouseUp);
            // 
            // Color_Name
            // 
            this.Color_Name.Location = new System.Drawing.Point(12, 273);
            this.Color_Name.Name = "Color_Name";
            this.Color_Name.Size = new System.Drawing.Size(58, 34);
            this.Color_Name.TabIndex = 4;
            this.Color_Name.Text = "COLOR";
            this.Color_Name.UseVisualStyleBackColor = true;
            this.Color_Name.Click += new System.EventHandler(this.Color_Name_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(12, 369);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(58, 37);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "SAVE";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Color_Name);
            this.Controls.Add(this.print_panel);
            this.Controls.Add(this.Pencil_Button);
            this.Controls.Add(this.Line_Button);
            this.Controls.Add(this.Rect_Button);
            this.Name = "Form1";
            this.Text = "RYSOWATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rect_Button;
        private System.Windows.Forms.Button Line_Button;
        private System.Windows.Forms.Button Pencil_Button;
        private System.Windows.Forms.Panel print_panel;
        private System.Windows.Forms.Button Color_Name;
        private System.Windows.Forms.ColorDialog Pick_Color;
        private System.Windows.Forms.Button Save_Button;
    }
}

