﻿namespace NiViewer.Net
{
    partial class frm_Main
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
            this.cb_devices = new System.Windows.Forms.ComboBox();
            this.cb_sensor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_videomode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_mirror = new System.Windows.Forms.CheckBox();
            this.cb_fill = new System.Windows.Forms.CheckBox();
            this.cb_equal = new System.Windows.Forms.CheckBox();
            this.cb_invert = new System.Windows.Forms.CheckBox();
            this.cb_tir = new System.Windows.Forms.CheckBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device:";
            // 
            // cb_devices
            // 
            this.cb_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_devices.FormattingEnabled = true;
            this.cb_devices.Location = new System.Drawing.Point(76, 13);
            this.cb_devices.Name = "cb_devices";
            this.cb_devices.Size = new System.Drawing.Size(142, 21);
            this.cb_devices.TabIndex = 2;
            this.cb_devices.SelectedIndexChanged += new System.EventHandler(this.cb_devices_SelectedIndexChanged);
            // 
            // cb_sensor
            // 
            this.cb_sensor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sensor.FormattingEnabled = true;
            this.cb_sensor.Location = new System.Drawing.Point(76, 40);
            this.cb_sensor.Name = "cb_sensor";
            this.cb_sensor.Size = new System.Drawing.Size(142, 21);
            this.cb_sensor.TabIndex = 4;
            this.cb_sensor.SelectedIndexChanged += new System.EventHandler(this.cb_sensor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensor:";
            // 
            // cb_videomode
            // 
            this.cb_videomode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_videomode.FormattingEnabled = true;
            this.cb_videomode.Location = new System.Drawing.Point(76, 67);
            this.cb_videomode.Name = "cb_videomode";
            this.cb_videomode.Size = new System.Drawing.Size(142, 21);
            this.cb_videomode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video mode:";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(143, 230);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Update";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_mirror
            // 
            this.cb_mirror.AutoSize = true;
            this.cb_mirror.Location = new System.Drawing.Point(15, 94);
            this.cb_mirror.Name = "cb_mirror";
            this.cb_mirror.Size = new System.Drawing.Size(66, 17);
            this.cb_mirror.TabIndex = 8;
            this.cb_mirror.Text = "Mirroring";
            this.cb_mirror.UseVisualStyleBackColor = true;
            // 
            // cb_fill
            // 
            this.cb_fill.AutoSize = true;
            this.cb_fill.Location = new System.Drawing.Point(15, 117);
            this.cb_fill.Name = "cb_fill";
            this.cb_fill.Size = new System.Drawing.Size(118, 17);
            this.cb_fill.TabIndex = 9;
            this.cb_fill.Text = "Depth - Fill Shadow";
            this.cb_fill.UseVisualStyleBackColor = true;
            // 
            // cb_equal
            // 
            this.cb_equal.AutoSize = true;
            this.cb_equal.Location = new System.Drawing.Point(15, 140);
            this.cb_equal.Name = "cb_equal";
            this.cb_equal.Size = new System.Drawing.Size(154, 17);
            this.cb_equal.TabIndex = 10;
            this.cb_equal.Text = "Depth - Histogram Equalize";
            this.cb_equal.UseVisualStyleBackColor = true;
            // 
            // cb_invert
            // 
            this.cb_invert.AutoSize = true;
            this.cb_invert.Location = new System.Drawing.Point(15, 163);
            this.cb_invert.Name = "cb_invert";
            this.cb_invert.Size = new System.Drawing.Size(91, 17);
            this.cb_invert.TabIndex = 11;
            this.cb_invert.Text = "Depth - Invert";
            this.cb_invert.UseVisualStyleBackColor = true;
            // 
            // cb_tir
            // 
            this.cb_tir.AutoSize = true;
            this.cb_tir.Location = new System.Drawing.Point(15, 186);
            this.cb_tir.Name = "cb_tir";
            this.cb_tir.Size = new System.Drawing.Size(164, 17);
            this.cb_tir.TabIndex = 13;
            this.cb_tir.Text = "Depth - to Image Registration";
            this.cb_tir.UseVisualStyleBackColor = true;
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.Color.Black;
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_image.ErrorImage = null;
            this.pb_image.InitialImage = null;
            this.pb_image.Location = new System.Drawing.Point(224, 12);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(320, 240);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 15;
            this.pb_image.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 265);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.cb_tir);
            this.Controls.Add(this.cb_invert);
            this.Controls.Add(this.cb_equal);
            this.Controls.Add(this.cb_fill);
            this.Controls.Add(this.cb_mirror);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_videomode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_sensor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_devices);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "NiViewer.Net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_devices;
        private System.Windows.Forms.ComboBox cb_sensor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_videomode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckBox cb_mirror;
        private System.Windows.Forms.CheckBox cb_fill;
        private System.Windows.Forms.CheckBox cb_equal;
        private System.Windows.Forms.CheckBox cb_invert;
        private System.Windows.Forms.CheckBox cb_tir;
        private System.Windows.Forms.PictureBox pb_image;
    }
}

