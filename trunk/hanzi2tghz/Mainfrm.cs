
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
		//Console.WriteLine(converter.hz2pyLatex("你们好，我是 Branch  Thomas。 我在帝国理工念物理。上个月，我跟我的朋友一起去海德公园了。里头除了有树以外还有一个很长的湖。我们在湖边儿复习物理了。太阳热极了，所以我们坐在树下。海德公园很大，人也很多。有很多人都到海德公园去休息。有的一边吃饭一边看风景，有的只是散散步。看完书以后，我们从公园到馆子去吃饭去了。我的朋友饿得不得了，所以他什么都想吃。我们是坐公共汽车到饭馆儿去的。在饭馆儿，他问我：“你都想吃什么？”我说“我想吃点儿米饭，也想吃点儿鱼。”他就问我：“你想吃（蛋）炒饭（呢）还是白饭（呢）？”。我就说“（我想吃）蛋炒饭。”另外他也点了一些广东菜和两杯中国茶。我们两点钟 才吃完饭。我们都吃很得饱，简直吃不下了。他吃饭吃得比我快，所以他比我吃得多得多。因为我们看不见窗外，所以就不清楚有没有下雨。走出饭馆儿的时候，果然下雨了。我们本来以为整天热的很不会下雨。现在下雨了，所以我们回我家了。我们一到我的家，雨就停了。没关系，我们还得复习物理。复习完了，他就走到车站，回家去了。"));
		
		
		// Status Bar
		MainMenu mainmenu = new MainMenu();
		MenuItem file = mainmenu.MenuItems.Add("&File");
		file.MenuItems.Add(new MenuItem("&Open", new EventHandler(this.OnOpen), Shortcut.CtrlO));
		file.MenuItems.Add(new MenuItem ("E&xit", new EventHandler(this.OnExit), Shortcut.CtrlX));
		Menu = mainmenu;
		
		//Button
		Button conv = new Button();
		conv.Text = "Convert";
		conv.Parent = this;
		conv.Dock = DockStyle.Bottom;
		conv.Anchor = AnchorStyles.Right;
		conv.Click += new EventHandler (this.ConvOnClick);

		//TextBox
		hzinput = new TextBox();
		hzinput.Parent = this;
		hzinput.Dock = DockStyle.Fill;
		hzinput.Multiline = true;
		//hzinput.Padding = new Padding(5);
		
		
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
		string output = converter.hz2pyLatex(hzinput.Text);
		
		Application.Run(new Outputfrm(output));
		Console.WriteLine(output);
		//output = converter.hz2tones(hzinput.Text);
		//Console.WriteLine(output);
	}
	
	void CallFrmResize(object sender, EventArgs e){FrmResize();}
	void FrmResize(){

	}
}

