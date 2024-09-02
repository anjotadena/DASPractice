namespace DSAPractice.ArrayAndHashing;

/**
 *
 *Design Dynamic Array (Resizable Array)
Solved 
Design a Dynamic Array (aka a resizable array) class, such as an ArrayList in Java or a vector in C++.

Your DynamicArray class should support the following operations:

DynamicArray(int capacity) will initialize an empty array with a capacity of capacity, where capacity > 0.
int get(int i) will return the element at index i. Assume that index i is valid.
void set(int i, int n) will set the element at index i to n. Assume that index i is valid.
void pushback(int n) will push the element n to the end of the array.
int popback() will pop and return the element at the end of the array. Assume that the array is non-empty.
void resize() will double the capacity of the array.
int getSize() will return the number of elements in the array.
int getCapacity() will return the capacity of the array.
If we call void pushback(int n) but the array is full, we should resize the array first.

Example 1:

Input:
["Array", 1, "getSize", "getCapacity"]

Output:
[null, 0, 1]
Example 2:

Input:
["Array", 1, "pushback", 1, "getCapacity", "pushback", 2, "getCapacity"]

Output:
[null, null, 1, null, 2]
Example 3:

Input:
["Array", 1, "getSize", "getCapacity", "pushback", 1, "getSize", "getCapacity", "pushback", 2, "getSize", "getCapacity", "get", 1, "set", 1, 3, "get", 1, "popback", "getSize", "getCapacity"]

Output:
[null, 0, 1, null, 1, 1, null, 2, 2, 2, null, 3, 3, 1, 2]
Note:

The index i provided to get(int i) and set(int i) is guranteed to be greater than or equal to 0 and less than the number of elements in the array.
 **/
class DynamicArray
{
    private int[] _value;
    private int _size;

    public DynamicArray(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity must not be less than 0");
        }

        _value = new int[capacity];
        _size = 0;
    }

    public int Get(int i)
    {
        return _value[i];
    }

    public void Set(int i, int n)
    {
        _value[i] = n;
    }

    public void PushBack(int i)
    {
        if (_size == _value.Length)
        {
            Resize();
        }

        _value[_size] = i;
        _size++;
    }

    public int PopBack()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Cannot pop from empty array");
        }

        int e = _value[_size - 1];

        _size--;

        return e;
    }

    public int GetSize()
    {
        return _size;
    }

    public int GetCapacity()
    {
        return _value.Length;
    }

    private void Resize()
    {
        int[] newArray = new int[_value.Length * 2]; // doubled

        for (int i = 0; i < _value.Length; i++)
        {
            newArray[i] = _value[i];
        }

        _value = newArray;
    }
}

public class DesignDynamicArray : ISolution
{
    
    public string Title => "Design Dynamic Array";

    public string Answer()
    {
        var dynamicArray = new DynamicArray(5);

        return "Dynamic Array";
    }

    
}
