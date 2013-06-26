using System;

	public static class data{
		public static string notone(string a){
					string output = "";
					output += @"
						<w:r>
							<w:rPr>
								<w:rFonts w:eastAsiaTheme=""minorEastAsia""/>
								<w:i/>
								<w:lang w:val=""en-GB""/>
							</w:rPr>
							<w:t xml:space=""preserve"">";
					output += a;
					output += @" </w:t>
						</w:r>
";
			return output.Replace(Environment.NewLine,"");
		}
	
		public static string withtone(string a, int t){
			string output = "";
output += @"
				<m:oMath>
							<m:acc>
								<m:accPr>
									<m:chr m:val=""";
						
					switch(t){
					case 1:
						output += "&#772;";
						break;
					case 2:
						output += "&#769;";
						break;						
					case 3:
						output += "&#780;";
						break;						
					case 4:
						output += "&#768;";
						break;
					case 5:
						output += "&#775;";
						break;						
					}
						
						
						
					output += @"""/>
									<m:ctrlPr>
										<w:rPr>
											<w:rFonts w:ascii=""Cambria Math"" w:eastAsiaTheme=""minorEastAsia"" w:hAnsi=""Cambria Math""/>
											<w:i/>
											<w:lang w:val=""en-GB""/>
										</w:rPr>
									</m:ctrlPr>
								</m:accPr>
								<m:e>
									<m:r>
										<m:rPr>
											<m:sty m:val=""p""/>
										</m:rPr>
										<w:rPr>
											<w:rFonts w:ascii=""Cambria Math"" w:eastAsia=""MingLiU"" w:hAnsi=""Cambria Math"" w:cs=""MingLiU"" w:hint=""eastAsia""/>
											<w:sz w:val=""20""/>
											<w:szCs w:val=""20""/>
										</w:rPr>
										<m:t>";
					output += a;
					output += @"</m:t>
									</m:r>
								</m:e>
							</m:acc>
						</m:oMath>
						<w:r>
							<w:rPr>
								<w:rFonts w:eastAsiaTheme=""minorEastAsia""/>
								<w:i/>
								<w:lang w:val=""en-GB""/>
							</w:rPr>
							<w:t xml:space=""preserve""> </w:t>
						</w:r>
";	
		return output.Replace(Environment.NewLine,"").Replace("\t","");
	}
	
		public static  string wordxmlheader(){
		string output = "";
		output += 
@"<pkg:package xmlns:pkg=""http://schemas.microsoft.com/office/2006/xmlPackage"">
	<pkg:part pkg:name=""/_rels/.rels"" pkg:contentType=""application/vnd.openxmlformats-package.relationships+xml"" pkg:padding=""512"">
		<pkg:xmlData>
			<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships"">
				<Relationship Id=""rId3"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties"" Target=""docProps/app.xml""/>
				<Relationship Id=""rId2"" Type=""http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties"" Target=""docProps/core.xml""/>
				<Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument"" Target=""word/document.xml""/>
			</Relationships>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/word/_rels/document.xml.rels"" pkg:contentType=""application/vnd.openxmlformats-package.relationships+xml"" pkg:padding=""256"">
		<pkg:xmlData>
			<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships"">
				<Relationship Id=""rId3"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings"" Target=""settings.xml""/>
				<Relationship Id=""rId2"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles"" Target=""styles.xml""/>
				<Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml"" Target=""../customXml/item1.xml""/>
				<Relationship Id=""rId6"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme"" Target=""theme/theme1.xml""/>
				<Relationship Id=""rId5"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable"" Target=""fontTable.xml""/>
				<Relationship Id=""rId4"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings"" Target=""webSettings.xml""/>
			</Relationships>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/word/document.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml"">
		<pkg:xmlData>
			<w:document xmlns:ve=""http://schemas.openxmlformats.org/markup-compatibility/2006"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns:m=""http://schemas.openxmlformats.org/officeDocument/2006/math"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:wp=""http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing"" xmlns:w10=""urn:schemas-microsoft-com:office:word"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"" xmlns:wne=""http://schemas.microsoft.com/office/word/2006/wordml"">
				<w:body>
					<w:p w:rsidR=""00926B52"" w:rsidRPr=""002F5F5A"" w:rsidRDefault=""003043DB"">

";
		return @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<?mso-application progid=""Word.Document""?>
" + output.Replace(Environment.NewLine,"").Replace("\t","");
	}
	
	
			public static string wordxmlfooter(){
				string output = "";
			output += @"
				</w:p>
					<w:sectPr w:rsidR=""00926B52"" w:rsidRPr=""002F5F5A"" w:rsidSect=""0019118C"">
						<w:pgSz w:w=""12240"" w:h=""15840""/>
						<w:pgMar w:top=""1440"" w:right=""1440"" w:bottom=""1440"" w:left=""1440"" w:header=""720"" w:footer=""720"" w:gutter=""0""/>
						<w:cols w:space=""720""/>
						<w:docGrid w:linePitch=""360""/>
					</w:sectPr>
				</w:body>
			</w:document>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/word/theme/theme1.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.theme+xml"">
		<pkg:xmlData>
			<a:theme name=""Office Theme"" xmlns:a=""http://schemas.openxmlformats.org/drawingml/2006/main"">
				<a:themeElements>
					<a:clrScheme name=""Office"">
						<a:dk1>
							<a:sysClr val=""windowText"" lastClr=""000000""/>
						</a:dk1>
						<a:lt1>
							<a:sysClr val=""window"" lastClr=""FFFFFF""/>
						</a:lt1>
						<a:dk2>
							<a:srgbClr val=""1F497D""/>
						</a:dk2>
						<a:lt2>
							<a:srgbClr val=""EEECE1""/>
						</a:lt2>
						<a:accent1>
							<a:srgbClr val=""4F81BD""/>
						</a:accent1>
						<a:accent2>
							<a:srgbClr val=""C0504D""/>
						</a:accent2>
						<a:accent3>
							<a:srgbClr val=""9BBB59""/>
						</a:accent3>
						<a:accent4>
							<a:srgbClr val=""8064A2""/>
						</a:accent4>
						<a:accent5>
							<a:srgbClr val=""4BACC6""/>
						</a:accent5>
						<a:accent6>
							<a:srgbClr val=""F79646""/>
						</a:accent6>
						<a:hlink>
							<a:srgbClr val=""0000FF""/>
						</a:hlink>
						<a:folHlink>
							<a:srgbClr val=""800080""/>
						</a:folHlink>
					</a:clrScheme>
					<a:fontScheme name=""Office"">
						<a:majorFont>
							<a:latin typeface=""Cambria""/>
							<a:ea typeface=""""/>
							<a:cs typeface=""""/>
							<a:font script=""Jpan"" typeface=""£Í£Ó «´«·«Ã«¯""/>
							<a:font script=""Hang"" typeface=""¸¼Àº °íµñ""/>
							<a:font script=""Hans"" typeface=""áä体""/>
							<a:font script=""Hant"" typeface=""ãæá¬Ù¥ô÷""/>
							<a:font script=""Arab"" typeface=""Times New Roman""/>
							<a:font script=""Hebr"" typeface=""Times New Roman""/>
							<a:font script=""Thai"" typeface=""Angsana New""/>
							<a:font script=""Ethi"" typeface=""Nyala""/>
							<a:font script=""Beng"" typeface=""Vrinda""/>
							<a:font script=""Gujr"" typeface=""Shruti""/>
							<a:font script=""Khmr"" typeface=""MoolBoran""/>
							<a:font script=""Knda"" typeface=""Tunga""/>
							<a:font script=""Guru"" typeface=""Raavi""/>
							<a:font script=""Cans"" typeface=""Euphemia""/>
							<a:font script=""Cher"" typeface=""Plantagenet Cherokee""/>
							<a:font script=""Yiii"" typeface=""Microsoft Yi Baiti""/>
							<a:font script=""Tibt"" typeface=""Microsoft Himalaya""/>
							<a:font script=""Thaa"" typeface=""MV Boli""/>
							<a:font script=""Deva"" typeface=""Mangal""/>
							<a:font script=""Telu"" typeface=""Gautami""/>
							<a:font script=""Taml"" typeface=""Latha""/>
							<a:font script=""Syrc"" typeface=""Estrangelo Edessa""/>
							<a:font script=""Orya"" typeface=""Kalinga""/>
							<a:font script=""Mlym"" typeface=""Kartika""/>
							<a:font script=""Laoo"" typeface=""DokChampa""/>
							<a:font script=""Sinh"" typeface=""Iskoola Pota""/>
							<a:font script=""Mong"" typeface=""Mongolian Baiti""/>
							<a:font script=""Viet"" typeface=""Times New Roman""/>
							<a:font script=""Uigh"" typeface=""Microsoft Uighur""/>
						</a:majorFont>
						<a:minorFont>
							<a:latin typeface=""Calibri""/>
							<a:ea typeface=""""/>
							<a:cs typeface=""""/>
							<a:font script=""Jpan"" typeface=""£Í£Ó Ù¥ðÈ""/>
							<a:font script=""Hang"" typeface=""¸¼Àº °íµñ""/>
							<a:font script=""Hans"" typeface=""áä体""/>
							<a:font script=""Hant"" typeface=""ãæá¬Ù¥ô÷""/>
							<a:font script=""Arab"" typeface=""Arial""/>
							<a:font script=""Hebr"" typeface=""Arial""/>
							<a:font script=""Thai"" typeface=""Cordia New""/>
							<a:font script=""Ethi"" typeface=""Nyala""/>
							<a:font script=""Beng"" typeface=""Vrinda""/>
							<a:font script=""Gujr"" typeface=""Shruti""/>
							<a:font script=""Khmr"" typeface=""DaunPenh""/>
							<a:font script=""Knda"" typeface=""Tunga""/>
							<a:font script=""Guru"" typeface=""Raavi""/>
							<a:font script=""Cans"" typeface=""Euphemia""/>
							<a:font script=""Cher"" typeface=""Plantagenet Cherokee""/>
							<a:font script=""Yiii"" typeface=""Microsoft Yi Baiti""/>
							<a:font script=""Tibt"" typeface=""Microsoft Himalaya""/>
							<a:font script=""Thaa"" typeface=""MV Boli""/>
							<a:font script=""Deva"" typeface=""Mangal""/>
							<a:font script=""Telu"" typeface=""Gautami""/>
							<a:font script=""Taml"" typeface=""Latha""/>
							<a:font script=""Syrc"" typeface=""Estrangelo Edessa""/>
							<a:font script=""Orya"" typeface=""Kalinga""/>
							<a:font script=""Mlym"" typeface=""Kartika""/>
							<a:font script=""Laoo"" typeface=""DokChampa""/>
							<a:font script=""Sinh"" typeface=""Iskoola Pota""/>
							<a:font script=""Mong"" typeface=""Mongolian Baiti""/>
							<a:font script=""Viet"" typeface=""Arial""/>
							<a:font script=""Uigh"" typeface=""Microsoft Uighur""/>
						</a:minorFont>
					</a:fontScheme>
					<a:fmtScheme name=""Office"">
						<a:fillStyleLst>
							<a:solidFill>
								<a:schemeClr val=""phClr""/>
							</a:solidFill>
							<a:gradFill rotWithShape=""1"">
								<a:gsLst>
									<a:gs pos=""0"">
										<a:schemeClr val=""phClr"">
											<a:tint val=""50000""/>
											<a:satMod val=""300000""/>
										</a:schemeClr>
									</a:gs>
									<a:gs pos=""35000"">
										<a:schemeClr val=""phClr"">
											<a:tint val=""37000""/>
											<a:satMod val=""300000""/>
										</a:schemeClr>
									</a:gs>
									<a:gs pos=""100000"">
										<a:schemeClr val=""phClr"">
											<a:tint val=""15000""/>
											<a:satMod val=""350000""/>
										</a:schemeClr>
									</a:gs>
								</a:gsLst>
								<a:lin ang=""16200000"" scaled=""1""/>
							</a:gradFill>
							<a:gradFill rotWithShape=""1"">
								<a:gsLst>
									<a:gs pos=""0"">
										<a:schemeClr val=""phClr"">
											<a:shade val=""51000""/>
											<a:satMod val=""130000""/>
										</a:schemeClr>
									</a:gs>
									<a:gs pos=""80000"">
										<a:schemeClr val=""phClr"">
											<a:shade val=""93000""/>
											<a:satMod val=""130000""/>
										</a:schemeClr>
									</a:gs>
									<a:gs pos=""100000"">
										<a:schemeClr val=""phClr"">
											<a:shade val=""94000""/>
											<a:satMod val=""135000""/>
										</a:schemeClr>
									</a:gs>
								</a:gsLst>
								<a:lin ang=""16200000"" scaled=""0""/>
							</a:gradFill>
						</a:fillStyleLst>
						<a:lnStyleLst>
							<a:ln w=""9525"" cap=""flat"" cmpd=""sng"" algn=""ctr"">
								<a:solidFill>
									<a:schemeClr val=""phClr"">
										<a:shade val=""95000""/>
										<a:satMod val=""105000""/>
									</a:schemeClr>
								</a:solidFill>
								<a:prstDash val=""solid""/>
							</a:ln>
							<a:ln w=""25400"" cap=""flat"" cmpd=""sng"" algn=""ctr"">
								<a:solidFill>
									<a:schemeClr val=""phClr""/>
								</a:solidFill>
								<a:prstDash val=""solid""/>
							</a:ln>
							<a:ln w=""38100"" cap=""flat"" cmpd=""sng"" algn=""ctr"">
								<a:solidFill>
									<a:schemeClr val=""phClr""/>
								</a:solidFill>
								<a:prstDash val=""solid""/>
							</a:ln>
						</a:lnStyleLst>
						<a:effectStyleLst>
							<a:effectStyle>
								<a:effectLst>
									<a:outerShdw blurRad=""40000"" dist=""20000"" dir=""5400000"" rotWithShape=""0"">
										<a:srgbClr val=""000000"">
											<a:alpha val=""38000""/>
										</a:srgbClr>
									</a:outerShdw>
								</a:effectLst>
							</a:effectStyle>
							<a:effectStyle>
								<a:effectLst>
									<a:outerShdw blurRad=""40000"" dist=""23000"" dir=""5400000"" rotWithShape=""0"">
										<a:srgbClr val=""000000"">
											<a:alpha val=""35000""/>
										</a:srgbClr>
									</a:outerShdw>
								</a:effectLst>
							</a:effectStyle>
							<a:effectStyle>
								<a:effectLst>
									<a:outerShdw blurRad=""40000"" dist=""23000"" dir=""5400000"" rotWithShape=""0"">
										<a:srgbClr val=""000000"">
											<a:alpha val=""35000""/>
										</a:srgbClr>
									</a:outerShdw>
								</a:effectLst>
								<a:scene3d>
									<a:camera prst=""orthographicFront"">
										<a:rot lat=""0"" lon=""0"" rev=""0""/>
									</a:camera>
									<a:lightRig rig=""threePt"" dir=""t"">
										<a:rot lat=""0"" lon=""0"" rev=""1200000""/>
									</a:lightRig>
								</a:scene3d>
								<a:sp3d>
									<a:bevelT w=""63500"" h=""25400""/>
								</a:sp3d>
							</a:effectStyle>
						</a:effectStyleLst>
						<a:bgFillStyleLst>
							<a:solidFill>
								<a:schemeClr val=""phClr""/>
							</a:solidFill>
							<a:gradFill rotWithShape=""1"">
								<a:gsLst>
									<a:gs pos=""0"">
										<a:schemeClr val=""phClr"">
											<a:tint val=""40000""/>
											<a:satMod val=""350000""/>
										</a:schemeClr>
									</a:gs>
									<a:gs pos=""40000"">
										<a:schemeClr val=""phClr"">
											<a:tint val=""45000""/>
											<a:shade val=""99000""/>
											<a:satMod val=""350000""/>
										</a:schemeClr>
									</a:gs>
									<a:gs pos=""100000"">
										<a:schemeClr val=""phClr"">
											<a:shade val=""20000""/>
											<a:satMod val=""255000""/>
										</a:schemeClr>
									</a:gs>
								</a:gsLst>
								<a:path path=""circle"">
									<a:fillToRect l=""50000"" t=""-80000"" r=""50000"" b=""180000""/>
								</a:path>
							</a:gradFill>
							<a:gradFill rotWithShape=""1"">
								<a:gsLst>
									<a:gs pos=""0"">
										<a:schemeClr val=""phClr"">
											<a:tint val=""80000""/>
											<a:satMod val=""300000""/>
										</a:schemeClr>
									</a:gs>
									<a:gs pos=""100000"">
										<a:schemeClr val=""phClr"">
											<a:shade val=""30000""/>
											<a:satMod val=""200000""/>
										</a:schemeClr>
									</a:gs>
								</a:gsLst>
								<a:path path=""circle"">
									<a:fillToRect l=""50000"" t=""50000"" r=""50000"" b=""50000""/>
								</a:path>
							</a:gradFill>
						</a:bgFillStyleLst>
					</a:fmtScheme>
				</a:themeElements>
				<a:objectDefaults/>
				<a:extraClrSchemeLst/>
			</a:theme>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/word/settings.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml"">
		<pkg:xmlData>
			<w:settings xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns:m=""http://schemas.openxmlformats.org/officeDocument/2006/math"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w10=""urn:schemas-microsoft-com:office:word"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"" xmlns:sl=""http://schemas.openxmlformats.org/schemaLibrary/2006/main"">
				<w:zoom w:percent=""100""/>
				<w:proofState w:spelling=""clean"" w:grammar=""clean""/>
				<w:defaultTabStop w:val=""720""/>
				<w:characterSpacingControl w:val=""doNotCompress""/>
				<w:compat/>
				<w:rsids>
					<w:rsidRoot w:val=""00926B52""/>
					<w:rsid w:val=""00117EBB""/>
					<w:rsid w:val=""0019118C""/>
					<w:rsid w:val=""002F5F5A""/>
					<w:rsid w:val=""003043DB""/>
					<w:rsid w:val=""00450F50""/>
					<w:rsid w:val=""00926B52""/>
					<w:rsid w:val=""00C7299A""/>
				</w:rsids>
				<m:mathPr>
					<m:mathFont m:val=""Cambria Math""/>
					<m:brkBin m:val=""before""/>
					<m:brkBinSub m:val=""--""/>
					<m:smallFrac m:val=""off""/>
					<m:dispDef/>
					<m:lMargin m:val=""0""/>
					<m:rMargin m:val=""0""/>
					<m:defJc m:val=""centerGroup""/>
					<m:wrapIndent m:val=""1440""/>
					<m:intLim m:val=""subSup""/>
					<m:naryLim m:val=""undOvr""/>
				</m:mathPr>
				<w:themeFontLang w:val=""en-US""/>
				<w:clrSchemeMapping w:bg1=""light1"" w:t1=""dark1"" w:bg2=""light2"" w:t2=""dark2"" w:accent1=""accent1"" w:accent2=""accent2"" w:accent3=""accent3"" w:accent4=""accent4"" w:accent5=""accent5"" w:accent6=""accent6"" w:hyperlink=""hyperlink"" w:followedHyperlink=""followedHyperlink""/>
				<w:shapeDefaults>
					<o:shapedefaults v:ext=""edit"" spidmax=""4098""/>
					<o:shapelayout v:ext=""edit"">
						<o:idmap v:ext=""edit"" data=""1""/>
					</o:shapelayout>
				</w:shapeDefaults>
				<w:decimalSymbol w:val="".""/>
				<w:listSeparator w:val="",""/>
			</w:settings>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/customXml/_rels/item1.xml.rels"" pkg:contentType=""application/vnd.openxmlformats-package.relationships+xml"" pkg:padding=""256"">
		<pkg:xmlData>
			<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships"">
				<Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps"" Target=""itemProps1.xml""/>
			</Relationships>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/customXml/itemProps1.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.customXmlProperties+xml"" pkg:padding=""32"">
		<pkg:xmlData pkg:originalXmlStandalone=""no"">
			<ds:datastoreItem ds:itemID=""{4FF790A6-D61A-466E-B33F-5C8F439C856C}"" xmlns:ds=""http://schemas.openxmlformats.org/officeDocument/2006/customXml"">
				<ds:schemaRefs>
					<ds:schemaRef ds:uri=""http://schemas.openxmlformats.org/officeDocument/2006/bibliography""/>
				</ds:schemaRefs>
			</ds:datastoreItem>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/word/styles.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml"">
		<pkg:xmlData>
			<w:styles xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"">
				<w:docDefaults>
					<w:rPrDefault>
						<w:rPr>
							<w:rFonts w:asciiTheme=""minorHAnsi"" w:eastAsiaTheme=""minorHAnsi"" w:hAnsiTheme=""minorHAnsi"" w:cstheme=""minorBidi""/>
							<w:sz w:val=""22""/>
							<w:szCs w:val=""22""/>
							<w:lang w:val=""en-US"" w:eastAsia=""en-US"" w:bidi=""ar-SA""/>
						</w:rPr>
					</w:rPrDefault>
					<w:pPrDefault>
						<w:pPr>
							<w:spacing w:after=""200"" w:line=""276"" w:lineRule=""auto""/>
						</w:pPr>
					</w:pPrDefault>
				</w:docDefaults>
				<w:latentStyles w:defLockedState=""0"" w:defUIPriority=""99"" w:defSemiHidden=""1"" w:defUnhideWhenUsed=""1"" w:defQFormat=""0"" w:count=""267"">
					<w:lsdException w:name=""Normal"" w:semiHidden=""0"" w:uiPriority=""0"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 1"" w:semiHidden=""0"" w:uiPriority=""9"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 2"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 3"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 4"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 5"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 6"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 7"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 8"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""heading 9"" w:uiPriority=""9"" w:qFormat=""1""/>
					<w:lsdException w:name=""toc 1"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 2"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 3"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 4"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 5"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 6"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 7"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 8"" w:uiPriority=""39""/>
					<w:lsdException w:name=""toc 9"" w:uiPriority=""39""/>
					<w:lsdException w:name=""caption"" w:uiPriority=""35"" w:qFormat=""1""/>
					<w:lsdException w:name=""Title"" w:semiHidden=""0"" w:uiPriority=""10"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Default Paragraph Font"" w:uiPriority=""1""/>
					<w:lsdException w:name=""Subtitle"" w:semiHidden=""0"" w:uiPriority=""11"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Strong"" w:semiHidden=""0"" w:uiPriority=""22"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Emphasis"" w:semiHidden=""0"" w:uiPriority=""20"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Table Grid"" w:semiHidden=""0"" w:uiPriority=""59"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Placeholder Text"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""No Spacing"" w:semiHidden=""0"" w:uiPriority=""1"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Light Shading"" w:semiHidden=""0"" w:uiPriority=""60"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light List"" w:semiHidden=""0"" w:uiPriority=""61"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Grid"" w:semiHidden=""0"" w:uiPriority=""62"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 1"" w:semiHidden=""0"" w:uiPriority=""63"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 2"" w:semiHidden=""0"" w:uiPriority=""64"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 1"" w:semiHidden=""0"" w:uiPriority=""65"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 2"" w:semiHidden=""0"" w:uiPriority=""66"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 1"" w:semiHidden=""0"" w:uiPriority=""67"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 2"" w:semiHidden=""0"" w:uiPriority=""68"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 3"" w:semiHidden=""0"" w:uiPriority=""69"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Dark List"" w:semiHidden=""0"" w:uiPriority=""70"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Shading"" w:semiHidden=""0"" w:uiPriority=""71"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful List"" w:semiHidden=""0"" w:uiPriority=""72"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Grid"" w:semiHidden=""0"" w:uiPriority=""73"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Shading Accent 1"" w:semiHidden=""0"" w:uiPriority=""60"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light List Accent 1"" w:semiHidden=""0"" w:uiPriority=""61"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Grid Accent 1"" w:semiHidden=""0"" w:uiPriority=""62"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 1 Accent 1"" w:semiHidden=""0"" w:uiPriority=""63"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 2 Accent 1"" w:semiHidden=""0"" w:uiPriority=""64"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 1 Accent 1"" w:semiHidden=""0"" w:uiPriority=""65"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Revision"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""List Paragraph"" w:semiHidden=""0"" w:uiPriority=""34"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Quote"" w:semiHidden=""0"" w:uiPriority=""29"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Intense Quote"" w:semiHidden=""0"" w:uiPriority=""30"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Medium List 2 Accent 1"" w:semiHidden=""0"" w:uiPriority=""66"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 1 Accent 1"" w:semiHidden=""0"" w:uiPriority=""67"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 2 Accent 1"" w:semiHidden=""0"" w:uiPriority=""68"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 3 Accent 1"" w:semiHidden=""0"" w:uiPriority=""69"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Dark List Accent 1"" w:semiHidden=""0"" w:uiPriority=""70"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Shading Accent 1"" w:semiHidden=""0"" w:uiPriority=""71"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful List Accent 1"" w:semiHidden=""0"" w:uiPriority=""72"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Grid Accent 1"" w:semiHidden=""0"" w:uiPriority=""73"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Shading Accent 2"" w:semiHidden=""0"" w:uiPriority=""60"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light List Accent 2"" w:semiHidden=""0"" w:uiPriority=""61"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Grid Accent 2"" w:semiHidden=""0"" w:uiPriority=""62"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 1 Accent 2"" w:semiHidden=""0"" w:uiPriority=""63"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 2 Accent 2"" w:semiHidden=""0"" w:uiPriority=""64"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 1 Accent 2"" w:semiHidden=""0"" w:uiPriority=""65"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 2 Accent 2"" w:semiHidden=""0"" w:uiPriority=""66"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 1 Accent 2"" w:semiHidden=""0"" w:uiPriority=""67"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 2 Accent 2"" w:semiHidden=""0"" w:uiPriority=""68"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 3 Accent 2"" w:semiHidden=""0"" w:uiPriority=""69"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Dark List Accent 2"" w:semiHidden=""0"" w:uiPriority=""70"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Shading Accent 2"" w:semiHidden=""0"" w:uiPriority=""71"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful List Accent 2"" w:semiHidden=""0"" w:uiPriority=""72"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Grid Accent 2"" w:semiHidden=""0"" w:uiPriority=""73"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Shading Accent 3"" w:semiHidden=""0"" w:uiPriority=""60"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light List Accent 3"" w:semiHidden=""0"" w:uiPriority=""61"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Grid Accent 3"" w:semiHidden=""0"" w:uiPriority=""62"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 1 Accent 3"" w:semiHidden=""0"" w:uiPriority=""63"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 2 Accent 3"" w:semiHidden=""0"" w:uiPriority=""64"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 1 Accent 3"" w:semiHidden=""0"" w:uiPriority=""65"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 2 Accent 3"" w:semiHidden=""0"" w:uiPriority=""66"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 1 Accent 3"" w:semiHidden=""0"" w:uiPriority=""67"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 2 Accent 3"" w:semiHidden=""0"" w:uiPriority=""68"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 3 Accent 3"" w:semiHidden=""0"" w:uiPriority=""69"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Dark List Accent 3"" w:semiHidden=""0"" w:uiPriority=""70"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Shading Accent 3"" w:semiHidden=""0"" w:uiPriority=""71"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful List Accent 3"" w:semiHidden=""0"" w:uiPriority=""72"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Grid Accent 3"" w:semiHidden=""0"" w:uiPriority=""73"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Shading Accent 4"" w:semiHidden=""0"" w:uiPriority=""60"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light List Accent 4"" w:semiHidden=""0"" w:uiPriority=""61"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Grid Accent 4"" w:semiHidden=""0"" w:uiPriority=""62"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 1 Accent 4"" w:semiHidden=""0"" w:uiPriority=""63"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 2 Accent 4"" w:semiHidden=""0"" w:uiPriority=""64"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 1 Accent 4"" w:semiHidden=""0"" w:uiPriority=""65"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 2 Accent 4"" w:semiHidden=""0"" w:uiPriority=""66"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 1 Accent 4"" w:semiHidden=""0"" w:uiPriority=""67"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 2 Accent 4"" w:semiHidden=""0"" w:uiPriority=""68"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 3 Accent 4"" w:semiHidden=""0"" w:uiPriority=""69"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Dark List Accent 4"" w:semiHidden=""0"" w:uiPriority=""70"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Shading Accent 4"" w:semiHidden=""0"" w:uiPriority=""71"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful List Accent 4"" w:semiHidden=""0"" w:uiPriority=""72"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Grid Accent 4"" w:semiHidden=""0"" w:uiPriority=""73"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Shading Accent 5"" w:semiHidden=""0"" w:uiPriority=""60"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light List Accent 5"" w:semiHidden=""0"" w:uiPriority=""61"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Grid Accent 5"" w:semiHidden=""0"" w:uiPriority=""62"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 1 Accent 5"" w:semiHidden=""0"" w:uiPriority=""63"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 2 Accent 5"" w:semiHidden=""0"" w:uiPriority=""64"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 1 Accent 5"" w:semiHidden=""0"" w:uiPriority=""65"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 2 Accent 5"" w:semiHidden=""0"" w:uiPriority=""66"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 1 Accent 5"" w:semiHidden=""0"" w:uiPriority=""67"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 2 Accent 5"" w:semiHidden=""0"" w:uiPriority=""68"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 3 Accent 5"" w:semiHidden=""0"" w:uiPriority=""69"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Dark List Accent 5"" w:semiHidden=""0"" w:uiPriority=""70"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Shading Accent 5"" w:semiHidden=""0"" w:uiPriority=""71"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful List Accent 5"" w:semiHidden=""0"" w:uiPriority=""72"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Grid Accent 5"" w:semiHidden=""0"" w:uiPriority=""73"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Shading Accent 6"" w:semiHidden=""0"" w:uiPriority=""60"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light List Accent 6"" w:semiHidden=""0"" w:uiPriority=""61"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Light Grid Accent 6"" w:semiHidden=""0"" w:uiPriority=""62"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 1 Accent 6"" w:semiHidden=""0"" w:uiPriority=""63"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Shading 2 Accent 6"" w:semiHidden=""0"" w:uiPriority=""64"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 1 Accent 6"" w:semiHidden=""0"" w:uiPriority=""65"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium List 2 Accent 6"" w:semiHidden=""0"" w:uiPriority=""66"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 1 Accent 6"" w:semiHidden=""0"" w:uiPriority=""67"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 2 Accent 6"" w:semiHidden=""0"" w:uiPriority=""68"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Medium Grid 3 Accent 6"" w:semiHidden=""0"" w:uiPriority=""69"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Dark List Accent 6"" w:semiHidden=""0"" w:uiPriority=""70"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Shading Accent 6"" w:semiHidden=""0"" w:uiPriority=""71"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful List Accent 6"" w:semiHidden=""0"" w:uiPriority=""72"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Colorful Grid Accent 6"" w:semiHidden=""0"" w:uiPriority=""73"" w:unhideWhenUsed=""0""/>
					<w:lsdException w:name=""Subtle Emphasis"" w:semiHidden=""0"" w:uiPriority=""19"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Intense Emphasis"" w:semiHidden=""0"" w:uiPriority=""21"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Subtle Reference"" w:semiHidden=""0"" w:uiPriority=""31"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Intense Reference"" w:semiHidden=""0"" w:uiPriority=""32"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Book Title"" w:semiHidden=""0"" w:uiPriority=""33"" w:unhideWhenUsed=""0"" w:qFormat=""1""/>
					<w:lsdException w:name=""Bibliography"" w:uiPriority=""37""/>
					<w:lsdException w:name=""TOC Heading"" w:uiPriority=""39"" w:qFormat=""1""/>
				</w:latentStyles>
				<w:style w:type=""paragraph"" w:default=""1"" w:styleId=""Normal"">
					<w:name w:val=""Normal""/>
					<w:qFormat/>
					<w:rsid w:val=""0019118C""/>
				</w:style>
				<w:style w:type=""character"" w:default=""1"" w:styleId=""DefaultParagraphFont"">
					<w:name w:val=""Default Paragraph Font""/>
					<w:uiPriority w:val=""1""/>
					<w:unhideWhenUsed/>
				</w:style>
				<w:style w:type=""table"" w:default=""1"" w:styleId=""TableNormal"">
					<w:name w:val=""Normal Table""/>
					<w:uiPriority w:val=""99""/>
					<w:semiHidden/>
					<w:unhideWhenUsed/>
					<w:qFormat/>
					<w:tblPr>
						<w:tblInd w:w=""0"" w:type=""dxa""/>
						<w:tblCellMar>
							<w:top w:w=""0"" w:type=""dxa""/>
							<w:left w:w=""108"" w:type=""dxa""/>
							<w:bottom w:w=""0"" w:type=""dxa""/>
							<w:right w:w=""108"" w:type=""dxa""/>
						</w:tblCellMar>
					</w:tblPr>
				</w:style>
				<w:style w:type=""numbering"" w:default=""1"" w:styleId=""NoList"">
					<w:name w:val=""No List""/>
					<w:uiPriority w:val=""99""/>
					<w:semiHidden/>
					<w:unhideWhenUsed/>
				</w:style>
				<w:style w:type=""character"" w:styleId=""PlaceholderText"">
					<w:name w:val=""Placeholder Text""/>
					<w:basedOn w:val=""DefaultParagraphFont""/>
					<w:uiPriority w:val=""99""/>
					<w:semiHidden/>
					<w:rsid w:val=""00926B52""/>
					<w:rPr>
						<w:color w:val=""808080""/>
					</w:rPr>
				</w:style>
				<w:style w:type=""paragraph"" w:styleId=""BalloonText"">
					<w:name w:val=""Balloon Text""/>
					<w:basedOn w:val=""Normal""/>
					<w:link w:val=""BalloonTextChar""/>
					<w:uiPriority w:val=""99""/>
					<w:semiHidden/>
					<w:unhideWhenUsed/>
					<w:rsid w:val=""00926B52""/>
					<w:pPr>
						<w:spacing w:after=""0"" w:line=""240"" w:lineRule=""auto""/>
					</w:pPr>
					<w:rPr>
						<w:rFonts w:ascii=""Tahoma"" w:hAnsi=""Tahoma"" w:cs=""Tahoma""/>
						<w:sz w:val=""16""/>
						<w:szCs w:val=""16""/>
					</w:rPr>
				</w:style>
				<w:style w:type=""character"" w:customStyle=""1"" w:styleId=""BalloonTextChar"">
					<w:name w:val=""Balloon Text Char""/>
					<w:basedOn w:val=""DefaultParagraphFont""/>
					<w:link w:val=""BalloonText""/>
					<w:uiPriority w:val=""99""/>
					<w:semiHidden/>
					<w:rsid w:val=""00926B52""/>
					<w:rPr>
						<w:rFonts w:ascii=""Tahoma"" w:hAnsi=""Tahoma"" w:cs=""Tahoma""/>
						<w:sz w:val=""16""/>
						<w:szCs w:val=""16""/>
					</w:rPr>
				</w:style>
			</w:styles>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/docProps/core.xml"" pkg:contentType=""application/vnd.openxmlformats-package.core-properties+xml"" pkg:padding=""256"">
		<pkg:xmlData>
			<cp:coreProperties xmlns:cp=""http://schemas.openxmlformats.org/package/2006/metadata/core-properties"" xmlns:dc=""http://purl.org/dc/elements/1.1/"" xmlns:dcterms=""http://purl.org/dc/terms/"" xmlns:dcmitype=""http://purl.org/dc/dcmitype/"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
				<dc:creator>hanzi2tghz</dc:creator>
				<cp:lastModifiedBy>hanzi2tghz</cp:lastModifiedBy>
				<cp:revision>2</cp:revision>
				<dcterms:created xsi:type=""dcterms:W3CDTF"">2010-12-17T18:36:00Z</dcterms:created>
				<dcterms:modified xsi:type=""dcterms:W3CDTF"">2010-12-17T18:36:00Z</dcterms:modified>
			</cp:coreProperties>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/customXml/item1.xml"" pkg:contentType=""application/xml"" pkg:padding=""32"">
		<pkg:xmlData>
			<b:Sources SelectedStyle=""\APA.XSL"" StyleName=""APA"" xmlns:b=""http://schemas.openxmlformats.org/officeDocument/2006/bibliography"" xmlns=""http://schemas.openxmlformats.org/officeDocument/2006/bibliography""/>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/word/fontTable.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml"">
		<pkg:xmlData>
			<w:fonts xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"">
				<w:font w:name=""Calibri"">
					<w:panose1 w:val=""020F0502020204030204""/>
					<w:charset w:val=""00""/>
					<w:family w:val=""swiss""/>
					<w:pitch w:val=""variable""/>
					<w:sig w:usb0=""E10002FF"" w:usb1=""4000ACFF"" w:usb2=""00000009"" w:usb3=""00000000"" w:csb0=""0000019F"" w:csb1=""00000000""/>
				</w:font>
				<w:font w:name=""Times New Roman"">
					<w:panose1 w:val=""02020603050405020304""/>
					<w:charset w:val=""00""/>
					<w:family w:val=""roman""/>
					<w:pitch w:val=""variable""/>
					<w:sig w:usb0=""E0002AFF"" w:usb1=""C0007841"" w:usb2=""00000009"" w:usb3=""00000000"" w:csb0=""000001FF"" w:csb1=""00000000""/>
				</w:font>
				<w:font w:name=""Tahoma"">
					<w:panose1 w:val=""020B0604030504040204""/>
					<w:charset w:val=""00""/>
					<w:family w:val=""swiss""/>
					<w:pitch w:val=""variable""/>
					<w:sig w:usb0=""E1002EFF"" w:usb1=""C000605B"" w:usb2=""00000029"" w:usb3=""00000000"" w:csb0=""000101FF"" w:csb1=""00000000""/>
				</w:font>
				<w:font w:name=""Cambria Math"">
					<w:panose1 w:val=""02040503050406030204""/>
					<w:charset w:val=""00""/>
					<w:family w:val=""roman""/>
					<w:pitch w:val=""variable""/>
					<w:sig w:usb0=""A00002EF"" w:usb1=""420020EB"" w:usb2=""00000000"" w:usb3=""00000000"" w:csb0=""0000009F"" w:csb1=""00000000""/>
				</w:font>
				<w:font w:name=""MingLiU"">
					<w:altName w:val=""細明體""/>
					<w:panose1 w:val=""02020509000000000000""/>
					<w:charset w:val=""88""/>
					<w:family w:val=""modern""/>
					<w:pitch w:val=""fixed""/>
					<w:sig w:usb0=""A00002FF"" w:usb1=""28CFFCFA"" w:usb2=""00000016"" w:usb3=""00000000"" w:csb0=""00100001"" w:csb1=""00000000""/>
				</w:font>
				<w:font w:name=""Cambria"">
					<w:panose1 w:val=""02040503050406030204""/>
					<w:charset w:val=""00""/>
					<w:family w:val=""roman""/>
					<w:pitch w:val=""variable""/>
					<w:sig w:usb0=""A00002EF"" w:usb1=""4000004B"" w:usb2=""00000000"" w:usb3=""00000000"" w:csb0=""0000019F"" w:csb1=""00000000""/>
				</w:font>
			</w:fonts>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/word/webSettings.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml"">
		<pkg:xmlData>
			<w:webSettings xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"">
				<w:optimizeForBrowser/>
			</w:webSettings>
		</pkg:xmlData>
	</pkg:part>
	<pkg:part pkg:name=""/docProps/app.xml"" pkg:contentType=""application/vnd.openxmlformats-officedocument.extended-properties+xml"" pkg:padding=""256"">
		<pkg:xmlData>
			<Properties xmlns=""http://schemas.openxmlformats.org/officeDocument/2006/extended-properties"" xmlns:vt=""http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes"">
				<Template>Normal</Template>
				<TotalTime>0</TotalTime>
				<Pages>1</Pages>
				<Words>3</Words>
				<Characters>18</Characters>
				<Application>Microsoft Office Word</Application>
				<DocSecurity>0</DocSecurity>
				<Lines>1</Lines>
				<Paragraphs>1</Paragraphs>
				<ScaleCrop>false</ScaleCrop>
				<HeadingPairs>
					<vt:vector size=""2"" baseType=""variant"">
						<vt:variant>
							<vt:lpstr>Title</vt:lpstr>
						</vt:variant>
						<vt:variant>
							<vt:i4>1</vt:i4>
						</vt:variant>
					</vt:vector>
				</HeadingPairs>
				<TitlesOfParts>
					<vt:vector size=""1"" baseType=""lpstr"">
						<vt:lpstr/>
					</vt:vector>
				</TitlesOfParts>
				<Company>Imperial College</Company>
				<LinksUpToDate>false</LinksUpToDate>
				<CharactersWithSpaces>20</CharactersWithSpaces>
				<SharedDoc>false</SharedDoc>
				<HyperlinksChanged>false</HyperlinksChanged>
				<AppVersion>12.0000</AppVersion>
			</Properties>
		</pkg:xmlData>
	</pkg:part>
</pkg:package>
";	
		return output.Replace(Environment.NewLine,"").Replace("\t","");
	}
	}

