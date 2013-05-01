
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Practica7
{

	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
			
		}
			
		void CalificarClick(object sender, EventArgs e)
		{
			int puntos = 0;
			
			if (this.RadioButton2.Checked){
				puntos ++; 
			}
			 
			if (this.respuesta2.Text=="4"){
		  		puntos ++; 
			}
				
			if (this.tepanyaki.Checked){
				puntos ++; 
			}
		
			if (this.papas.Checked){
		    	puntos ++; 
			}
			
			
		//	this.respuesta4.SelectionAction;
			DateTime respuesta4 = this.respuesta4.Value;
			string fechaseleccionada = respuesta4 .ToShortDateString();
			if (fechaseleccionada== "16/09/1810"){
				puntos ++;
			}
			
			aciertos.Text = puntos.ToString();
		}
		
		
	}
	
}
