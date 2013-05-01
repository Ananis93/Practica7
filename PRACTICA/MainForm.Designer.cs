/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25/04/2013
 * Time: 09:13 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica7
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.Label1 = new System.Windows.Forms.Label();
			this.nombre1 = new System.Windows.Forms.TextBox();
			this.grupo = new System.Windows.Forms.Label();
			this.grupo1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.sweet = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.metal = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.respuesta2 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.gelato = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.pollo = new System.Windows.Forms.CheckBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tepanyaki = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.papas = new System.Windows.Forms.CheckBox();
			this.label14 = new System.Windows.Forms.Label();
			this.respuesta4 = new System.Windows.Forms.DateTimePicker();
			this.calificar = new System.Windows.Forms.Button();
			this.aciertos = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(0, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(100, 23);
			this.Label1.TabIndex = 42;
			// 
			// nombre1
			// 
			this.nombre1.Location = new System.Drawing.Point(58, 12);
			this.nombre1.Name = "nombre1";
			this.nombre1.Size = new System.Drawing.Size(112, 20);
			this.nombre1.TabIndex = 1;
			// 
			// grupo
			// 
			this.grupo.Location = new System.Drawing.Point(192, 14);
			this.grupo.Name = "grupo";
			this.grupo.Size = new System.Drawing.Size(55, 17);
			this.grupo.TabIndex = 2;
			this.grupo.Text = "Grupo:";
			// 
			// grupo1
			// 
			this.grupo1.FormattingEnabled = true;
			this.grupo1.Items.AddRange(new object[] {
									"A",
									"B",
									"C",
									"D",
									"E"});
			this.grupo1.Location = new System.Drawing.Point(237, 10);
			this.grupo1.Name = "grupo1";
			this.grupo1.Size = new System.Drawing.Size(121, 21);
			this.grupo1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Codigo:\r\n\r\n\r\n";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(58, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(112, 20);
			this.textBox1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(414, 25);
			this.label3.TabIndex = 41;
			this.label3.Text = "1) ¿Cual fue el primer videojuego que utilizo la funcion de guardar la partida?";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 40;
			this.label4.Text = "2) ¿Cuanto es 2+2?";
			// 
			// RadioButton1
			// 
			this.RadioButton1.Location = new System.Drawing.Point(48, 122);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(87, 26);
			this.RadioButton1.TabIndex = 8;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Mario Bros";
			this.RadioButton1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(327, 23);
			this.label5.TabIndex = 39;
			this.label5.Text = "3) ¿Cual de las siguientes comidas son vegetarianas?";
			// 
			// RadioButton2
			// 
			this.RadioButton2.Location = new System.Drawing.Point(151, 127);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(106, 16);
			this.RadioButton2.TabIndex = 10;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "Legend of Zelda";
			this.RadioButton2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(374, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 23);
			this.label6.TabIndex = 38;
			this.label6.Text = "d)";
			// 
			// sweet
			// 
			this.sweet.Location = new System.Drawing.Point(281, 125);
			this.sweet.Name = "sweet";
			this.sweet.Size = new System.Drawing.Size(87, 20);
			this.sweet.TabIndex = 12;
			this.sweet.TabStop = true;
			this.sweet.Text = "Sweet Home";
			this.sweet.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 278);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(342, 23);
			this.label7.TabIndex = 37;
			this.label7.Text = "4) ¿Cuando fue la Independencia de México?";
			// 
			// metal
			// 
			this.metal.Location = new System.Drawing.Point(392, 124);
			this.metal.Name = "metal";
			this.metal.Size = new System.Drawing.Size(87, 22);
			this.metal.TabIndex = 14;
			this.metal.TabStop = true;
			this.metal.Text = "Metal Gear";
			this.metal.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(4, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 23);
			this.label8.TabIndex = 36;
			this.label8.Text = "Nombre:";
			// 
			// respuesta2
			// 
			this.respuesta2.FormattingEnabled = true;
			this.respuesta2.Items.AddRange(new object[] {
									"22",
									"4",
									"8",
									"6"});
			this.respuesta2.Location = new System.Drawing.Point(127, 166);
			this.respuesta2.Name = "respuesta2";
			this.respuesta2.Size = new System.Drawing.Size(84, 21);
			this.respuesta2.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(100, 239);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(21, 23);
			this.label9.TabIndex = 35;
			this.label9.Text = "b)";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(237, 236);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(18, 23);
			this.label10.TabIndex = 34;
			this.label10.Text = "c)";
			// 
			// gelato
			// 
			this.gelato.Location = new System.Drawing.Point(30, 237);
			this.gelato.Name = "gelato";
			this.gelato.Size = new System.Drawing.Size(64, 18);
			this.gelato.TabIndex = 19;
			this.gelato.Text = "Gelato";
			this.gelato.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 239);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(17, 23);
			this.label11.TabIndex = 33;
			this.label11.Text = "a)";
			// 
			// pollo
			// 
			this.pollo.Location = new System.Drawing.Point(127, 231);
			this.pollo.Name = "pollo";
			this.pollo.Size = new System.Drawing.Size(109, 28);
			this.pollo.TabIndex = 21;
			this.pollo.Text = "Pollo Parmesano";
			this.pollo.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 125);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(26, 23);
			this.label12.TabIndex = 32;
			this.label12.Text = "a)";
			// 
			// tepanyaki
			// 
			this.tepanyaki.Location = new System.Drawing.Point(254, 236);
			this.tepanyaki.Name = "tepanyaki";
			this.tepanyaki.Size = new System.Drawing.Size(85, 19);
			this.tepanyaki.TabIndex = 23;
			this.tepanyaki.Text = "Tepanyaki";
			this.tepanyaki.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(127, 127);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(18, 23);
			this.label13.TabIndex = 31;
			this.label13.Text = "b)";
			// 
			// papas
			// 
			this.papas.Location = new System.Drawing.Point(354, 237);
			this.papas.Name = "papas";
			this.papas.Size = new System.Drawing.Size(134, 18);
			this.papas.TabIndex = 25;
			this.papas.Text = "Papas a la Francesa";
			this.papas.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(254, 129);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(21, 23);
			this.label14.TabIndex = 30;
			this.label14.Text = "c)";
			// 
			// respuesta4
			// 
			this.respuesta4.Location = new System.Drawing.Point(110, 304);
			this.respuesta4.Name = "respuesta4";
			this.respuesta4.Size = new System.Drawing.Size(229, 20);
			this.respuesta4.TabIndex = 27;
			// 
			// calificar
			// 
			this.calificar.Location = new System.Drawing.Point(12, 353);
			this.calificar.Name = "calificar";
			this.calificar.Size = new System.Drawing.Size(77, 25);
			this.calificar.TabIndex = 28;
			this.calificar.Text = "Calificar";
			this.calificar.UseVisualStyleBackColor = true;
			this.calificar.Click += new System.EventHandler(this.CalificarClick);
			// 
			// aciertos
			// 
			this.aciertos.Enabled = false;
			this.aciertos.Location = new System.Drawing.Point(192, 358);
			this.aciertos.Name = "aciertos";
			this.aciertos.Size = new System.Drawing.Size(136, 20);
			this.aciertos.TabIndex = 29;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(331, 237);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(17, 21);
			this.label15.TabIndex = 43;
			this.label15.Text = "d)";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(127, 358);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(63, 16);
			this.label16.TabIndex = 44;
			this.label16.Text = "Aciertos:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 407);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.aciertos);
			this.Controls.Add(this.calificar);
			this.Controls.Add(this.respuesta4);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.papas);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.tepanyaki);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pollo);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.gelato);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.respuesta2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.metal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.sweet);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.RadioButton2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.RadioButton1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.grupo1);
			this.Controls.Add(this.grupo);
			this.Controls.Add(this.nombre1);
			this.Controls.Add(this.Label1);
			this.Name = "MainForm";
			this.Text = "Practica7";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox aciertos;
		private System.Windows.Forms.Button calificar;
		private System.Windows.Forms.DateTimePicker respuesta4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox papas;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox tepanyaki;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox pollo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox gelato;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox respuesta2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton metal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton sweet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton RadioButton2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton RadioButton1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox grupo1;
		private System.Windows.Forms.Label grupo;
		private System.Windows.Forms.TextBox nombre1;
		private System.Windows.Forms.Label Label1;
	}
}
