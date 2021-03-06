#hanzi2tghz (Hanzi 2 Tone Graphed Hanzi)
hanzi2tghz takes Hanzi（汉字）and searches through a dictionary to find the tones for each word or character. 

This is then used to automatically generate a Word file or LaTeX code that puts tone graphs above the characters.

For a much improved version for Microsoft Word as an add-in, goto the [Chinese Annotator for Microsoft Word](https://twighk.github.io/tghz-word-tone-annotator/).

----

##Usage
1. Make a new folder for hanzi2tghz.
2. Download the latest [hanzi2tghz Executable](https://raw.githubusercontent.com/twighk/hanzi2tghz/master/hanzi2tghz/bin/Debug/hanzi2tghz.exe), and put it in the hanzi2tghz folder.
3. Download the [Tone Corrections File](https://raw.githubusercontent.com/twighk/hanzi2tghz/master/hanzi2tghz/bin/Debug/ToneCorrections.txt), and put it in the hanzi2tghz folder.
4. Download the UTF-8 version of the [Dictionary](http://www.mdbg.net/chindict/chindict.php?page=cedict), extract the zip file, and copy the cedict_ts.u8 to the hanzi2tghz folder.
5. The folder should now have three files in it (hanzi2tghz, ToneCorrections & cedict_ts.u8).
6. Double click the hanzi2tghz program.
7. Paste some Chinese text into the white box. 
8. Choose Word or LaTeX, and click convert.
9. If the program does not do what you expect, or you find bugs, please write about them in the [issues](https://github.com/twighk/hanzi2tghz/issues), or if you have feature requests or comments, put them there as well or [email me](http://www.google.com/recaptcha/mailhide/d?k=01NPKkqVdpvGCxT19t2FK-Zw==&c=nCA8B1q_gIq9ORG1LB4DfW-z0SdUwQXlicZ-lR7pil8= ). Thank-you 
If you are using the Word output, and are finding that it cannot decide on which tone to uses for common characters, edit the ToneCorrections file to have the chinese word, followed by a space, and then the pinyin with numbers, separated by spaces. For example: 
```
的 de5
你们好 ni3 men5 hao3
了 le5
```
----


##Output Screenshots
LaTeX Output|Word Output
------------|-----------
![LaTeX output example](http://hanzi2tghz.googlecode.com/files/OutputLaTeX.png)|![Word output example](http://hanzi2tghz.googlecode.com/files/Word2007%20output.png)

The LaTeX output puts multiple tones above the characters when it cannot determine which tone it should be from the dictionary.

The Word output puts multiple tones as multiple characters characters. It uses the 'equation tools' to put tones above the characters. This causes a few problems:
  * There is a space after every character, because otherwise Word joins the whole text onto one line, which goes off the side of the page. 
  * It is unable to put multiple tones above characters, so the characters are written out multiple times.
  * The placement of the tone is dependant on the height of the character so 一 1st tone can look a bit like 二 (see Word output example)。

To fix the 2nd point, version 0.3.0 adds an overwrite list so you can stop 了5了3，的5的2的3，得2得5得3，et cetera, and replace with it the most common version.


----


##Requirements
To use the Microsoft Word file output (.XML)
  * Microsoft Word 2007 or 2010 is needed

To use the LaTeX output you need 
  * [LaTeX](http://www.latex-project.org/)
  * [CJK Package](http://www.ctan.org/tex-archive/language/chinese/CJK/)


----


##Change Log
###Version 0.3.2
Fixed to work with windows style text for the !ToneCorrections file
###Version 0.3.1
Fixed to work on Windows 7.
###Version 0.3.0
Added Tone Corrections - This allows for new words to be added, or for preferential tones for given words to be given. This is done by putting them in a file and separating the characters from the pronunciations by spaces. e.g. 
```
的 de5
你们好 ni3 men5 hao3
```
(This version currently broken on Mac OS X)



###Version 0.2.1
Fixed to work on Windows again
###Version 0.2.0
Added the Word file output (.XML)



###Version 0.1.1
Fixed to work on Windows
###Version 0.1.0
Produces LaTeX output
