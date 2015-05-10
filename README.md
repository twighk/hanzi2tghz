=hanzi2tghz (Hanzi 2 Tone Graphed Hanzi)=
hanzi2tghz takes Hanzi（汉字）and searches through a dictionary to find the tones for each word or character. 

This is then used to automatically generate a Word file or LaTeX code that puts tone graphs above the characters.

For a much improved version for Microsoft Word as an add-in, goto [https://code.google.com/p/tghz-word-tone-annotator/].

----

==Usage==
  # Make a new folder for hanzi2tghz.
  # Download the latest [https://code.google.com/p/hanzi2tghz/downloads/list hanzi2tghz Executable], and put it in the hanzi2tghz folder.
  # Download the [https://code.google.com/p/hanzi2tghz/downloads/list Tone Corrections File], and put it in the hanzi2tghz folder.
  # Download the UTF-8 version of the [http://www.mdbg.net/chindict/chindict.php?page=cedict Dictionary], extract the zip file, and copy the cedict_ts.u8 to the hanzi2tghz folder.
  # The folder should now have three files in it (hanzi2tghz, !ToneCorrections & cedict_ts.u8).
  # Double click the hanzi2tghz program.
  # Paste some Chinese text into the white box. 
  # Choose Word or LaTeX, and click convert.
  # If the program does not do what you expect, or you find bugs, please write about them in the [https://code.google.com/p/hanzi2tghz/issues/list issues], or if you have feature requests or comments, put them there as well or [http://www.google.com/recaptcha/mailhide/d?k=01NPKkqVdpvGCxT19t2FK-Zw==&c=nCA8B1q_gIq9ORG1LB4DfW-z0SdUwQXlicZ-lR7pil8= email me]. Thank-you 
If you are using the Word output, and are finding that it cannot decide on which tone to uses for common characters, edit the ToneCorrections file to have the chinese word, followed by a space, and then the pinyin with numbers, separated by spaces. For example: 
{{{
的 de5
你们好 ni3 men5 hao3
了 le5
}}}
----


==Output Screenshots==
||LaTeX Output||Word Output||
||[https://code.google.com/p/hanzi2tghz/downloads/detail?name=Output.pdf&can=1&q= http://hanzi2tghz.googlecode.com/files/OutputLaTeX.png]||[https://code.google.com/p/hanzi2tghz/downloads/detail?name=Output.XML&can=1&q=  http://hanzi2tghz.googlecode.com/files/Word2007%20output.png] ||

The LaTeX output puts multiple tones above the characters when it cannot determine which tone it should be from the dictionary.

The Word output puts multiple tones as multiple characters characters. It uses the 'equation tools' to put tones above the characters. This causes a few problems:
  * There is a space after every character, because otherwise Word joins the whole text onto one line, which goes off the side of the page. 
  * It is unable to put multiple tones above characters, so the characters are written out multiple times.
  * The placement of the tone is dependant on the height of the character so 一 1st tone can look a bit like 二 (see Word output example)。

To fix the 2nd point, version 0.3.0 adds an overwrite list so you can stop 了5了3，的5的2的3，得2得5得3，et cetera, and replace with it the most common version.


----


==Requirements==
To use the Microsoft Word file output (.XML)
  * Microsoft Word 2007 or 2010 is needed

To use the LaTeX output you need 
  * [http://www.latex-project.org/ LaTeX]
  * [http://www.ctan.org/tex-archive/language/chinese/CJK/ CJK Package]


----


==Change Log==
===Version 0.3.2==
Fixed to work with windows style text for the !ToneCorrections file
===Version 0.3.1==
Fixed to work on Windows 7.
===Version 0.3.0==
Added Tone Corrections - This allows for new words to be added, or for preferential tones for given words to be given. This is done by putting them in a file and separating the characters from the pronunciations by spaces. e.g. 
{{{
的 de5
你们好 ni3 men5 hao3
}}}
(This version currently broken on Mac OS X)



===Version 0.2.1==
Fixed to work on Windows again
===Version 0.2.0==
Added the Word file output (.XML)



===Version 0.1.1==
Fixed to work on Windows
===Version 0.1.0==
Produces LaTeX output
