﻿
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace OMGPonies
{
	/// <summary>
	/// Description of addServantForm.
	/// </summary>
	public partial class addServantForm : Form
	{
		public addServantForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TbPaymentRate_TextChanged(object sender, EventArgs e)
		{
			SortedSet<char> sSet = new SortedSet<char>();
			
		}
	}
}
