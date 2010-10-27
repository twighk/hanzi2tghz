using System;
using System.Windows.Forms;
	

public class Outputfrm : Form
{
	TextBox hzoutput;
	string original;
	
	public Outputfrm (string str)
	{
		this.Resize += new EventHandler(this.CallFrmResize);
		Text = "hanzi2tghz - Output"; // Title Bar
		original = str;
		
		//Button
		Button reset = new Button();
		reset.Text = "Reset";
//		reset.Parent = this;
		reset.Dock = DockStyle.Bottom;
//		reset.Anchor = AnchorStyles.Bottom;
		reset.Click += new EventHandler (this.ResetOnClick);
		this.Controls.Add(reset);
		//Label
		hzoutput = new TextBox();
		hzoutput.Parent = this;
		hzoutput.Dock = DockStyle.Fill;
		hzoutput.Text = str;
		hzoutput.Multiline = true;
		hzoutput.ScrollBars = ScrollBars.Both;
		//hzinput.Padding = new Padding(5);
		this.Controls.Add(hzoutput);
	}
	
	void ResetOnClick(object sender, EventArgs e){
		hzoutput.Text = original;
	}
	
	void CallFrmResize(object sender, EventArgs e){;}
}


