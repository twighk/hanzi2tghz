
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text;



public class Mainfrm : Form
{
	hanzi2tghz converter;
	TextBox hzinput;
	
	public Mainfrm (){
		this.Resize += new EventHandler(this.CallFrmResize);
		Text = "hanzi2tghz"; // Title Bar
		converter = new hanzi2tghz();

		
		// Status Bar
		MainMenu mainmenu = new MainMenu();
		MenuItem file = mainmenu.MenuItems.Add("&File");
		file.MenuItems.Add(new MenuItem("&Open", new EventHandler(this.OnOpen), Shortcut.CtrlO));
		file.MenuItems.Add(new MenuItem ("E&xit", new EventHandler(this.OnExit), Shortcut.CtrlX));
		Menu = mainmenu;
		
		//Button
		Button conv = new Button();
//		conv.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		conv.Text = "Convert";
//		conv.Parent = this;
		conv.Click += new EventHandler (this.ConvOnClick);
		this.Controls.Add(conv);
		conv.Dock = DockStyle.Bottom;
	
		//TextBox
		hzinput = new TextBox();
//		hzinput.Parent = this;
		
		hzinput.Multiline = true;
		//hzinput.Padding = new Padding(5);
		hzinput.ScrollBars = ScrollBars.Both;
		this.Controls.Add(hzinput);
		hzinput.Dock = DockStyle.Fill;
		
		
	}
	
	void OnExit(object sender, EventArgs e){ Close(); Application.Exit(); }
	void OnOpen(object sender, EventArgs e){
		//some code to open a file and put it into 
		OpenFileDialog dialog = new OpenFileDialog();
		dialog.Title = "Import File ...";
		dialog.Filter = "All files (*.*)|*.*";
		
		if (dialog.ShowDialog() == DialogResult.OK){
			if(dialog.FileName == string.Empty){
				return;
			} else {
				FileStream fin = new FileStream(dialog.FileName, FileMode.Open);
				StreamReader streamin = new StreamReader(fin, Encoding.UTF8);
				string contents = streamin.ReadToEnd();
				hzinput.Text = contents;
				Console.Write(dialog.FileName);	
			}
		}	
	}
	void ConvOnClick(object sender, EventArgs e){
		String output = converter.hz2pyLatex(hzinput.Text);
		Outputfrm outfrm =  new Outputfrm(output);
		outfrm.ShowDialog();
		Console.WriteLine(converter.hz2pyLatex(hzinput.Text));
		//output = converter.hz2tones(hzinput.Text);
		//Console.WriteLine(output);
	}
	
	void CallFrmResize(object sender, EventArgs e){FrmResize();}
	void FrmResize(){

	}
}

