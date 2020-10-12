#ifndef _BOX_H
#define _BOX_H

class Box {
public:
    Box(){}
    Box(int width, int length, int height)
        : m_width(width), m_length(length), m_height(height){} // Member initializer lists.
private:
    int m_width;
    int m_length;
    int m_height;

};


#endif