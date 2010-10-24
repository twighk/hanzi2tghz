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
		//Label
		hzoutput = new TextBox();
		hzoutput.Parent = this;
		hzoutput.Dock = DockStyle.Fill;
		hzoutput.Text = str;
		hzoutput.Multiline = true;
		hzoutput.ScrollBars = ScrollBars.Both;
		//hzinput.Padding = new Padding(5);
	}
	
	void CallFrmResize(object sender, EventArgs e){;}
}


