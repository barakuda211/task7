﻿namespace task7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.RadioButton();
            this.rotateButton = new System.Windows.Forms.RadioButton();
            this.ScaleButton = new System.Windows.Forms.RadioButton();
            this.drawButton = new System.Windows.Forms.RadioButton();
            this.clear_button = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mesh_button = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(713, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(712, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(33, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "X";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(712, 272);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(33, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Y";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(712, 295);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(33, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Z";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(712, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Mirror";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(712, 318);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(82, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "From centre";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Default mode",
            "Rotation line",
            "Edit rotation line"});
            this.comboBox2.Location = new System.Drawing.Point(712, 341);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(83, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(711, 385);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(83, 23);
            this.save_button.TabIndex = 18;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(711, 414);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(83, 23);
            this.load_button.TabIndex = 19;
            this.load_button.Text = "Загрузить";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // moveButton
            // 
            this.moveButton.AutoSize = true;
            this.moveButton.Location = new System.Drawing.Point(713, 40);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(52, 17);
            this.moveButton.TabIndex = 20;
            this.moveButton.TabStop = true;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.CheckedChanged += new System.EventHandler(this.moveButton_CheckedChanged);
            // 
            // rotateButton
            // 
            this.rotateButton.AutoSize = true;
            this.rotateButton.Location = new System.Drawing.Point(713, 62);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(57, 17);
            this.rotateButton.TabIndex = 21;
            this.rotateButton.TabStop = true;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.CheckedChanged += new System.EventHandler(this.rotateButton_CheckedChanged);
            // 
            // ScaleButton
            // 
            this.ScaleButton.AutoSize = true;
            this.ScaleButton.Location = new System.Drawing.Point(714, 85);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(52, 17);
            this.ScaleButton.TabIndex = 22;
            this.ScaleButton.TabStop = true;
            this.ScaleButton.Text = "Scale";
            this.ScaleButton.UseVisualStyleBackColor = true;
            this.ScaleButton.CheckedChanged += new System.EventHandler(this.ScaleButton_CheckedChanged);
            // 
            // drawButton
            // 
            this.drawButton.AutoSize = true;
            this.drawButton.Location = new System.Drawing.Point(713, 108);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(50, 17);
            this.drawButton.TabIndex = 23;
            this.drawButton.TabStop = true;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.CheckedChanged += new System.EventHandler(this.drawButton_CheckedChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(713, 194);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(83, 23);
            this.clear_button.TabIndex = 24;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(767, 132);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(21, 20);
            this.countBox.TabIndex = 25;
            this.countBox.Text = "6";
            this.countBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Counter";
            // 
            // mesh_button
            // 
            this.mesh_button.Location = new System.Drawing.Point(714, 158);
            this.mesh_button.Name = "mesh_button";
            this.mesh_button.Size = new System.Drawing.Size(83, 23);
            this.mesh_button.TabIndex = 27;
            this.mesh_button.Text = "Make mesh";
            this.mesh_button.UseVisualStyleBackColor = true;
            this.mesh_button.Click += new System.EventHandler(this.mesh_button_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "sin(x)+sin(y)",
            "sin(x)*cos(y)"});
            this.comboBox3.Location = new System.Drawing.Point(816, 13);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(169, 21);
            this.comboBox3.TabIndex = 28;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Redraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(942, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 20);
            this.textBox5.TabIndex = 40;
            this.textBox5.Text = "4";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ysteps:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(820, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Xsteps:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(863, 92);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(30, 20);
            this.textBox6.TabIndex = 37;
            this.textBox6.Text = "4";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(928, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 20);
            this.textBox3.TabIndex = 36;
            this.textBox3.Text = "5";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Y2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(820, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Y1:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(849, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 20);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "-5";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(928, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "5";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(899, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "X2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "X1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(849, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "-5";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(820, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 23);
            this.button8.TabIndex = 44;
            this.button8.Text = "Perspective";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(820, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 23);
            this.button7.TabIndex = 43;
            this.button7.Text = "Parallel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(820, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Projection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.mesh_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.ScaleButton);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.RadioButton moveButton;
        private System.Windows.Forms.RadioButton rotateButton;
        private System.Windows.Forms.RadioButton ScaleButton;
        private System.Windows.Forms.RadioButton drawButton;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mesh_button;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
    }
}

