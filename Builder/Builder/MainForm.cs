/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 13.04.2024
 * Время: 11:44
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Builder
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Random rnd;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			rtb.AppendText(tb.Text+'\n');
			if (cb1.Checked==true)
			{
				if (cb2.Checked==true)
				{
					rtb.AppendText("Left Direction"+'\n');
				}
				if (cb3.Checked==true)
				{
				rtb.AppendText("Rith Direction"+'\n');
				}
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			int val;
			Boolean score;
			val=0;
			score=false;
			rnd=new Random();
			val=val+rnd.Next(100);
			
			while (score==false)
			{
			val=val+rnd.Next(100);
			if (val<=100){
				pb.Value=val;
			} else {score=true;}
			}
		}
	}
}
