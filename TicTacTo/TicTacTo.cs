// André Betz 2004
// http://www.andrebetz.de
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TicTacTo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TicTacTo : System.Windows.Forms.Form
	{
		#region Varaibles
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.Container components = null;
		private int[] Field = null;
		private int FieldSize = 9;
		#endregion
		#region Windowsgeschnoesel
		public TicTacTo()
		{
			InitializeComponent();
			Init();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TicTacTo());
		}
		#endregion
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TicTacTo));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(32, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 0;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(32, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 1;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(32, 104);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 2;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(72, 24);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 3;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(72, 64);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(40, 40);
			this.button5.TabIndex = 4;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(72, 104);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 40);
			this.button6.TabIndex = 5;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Location = new System.Drawing.Point(112, 24);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(40, 40);
			this.button7.TabIndex = 6;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Location = new System.Drawing.Point(112, 64);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(40, 40);
			this.button8.TabIndex = 7;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Location = new System.Drawing.Point(112, 104);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(40, 40);
			this.button9.TabIndex = 8;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 80);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// TicTacTo
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(186, 175);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ImeMode = System.Windows.Forms.ImeMode.On;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TicTacTo";
			this.Text = "TicTacTo  www.andrebetz.de";
			this.ResumeLayout(false);

		}
		#endregion
		#region FieldButtons
		private void button1_Click(object sender, System.EventArgs e)
		{
			SetHuman(0);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			SetHuman(1);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			SetHuman(2);
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			SetHuman(3);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			SetHuman(4);
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			SetHuman(5);
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			SetHuman(6);
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			SetHuman(7);
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			SetHuman(8);
		}
		private void Init()
		{
			Field = new int[FieldSize];
			for(int i=0;i<Field.Length;i++)
			{
				Field[i] = 0;
			}
			ShowField(Field);
		}
		private void ShowField(int[] fld)
		{
			if(fld==null)
			{
				return;
			}
			for(int i=0;i<fld.Length;i++)
			{
				SetImage(i,fld[i]);
			}
		}
		private void SetImage(int Nr,int Pic)
		{
			if((Nr<0)||(Nr>FieldSize))
			{
				return;
			}
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TicTacTo));
			System.Drawing.Image img = null;
			if(Pic == 1)
			{
				img = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			}
			else if(Pic == 2)
			{
				img = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			}

			switch(Nr)
			{
				case 0 :
					this.button1.Image = img;
					break;
				case 1 :
					this.button2.Image = img;
					break;
				case 2 :
					this.button3.Image = img;
					break;
				case 3 :
					this.button4.Image = img;
					break;
				case 4 :
					this.button5.Image = img;
					break;
				case 5 :
					this.button6.Image = img;
					break;
				case 6 :
					this.button7.Image = img;
					break;
				case 7 :
					this.button8.Image = img;
					break;
				case 8 :
					this.button9.Image = img;
					break;
			}
		}
		#endregion
		#region PlayGame
		private bool CheckValidMove(int Nr)
		{
			if(Field[Nr]==0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void SetHuman(int Nr)
		{
			if(CheckValidMove(Nr))
			{
				Field[Nr] = 1;
				int Win = CheckEndGame(Field);
				if(Win<0)
				{
					Field = GetComputerMove();
					Win = CheckEndGame(Field);
				}
				ShowField(Field);
				if(Win!=-1)
				{
					if(Win==0)
					{
						MessageBox.Show(this,"Unentschieden");
					}
					else if(Win==1)
					{
						MessageBox.Show(this,"Mensch gewonnen");
					}
					else
					{
						MessageBox.Show(this,"Computer gewonnen");
					}
					Init();
				}
			}
		}
		private int CheckEndGame(int[] fld)
		{
			if(fld==null)
			{
				return -1;
			}
			if( (fld[0]==fld[1]) &&	(fld[1]==fld[2]) && (fld[0]!=0))
			{
				return fld[0];
			}
			if( (fld[3]==fld[4]) && (fld[4]==fld[5]) && (fld[3]!=0))
			{
				return fld[3];
			}
			if( (fld[6]==fld[7]) && (fld[7]==fld[8]) && (fld[6]!=0))
			{
				return fld[6];
			}
			if( (fld[0]==fld[3]) && (fld[3]==fld[6]) && (fld[0]!=0))
			{
				return fld[0];
			}
			if( (fld[1]==fld[4]) && (fld[4]==fld[7]) && (fld[1]!=0))
			{
				return fld[1];
			}
			if( (fld[2]==fld[5]) && (fld[5]==fld[8]) && (fld[2]!=0))
			{
				return fld[2];
			}
			if( (fld[0]==fld[4]) && (fld[4]==fld[8]) && (fld[0]!=0))
			{
				return fld[0];
			}
			if( (fld[2]==fld[4]) && (fld[4]==fld[6]) && (fld[2]!=0))
			{
				return fld[2];
			}
			for(int i=0;i<fld.Length;i++)
			{
				if(fld[i]==0)
				{
					return -1;
				}
			}
			return 0;
		}
		#endregion
		#region FieldOperators
		private int[] InvertField(int[] fld)
		{
			int[] InvField = new int[FieldSize];
			for(int i=0;i<fld.Length;i++)
			{
				if(fld[i]==1)
				{
					InvField[i] = 2;
				}
				else if(fld[i]==1)
				{
					InvField[i] = 1;
				}
				else
				{
					InvField[i] = fld[i];
				}
			}
			return InvField;
		}
		private int[] RotateLeftField(int[] fld)
		{
			int[] RotateField = new int[FieldSize];
			RotateField[0] = fld[6];
			RotateField[1] = fld[3];
			RotateField[2] = fld[0];
			RotateField[3] = fld[7];
			RotateField[4] = fld[4];
			RotateField[5] = fld[1];
			RotateField[6] = fld[8];
			RotateField[7] = fld[5];
			RotateField[8] = fld[2];
			return RotateField;
		}
		private int[] MirrorYField(int[] fld)
		{
			int[] MirrorField = new int[FieldSize];
			MirrorField[0] = fld[6];
			MirrorField[1] = fld[7];
			MirrorField[2] = fld[8];
			MirrorField[3] = fld[3];
			MirrorField[4] = fld[4];
			MirrorField[5] = fld[5];
			MirrorField[6] = fld[0];
			MirrorField[7] = fld[1];
			MirrorField[8] = fld[2];
			return MirrorField;
		}
		private int[] MirrorXField(int[] fld)
		{
			fld = RotateRightField(1,fld);
			fld = MirrorYField(fld);
			fld = RotateLeftField(1,fld);
			return fld;
		}
		private int[] MirrorDiagonalField(int[] fld)
		{
			fld = RotateLeftField(1,fld);
			fld = MirrorYField(fld);
			return fld;
		}
		private int[] MirrorDiagonalField2(int[] fld)
		{
			fld = RotateRightField(1,fld);
			fld = MirrorYField(fld);
			return fld;
		}
		private int[] RotateLeftField(int n,int[] fld)
		{
			for(int i=0;i<(n%4);i++)
			{
				fld = RotateLeftField(fld);
			}
			return fld;
		}
		private int[] RotateRightField(int n,int[] fld)
		{
			for(int i=0;i<(4-(n%4));i++)
			{
				fld = RotateLeftField(fld);
			}
			return fld;
		}

		#endregion
		#region ComputerGegner
		private int[] String2Field(String strField)
		{
			char[] chrField = strField.ToCharArray();
			int[] CpField = new int[FieldSize];
			for(int i=0;i<CpField.Length;i++)
			{
				if(chrField[i]=='+')
				{
					CpField[i] = 2;
				}
				else if(chrField[i]=='o')
				{
					CpField[i] = 1;
				}
				else if(chrField[i]=='_')
				{
					CpField[i] = 3;
				}
				else
				{
					CpField[i] = 0;
				}

			}
			return CpField;
		}
		private int[] String2Field(String strField,int[] fld)
		{
			char[] chrField = strField.ToCharArray();
			int[] CpField = new int[FieldSize];
			for(int i=0;i<CpField.Length;i++)
			{
				if(chrField[i]=='+')
				{
					CpField[i] = 2;
				}
				else if(chrField[i]=='o')
				{
					CpField[i] = 1;
				}
				else if(chrField[i]=='_')
				{
					CpField[i] = fld[i];
				}
				else
				{
					CpField[i] = 0;
				}

			}
			return CpField;
		}
		private bool CompareFields(int[] fld,int[] f)
		{
			for(int i=0;i<fld.Length;i++)
			{
				if(fld[i]!=f[i]&&f[i]!=3)
				{
					return false;
				}
			}
			return true;
		}
		private int[] Transform(int Turns,int[] fld)
		{
			int[] res = null;
			int[] rot = null;
			int[] tmp = null;

			rot = RotateLeftField(Turns,fld);

			res = FindMove(rot);
			if(res!=null)
			{
				res = RotateRightField(Turns,res);
				return res;
			}

			tmp = MirrorYField(rot);
			res = FindMove(tmp);
			if(res!=null)
			{
				res = MirrorYField(res);
				res = RotateRightField(Turns,res);
				return res;
			}

			tmp = MirrorDiagonalField(rot);
			res = FindMove(tmp);
			if(res!=null)
			{
				res = MirrorDiagonalField(res);
				res = RotateRightField(Turns,res);
				return res;
			}

			return res;			
		}
		private int[] GetComputerMove()
		{
			int[] res = null;
			for(int i=0;i<4;i++)
			{
				res = Transform(i,Field);
				if(res!=null)
				{
					return res;
				}
			}
			if(res==null)
			{
				res = Field;
			}
			return res;
		}
		#endregion
		#region HardWiredMoves
		private int[] FindMove(int[] fld)
		{
			int[] res;
			if(CompareFields(fld,String2Field("o........")))
			{
				res = String2Field("o...+....");
			}
			else if(CompareFields(fld,String2Field("o..o+....")))
			{
				res = String2Field("o..o+.+..");
			}
			else if(CompareFields(fld,String2Field("o_.o+_+__")))
			{
				res = String2Field("o_+o+_+__",fld);
			}
			else if(CompareFields(fld,String2Field("o.oo+.+..")))
			{
				res = String2Field("o+oo+.+..");
			}
			else if(CompareFields(fld,String2Field("o+oo+_+._")))
			{
				res = String2Field("o+oo+_++_",fld);
			}
			else if(CompareFields(fld,String2Field("o+oo+.+o.")))
			{
				res = String2Field("o+oo+.+o+");
			}
			else if(CompareFields(fld,String2Field("o.o.+....")))
			{
				res = String2Field("o+o.+....");
			}
			else if(CompareFields(fld,String2Field("o+o_+__._")))
			{
				res = String2Field("o+o_+__+_",fld);
			}
			else if(CompareFields(fld,String2Field("o+o.+..o.")))
			{
				res = String2Field("o+o++..o.");
			}
			else if(CompareFields(fld,String2Field("o+o++._o_")))
			{
				res = String2Field("o+o+++_o_",fld);
			}
			else if(CompareFields(fld,String2Field("o+o++o.o.")))
			{
				res = String2Field("o+o++o.o+");
			}
			else if(CompareFields(fld,String2Field("o...+...o")))
			{
				res = String2Field("o..++...o");
			}
			else if(CompareFields(fld,String2Field("o__++.__o")))
			{
				res = String2Field("o__+++__o",fld);
			}
			else if(CompareFields(fld,String2Field("o..++o..o")))
			{
				res = String2Field("o.+++o..o");
			}
			else if(CompareFields(fld,String2Field("o.+++oo.o")))
			{
				res = String2Field("o.+++oo+o");
			}
			else if(CompareFields(fld,String2Field(".o.......")))
			{
				res = String2Field(".o..+....");
			}
			else if(CompareFields(fld,String2Field(".o..+..o.")))
			{
				res = String2Field(".o..+.+o.");
			}
			else if(CompareFields(fld,String2Field("_o._+_+o_")))
			{
				res = String2Field("_o+_+_+o_",fld);
			}
			else if(CompareFields(fld,String2Field(".oo.+.+o.")))
			{
				res = String2Field("+oo.+.+o.");
			}
			else if(CompareFields(fld,String2Field("+oo_+_+o.")))
			{
				res = String2Field("+oo_+_+o+",fld);
			}
			else if(CompareFields(fld,String2Field("+oo.+.+oo")))
			{
				res = String2Field("+oo++.+o+");
			}
			else if(CompareFields(fld,String2Field(".o.o+....")))
			{
				res = String2Field("+o.o+....");
			}
			else if(CompareFields(fld,String2Field("+o.o+...o")))
			{
				res = String2Field("+o+o+...o");
			}
			else if(CompareFields(fld,String2Field("+o+o+_._o")))
			{
				res = String2Field("+o+o+_+_o",fld);
			}
			else if(CompareFields(fld,String2Field("+o+o+.o.o")))
			{
				res = String2Field("+o+o+.o+o");
			}
			else if(CompareFields(fld,String2Field(".o..+...o")))
			{
				res = String2Field(".o+.+...o");
			}
			else if(CompareFields(fld,String2Field("_o+_+_._o")))
			{
				res = String2Field("_o+_+_+_o",fld);
			}
			else if(CompareFields(fld,String2Field(".o+.+.o.o")))
			{
				res = String2Field(".o+.+.o+o");
			}
			else if(CompareFields(fld,String2Field(".o+o+.o+o")))
			{
				res = String2Field("+o+o+.o+o");
			}
			else if(CompareFields(fld,String2Field("....o....")))
			{
				res = String2Field("+...o....");
			}
			else if(CompareFields(fld,String2Field("+o..o....")))
			{
				res = String2Field("+o..o..+.");
			}
			else if(CompareFields(fld,String2Field("+o..o..+o")))
			{
				res = String2Field("+o..o.++o");
			}
			else if(CompareFields(fld,String2Field("+o_.o_++o")))
			{
				res = String2Field("+o_+o_++o",fld);
			}
			else if(CompareFields(fld,String2Field("+o.oo.++o")))
			{
				res = String2Field("+o.oo+++o");
			}
			else if(CompareFields(fld,String2Field("+oo.o..+.")))
			{
				res = String2Field("+oo.o.++.");
			}
			else if(CompareFields(fld,String2Field("+oo_oo++_")))
			{
				res = String2Field("+oo_oo+++");
			}
			else if(CompareFields(fld,String2Field("+oooo.++.")))
			{
				res = String2Field("+oooo.+++");
			}
			else if(CompareFields(fld,String2Field("+.o.o....")))
			{
				res = String2Field("+.o.o.+..");
			}
			else if(CompareFields(fld,String2Field("+_o.o_+__")))
			{
				res = String2Field("+_o+o_+__",fld);
			}
			else if(CompareFields(fld,String2Field("+.ooo.+..")))
			{
				res = String2Field("+.ooo++..");
			}
			else if(CompareFields(fld,String2Field("+.ooo++.o")))
			{
				res = String2Field("+.ooo+++o");
			}
			else if(CompareFields(fld,String2Field("+oooo++..")))
			{
				res = String2Field("+oooo+++.");
			}
			else if(CompareFields(fld,String2Field("+.ooo++o.")))
			{
				res = String2Field("++ooo++o.");
			}
			else if(CompareFields(fld,String2Field("+o.oo..+.")))
			{
				res = String2Field("+o.oo+.+.");
			}
			else if(CompareFields(fld,String2Field("+o_oo+.+_")))
			{
				res = String2Field("+o_oo+++_",fld);
			}
			else if(CompareFields(fld,String2Field("+.ooo+...")))
			{
				res = String2Field("+.ooo++..");
			}
			else if(CompareFields(fld,String2Field("+..oo+.o.")))
			{
				res = String2Field("++.oo+.o.");
			}
			else if(CompareFields(fld,String2Field("++.oo+_o_")))
			{
				res = String2Field("+++oo+_o_",fld);
			}
			else if(CompareFields(fld,String2Field("++ooo+.o.")))
			{
				res = String2Field("++ooo++o.");
			}
			else if(CompareFields(fld,String2Field("+...oo...")))
			{
				res = String2Field("+..+oo...");
			}
			else if(CompareFields(fld,String2Field("+__+oo.__")))
			{
				res = String2Field("+__+oo+__",fld);
			}
			else if(CompareFields(fld,String2Field("+..+ooo..")))
			{
				res = String2Field("+.++ooo..");
			}
			else if(CompareFields(fld,String2Field("+...o...o")))
			{
				res = String2Field("+.+.o...o");
			}
			else
			{
				res = null;
			}
			return res;
		}
		#endregion
	}
}
