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
//		reset.Dock = DockStyle.Bottom;
		reset.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
		reset.Click += new EventHandler (this.ResetOnClick);
//		this.Controls.Add(reset);

		//Label
		hzoutput = new TextBox();
		hzoutput.Parent = this;
		hzoutput.Dock = DockStyle.Fill;
		hzoutput.Text = str;
		hzoutput.Multiline = true;
		hzoutput.ScrollBars = ScrollBars.Both;
		//hzinput.Padding = new Padding(5);
		this.Controls.Add(hzoutput);
		hzoutput.SelectAll();
		hzoutput.HideSelection = false;
		
		
		TableLayoutPanel tlp = new TableLayoutPanel();
		tlp.Dock = DockStyle.Fill;
		tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
		tlp.AutoSize = false;
		this.Controls.Add(tlp);
		
		tlp.RowCount = 2;
		tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		tlp.RowStyles.Add(new RowStyle());
		tlp.Controls.Add(hzoutput,0,0);
		tlp.Controls.Add(reset,0,1);
		
	}

	void ResetOnClick(object sender, EventArgs e){
		hzoutput.Text = original;
	}
	
	void CallFrmResize(object sender, EventArgs e){;}
}


