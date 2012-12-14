using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;

public class Mainfrm : Form
{
	hanzi2tghz converter;
	TextBox hzinput;
	RadioButton latexrad;
	
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
		conv.Text = "Convert";
		conv.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
		conv.Click += new EventHandler (this.ConvOnClick);


		//Radiobuttons
		RadioButton wordrad = new RadioButton();
		wordrad.Text = "Word";
		wordrad.Checked = true;
		latexrad = new RadioButton();
		latexrad.Text = "LaTeX";
		GroupBox grp = new GroupBox();
		grp.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
		grp.Controls.Add(wordrad);
		grp.Controls.Add(latexrad);

		//Layout of group of radio buttons
		TableLayoutPanel grptlp = new TableLayoutPanel();
		grptlp.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
		grptlp.ColumnCount = 2;
		grptlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
		grptlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		grptlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		grptlp.Controls.Add(wordrad,0,0);
		grptlp.Controls.Add(latexrad,1,0);
		grptlp.Height = 35; // guess work for height of radiobuttons
		
		//TextBox
		hzinput = new TextBox();		
		hzinput.Multiline = true;
		hzinput.ScrollBars = ScrollBars.Both;
		hzinput.AutoSize = true;
		hzinput.Dock = DockStyle.Fill;
		
		TableLayoutPanel tlp = new TableLayoutPanel();
		tlp.Dock = DockStyle.Fill;
		tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
		tlp.AutoSize = false;
		this.Controls.Add(tlp);
		
		tlp.RowCount = 3;
		tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		tlp.RowStyles.Add(new RowStyle());
		tlp.Controls.Add(hzinput,0,0);
		tlp.Controls.Add(grptlp,0,1);
		tlp.Controls.Add(conv,0,2);
		
		
	}
	
	void OnExit(object sender, EventArgs e){ Close(); Application.Exit(); }
	void OnOpen(object sender, EventArgs e){
		//some code to open a file and put it into 
		OpenFileDialog dialog = new OpenFileDialog();
		dialog.Title = "Import File ...";
		dialog.Filter = "All files (*.*)|*.*";

        DialogResult ret = STAShowDialog(dialog);
		if (ret == DialogResult.OK){
			if(dialog.FileName == string.Empty){
				return;
			} else {
				FileStream fin = new FileStream(dialog.FileName, FileMode.Open);
				StreamReader streamin = new StreamReader(fin, Encoding.UTF8);
				string contents = streamin.ReadToEnd();
				hzinput.Text = contents;
				//Console.Write(dialog.FileName);	
			}
		}	
	}
	void ConvOnClick(object sender, EventArgs e){	
		//Console.WriteLine(converter.hz2pyLatex(hzinput.Text));
		
		//Latex
		if (latexrad.Checked == true){
			
			String output = converter.hz2pyLatex(hzinput.Text);
			//output = converter.hz2tones(hzinput.Text);		
			Outputfrm outfrm =  new Outputfrm(output);
			outfrm.ShowDialog();
			
			
		//Word 	
		} else { // save word document
			SaveFileDialog DialogSave = new SaveFileDialog();
			DialogSave.DefaultExt = "XML";
			DialogSave.Filter = "XML file (*.XML)|*.XML|All files (*.*)|*.*";
			DialogSave.AddExtension = true;
			DialogSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			DialogSave.RestoreDirectory = true;
			DialogSave.Title = "Save Word document as ...";
			DialogSave.OverwritePrompt = true;
			DialogSave.FileName = "hanzi2tghz-tmp";


            DialogResult ret = STAShowDialog(DialogSave);

            if (ret == DialogResult.OK){
                    StreamWriter outfile = new StreamWriter(DialogSave.FileName);
                    outfile.Write(converter.hz2pywordxml(hzinput.Text));
                    outfile.Close();
                }
           
			
			DialogSave.Dispose();
			DialogSave = null;
		}
	}
	
	void CallFrmResize(object sender, EventArgs e){FrmResize();}
	void FrmResize(){
	}

    private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;
        }


 public class DialogState

    {

        public DialogResult result;

        public FileDialog dialog;


        public void ThreadProcShowDialog()

        {

            result = dialog.ShowDialog();

        }

    }
    
}

