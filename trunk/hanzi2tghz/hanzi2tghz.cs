
using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class hanzi2tghz
{
	public string hz2pyLatex (string strin){
		List<string> tones = hz2py(strin);
		string output = "";
		
		output += "%%!TEX encoding = UTF-8 Unicode\n";
		output += "\\documentclass[12p]{article}\n";
		output += "\\usepackage{CJKutf8}\n\n"; 
		output += "\\newcommand{\\1}{\\={}}\n";
		output += "\\newcommand{\\2}{\\'{}}\n";
		output += "\\newcommand{\\3}{\\v{}}\n";
		output += "\\newcommand{\\4}{\\`{}}\n";
		output += "\\newcommand{\\5}{\\.{}}\n";
		output += @"\newcommand{\ac}[2]{$\stackrel{\textrm{\raisebox{-0.5em}[0.25em][-0em]{#1}}}{\textrm{\raisebox{0em}[0.75em][0.75em]{#2}}}$\hspace{0em}}" + "\n\n";
		output += "\\begin{document}\n"; 
		output += "\\begin{CJK*}{UTF8}{gbsn}\n\n";

		for(int i = 0; i != strin.Length; i++){
			output += @"\ac{";
			foreach(char c in tones[i]){
				if (c != '0'){
					output += @"\" + c;	
				}
			}
			output += @"}{";
			output += strin[i];
			output += @"}";
			
		}

		output += "\n\\end{CJK*}\n"; 
		output += "\\end{document}\n";		

		
		return output;
	}

	private string cedictloc;
	private string overwrite;
	private int longestword;
	private Dictionary <string,string> map;

	
	static public void Main() {
		System.Console.WriteLine("Hanzi 2 Tonegraphed Hanzi");	
		Application.Run(new Mainfrm());
	}
	
	public hanzi2tghz (){
		longestword = 0;
		Console.WriteLine("Creating Dicionary ...");
		map = new Dictionary<string, string>();
cedictloc = "cedict_ts.u8"; // Default location for dictionary
		if(File.Exists(cedictloc) != true) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Open Dictionary ...";
			dialog.Filter = "UTF-8 (*.u8)|*.u8|All Files (*.*)|*.*";
			if((dialog.ShowDialog() == DialogResult.OK) && (dialog.FileName != string.Empty)){
				cedictloc = dialog.FileName;
				//Console.WriteLine(dialog.FileName);
			} else {
				Application.Exit();	
			}
		}
		
		FileStream fin = new FileStream(cedictloc, FileMode.Open);
		StreamReader stream = new StreamReader(fin, Encoding.UTF8);
		string line;
		while ((line = stream.ReadLine()) != null){
			if (line[0] == '#'){
				continue;
			} else {
				string[] dictline = line.Split(new char[] {' '});
				string simp = dictline[0];
				if (simp.Length > longestword) longestword = simp.Length;
//				if (simp.Length == 20) Console.WriteLine(simp);
				string trad = dictline[1];
				string pinyin = "";
				for(int i = 0; i != simp.Length; i++){
					pinyin += pinyin2tones(dictline[2+i]) + " ";		
				}
				
				if (!map.ContainsKey(simp)){
					map.Add(simp, pinyin);
				} else {
					string newpinyin = "";
					string[] tones = map[simp].Split(new char[] {' '});
					for(int i = 0; i != simp.Length; i++){
						if(tones[i].Contains(pinyin2tones(dictline[2+i]))){
							newpinyin += tones[i] + " ";
						} else {
							newpinyin += tones[i] + pinyin2tones(dictline[2+i]) +" ";
						}
						map[simp] = newpinyin.Trim();
					}
					
				}
				
				if (!map.ContainsKey(trad)){
					map.Add(trad, pinyin);
				} else {
					string newpinyin = "";
					string[] tones = map[trad].Split(new char[] {' '});
					for(int i = 0; i != trad.Length; i++){
						if(tones[i].Contains(pinyin2tones(dictline[2+i]))){
							newpinyin += tones[i] + " ";
						} else {
							newpinyin += tones[i] + pinyin2tones(dictline[2+i]) +" ";
						}
						map[trad] = newpinyin.Trim();
					}
					
				}
			}
		}
		fin.Close();
//		Console.WriteLine(longestword);
		Console.WriteLine("Finished Dictionary.");
overwrite = "ToneCorrections.txt"; // Default location for dictionary
		
		if(File.Exists(overwrite) != true) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Open Tone Corrections ...";
			dialog.Filter = "UTF-8 (*.txt)|*.txt|All Files (*.*)|*.*";
			if((dialog.ShowDialog() == DialogResult.OK) && (dialog.FileName != string.Empty)){
				overwrite = dialog.FileName;
				//Console.WriteLine(dialog.FileName);
			} else {
				overwrite = "";	
			}
		}

		if (overwrite != ""){
			FileStream finwr = new FileStream(overwrite, FileMode.Open);
			StreamReader streamwr = new StreamReader(finwr, Encoding.UTF8);
			
			while ((line = streamwr.ReadLine()) != null){
                try
                {
                    if (line[0] == '#')
                    {
                        continue;
                    }
                    else
                    {
                        string[] dictline = line.Split(new char[] { ' ' });

                        string chars = dictline[0];

                        string pinyin = "";
                        for (int i = 0; i != chars.Length; i++)
                        {
                            pinyin += pinyin2tones(dictline[1 + i]) + " ";
                        }

                        if (!map.ContainsKey(chars))
                        {
                            map.Add(chars, pinyin);
                        }
                        else
                        {
                            map[chars] = pinyin.Trim();
                        }
                    }
                }
                catch { }
			}
			finwr.Close();
		}

		
		
		
		/*foreach (var pair in map){
			Console.WriteLine("{0}, {1}", pair.Key, pair.Value);	
		}*/
	}
	
	public string hz2tones(string strin){
		List <string> pinyin = hz2py(strin);
		string output = "";
		foreach(string s in pinyin){
			output += s + " ";
		}
		return output;
	}
		
		
	private List<string> hz2py(string strin){
        List<string> strout = new List<string>();
		
		int numchartest = 0;
		for (int strptr = 0;
		     strptr < strin.Length;
		     strptr += numchartest)
		{
//			Console.Write(strptr);
			string pinyin = "";
			for(numchartest = Math.Min(longestword, strin.Length - strptr);
			    numchartest != 0;
			    --numchartest)
			{
//				Console.Write(numchartest);
				string findchar = strin.Substring(strptr, numchartest);
				if (map.ContainsKey(findchar)){
					pinyin += map[findchar];
//					Console.WriteLine(map[findchar] + ".");
					break;
				} else {
					continue;	
				}
			}
//			Console.Write(numchartest);
			if (pinyin == ""){
				strout.Add("0");// += "0 ";	
				numchartest = 1;
			} else {
				foreach(string str in pinyin.Split(new char[]{' '})){
					if (str.Length == 0) continue; // serious hack
					//Console.WriteLine(str.Trim() +"." + str.Length);
					strout.Add(str);	
				}
				//strout += pinyin + " ";
			}
		}
		return strout;
	}
	
	private static string pinyin2tones(string pinyin){
		string strout = "";
		foreach(char c in pinyin){
			if(char.IsDigit(c)){
				strout += c;
			}
		}
		
		if (strout == ""){
			strout += "0";	
		}
		return strout;
	}
	
	public string hz2pywordxml (string strin){
		List<string> tones = hz2py(strin);
		string output = "";

		output += data.wordxmlheader();

		for(int i = 0; i != strin.Length; i++){
			foreach(char c in tones[i]){
				if (c != '0'){
					output += data.withtone(strin[i].ToString(), int.Parse(c.ToString()));
				} else {
					output += data.notone(strin[i].ToString());
				}
			}			
		}

		output += data.wordxmlfooter();		
		return output;
	}
}
