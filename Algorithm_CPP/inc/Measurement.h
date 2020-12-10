#ifndef MEASURE_H
#define MEASURE_H


template<typename T>
class Measurement
{
public:
    Measurement(T val = T()); // Default Constrcutor.
    T getValue();
    T getValue(uint32_t idx);
    void setValue(uint32_t idx, T val);
    void setValue(T val);


private:

    T value;

};
#endif