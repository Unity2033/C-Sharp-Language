#include <iostream>

using namespace std;

template<typename KEY, typename VALUE>
class HashTable
{
private:
    struct Node
    {
        KEY key;
        VALUE value;

        Node * next;
    };

    struct Bucket
    {
        int count;
        Node * head;
    };

    int size;
    int capacity;

    Bucket * bucket;

public:
    HashTable()
    {
        size = 0;
        capacity = 8;

        bucket = new Bucket[capacity];

        for (int i = 0; i < capacity; i++)
        {
            bucket[i].head = nullptr;
            bucket[i].count = 0;
        }
    }

    template<typename KEY>
    unsigned int hash_function(KEY key)
    {
        return (unsigned int)key % capacity;
    }

    template<>
    unsigned int hash_function(const char * key)
    {
        int sum = 0;

        for (int i = 0; *key != '\0'; i++)
        {
            sum += key[i];

            key = key + 1;
        }

        return (unsigned int)sum % capacity;
    }
};

int main()
{
    HashTable<const char*, int> hashtable;

    cout << hashtable.hash_function("Ko115frea") << endl;
    cout << hashtable.hash_function("rqwr") << endl;
    cout << hashtable.hash_function("Chirteyna") << endl;
    cout << hashtable.hash_function("C5qdqdyna") << endl;
    cout << hashtable.hash_function("C6wrrwrwyna") << endl;
    cout << hashtable.hash_function("Chi868na") << endl;

    return 0;
}
