/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 10/21/2020
 * Time: 9:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace hashtableplayground
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Hashtable ht = new Hashtable();
			ht.Add("A","1");
			ht.Add("B","2");
			ht.Add("C","3");
			ht.Add("D","4");
			ht.Add("E","5");
			ht.Add("F","6");
			ht.Add("G","7");
			ht.Add("H","8");
			ht.Add("I","9");
			ht.Add("J","10");
			Text = ht["A"].GetHashCode().ToString();
			Text += ht["B"].GetHashCode().ToString();
			Text += ht["C"].GetHashCode().ToString();
			
		}
	}
}
