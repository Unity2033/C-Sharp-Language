#include <iostream>

using namespace std;

class String
{
private:
	int size;
	char* pointer;

public:
	String()
	{
		size = 0;
		pointer = nullptr;
	}

	void operator = (const char* word)
	{
		size = strlen(word) + 1;

		if (pointer == nullptr)
		{
			pointer = new char[size];

			for (int i = 0; i < size; i++)
			{
				pointer[i] = word[i];
			}
		}
		else
		{
			char* newPointer = new char[size];

			for (int i = 0; i < size; i++)
			{
				newPointer[i] = word[i];
			}

			delete[] pointer;

			pointer = newPointer;
		}

	}

	void Append(const char* word)
	{
		size = strlen(pointer) + strlen(word) + 1;

		char* newPointer = new char[size];

		for (int i = 0; i < strlen(pointer); i++)
		{
			newPointer[i] = pointer[i];
		}

		for (int i = 0; i < strlen(word); i++)
		{
			newPointer[strlen(pointer) + i] = word[i];
		}

		delete[] pointer;

		pointer = newPointer;

	}

	int Compare(const char* word)
	{
		int count = 0;

		for (int i = 0; i < strlen(word); i++)
		{
			if (pointer[i] != word[i])
			{
				break;
			}
			else
			{
				count++;
			}
		}

		if (strlen(word) == count)
		{
			return 0;
		}

		int thisString = 0;
		int otherString = 0;

		for (int i = 0; i < strlen(pointer); i++)
		{
			thisString += pointer[i];
		}

		for (int i = 0; i < strlen(word); i++)
		{
			otherString += word[i];
		}

		if (thisString > otherString)
		{
			return 1;
		}
		else
		{
			return -1;
		}

	}

	const int& Size()
	{
		return size - 1;
	}

	const char& operator [] (const int& index)
	{
		return pointer[index];
	}

	~String()
	{
		if (pointer != nullptr)
		{
			delete[] pointer;
		}
	}

};

int main()
{
	String string;

	string = "Apple";

	for (int i = 0; i < string.Size(); i++)
	{
		cout << string[i];
	}

	string = "Banana";

	string.Append("Milk");

	cout << endl;

	for (int i = 0; i < string.Size(); i++)
	{
		cout << string[i];
	}

	cout << endl;

	string = "Lee";

	cout << string.Compare("Lef");

	return 0;

}
