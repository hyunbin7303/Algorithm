#ifndef FILEMANAGER_H
#define FILEMANAGER_H

#include <fstream>
#include <cstring>

using namespace std;

class FileManager
{
public:
    FileManager();
    FileManager(char *, char *, char *, int, long);
    void writeToFile(fstream&) const;
    void readFromFile(fstream &);
    void readKey();
    int size() const;
    // bool operator==(const FileManager* fm) const{
    //     return strncmp(pr.SSN, SSN, 9) ==0;
    // }

protected:
    string fileName;
    const int fnameLen;
    int year;
    ostream& writeLegibly(ostream&);
    friend ostream& operator<<(ostream& out, FileManager& fm){
        return fm.writeLegibly(out);
    }
    istream& readFromConsole(istream&);
    friend istream& operator>>(istream& in, FileManager& fm) {
        return fm.readFromConsole(in);
    }

};



// Things to do....
// Getting data from MongoDB.
// Extract it to the folder/files.

#endif