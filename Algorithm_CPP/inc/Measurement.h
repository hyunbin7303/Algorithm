#ifndef MEASURE_H
#define MEASURE_H


template<typename T, T myVal>
class Measurement
{
public:
    Measurement(T val = myVal);
    T getValue();
    void setValue(T val);


private:

    T value;

};

// template <typename T, size_t N>
// class Array{
//     public:
//     Array();
//     size_t Size () const;
//     T& operator[] (size_t i);
//     const T& operator[] (size_t i) const;

//     private:
//     T data_[N];
//     size_t size_;

// };



#endif