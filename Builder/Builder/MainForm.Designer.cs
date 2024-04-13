/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 13.04.2024
 * Время: 11:44
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Builder
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cb3;
		private System.Windows.Forms.CheckBox cb1;
		private System.Windows.Forms.CheckBox cb2;
		private System.Windows.Forms.ProgressBar pb;
		private System.Windows.Forms.Button button2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.tb = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cb3 = new System.Windows.Forms.CheckBox();
			this.cb1 = new System.Windows.Forms.CheckBox();
			this.cb2 = new System.Windows.Forms.CheckBox();
			this.pb = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtb
			// 
			this.rtb.Location = new System.Drawing.Point(3, 9);
			this.rtb.Name = "rtb";
			this.rtb.Size = new System.Drawing.Size(326, 210);
			this.rtb.TabIndex = 0;
			this.rtb.Text = "";
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(6, 242);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(322, 20);
			this.tb.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(236, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "Send";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(25, 286);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Opinion";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(354, 27);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(131, 36);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Directly";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cb3);
			this.groupBox1.Controls.Add(this.cb1);
			this.groupBox1.Controls.Add(this.cb2);
			this.groupBox1.Location = new System.Drawing.Point(365, 153);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(151, 109);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction";
			// 
			// cb3
			// 
			this.cb3.Location = new System.Drawing.Point(0, 73);
			this.cb3.Name = "cb3";
			this.cb3.Size = new System.Drawing.Size(85, 33);
			this.cb3.TabIndex = 3;
			this.cb3.Text = "Rigth";
			this.cb3.UseVisualStyleBackColor = true;
			// 
			// cb1
			// 
			this.cb1.Location = new System.Drawing.Point(0, 19);
			this.cb1.Name = "cb1";
			this.cb1.Size = new System.Drawing.Size(104, 24);
			this.cb1.TabIndex = 2;
			this.cb1.Text = "Direction";
			this.cb1.UseVisualStyleBackColor = true;
			// 
			// cb2
			// 
			this.cb2.Location = new System.Drawing.Point(0, 49);
			this.cb2.Name = "cb2";
			this.cb2.Size = new System.Drawing.Size(104, 24);
			this.cb2.TabIndex = 1;
			this.cb2.Text = "Left";
			this.cb2.UseVisualStyleBackColor = true;
			// 
			// pb
			// 
			this.pb.Location = new System.Drawing.Point(354, 97);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(162, 34);
			this.pb.Step = 1;
			this.pb.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(443, 280);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 37);
			this.button2.TabIndex = 7;
			this.button2.Text = "BAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 336);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.rtb);
			this.Name = "MainForm";
			this.Text = "Builder";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
