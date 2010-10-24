#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <algorithm>
#include <vector>
#include <utility>

using namespace std;

int main(){
	string finname ("cedict_tsbackup.u8");     
    string foutname = "cedict_ts.u8";

    ifstream fin(finname.c_str());
    ofstream fout(foutname.c_str());

	vector < pair < string, string > > tradsimpdups;
    while(fin.good()){
        string line;    
        getline(fin, line);
        
		//skip comments
        if(line[0] == '#')
            continue;
		
		// Make line a stream
		stringstream linestream(stringstream::in | stringstream::out);	linestream << line;
		// Get simp and trad chars
		string simp, trad; linestream >> simp >> trad;


		if (simp != trad){
			if (find(tradsimpdups.begin(), tradsimpdups.end(), make_pair(simp, trad)) != tradsimpdups.end()) {
				continue;
			}
			tradsimpdups.push_back(make_pair(trad, simp));
		}
		
		
		
		//get pinyin as stringstream
        size_t obracket = line.find_first_of("[");//find opening bracket
        size_t cbracket = line.find_first_of("]");//find closing bracket

		//write simp and trad
		fout << simp << " " << trad << " ";

		//newline
        fout << line.substr(obracket+1, cbracket - obracket -1) << '\n';
    }

    return 0;
}
