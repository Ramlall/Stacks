//The Stack functions Prof Devi taught Joe and I in class.
public class Stack
{
	private int[] mArray;
	private int mTop;

	//Constructor 
	public Stack(int maxCap)
	{
		mTop = -1;
		mArray = new int[maxCap];
	}

	//Destructor = something special when something gets deleted.

	~Stack()
	{
		for (int i = 0; i < mArray.Length; i++)
		{
			mArray[i] = 0;
		}
	}

	public void Push(int val)
	{
		if (mTop >= mArray.Length - 1)
		{
			System.Console.WriteLine("Stack is full.");
			return;
		}
		mTop = mTop + 1;
		mArray[mTop] = val;
	}

	public int Pop()
	{
		if (mTop < 0)
		{
			System.Console.WriteLine("Stack is empty");
			return 0;
		}
		int val = mArray[mTop];
		mTop = mTop - 1;
		return val;
	}

	public int GetTop()
	{
		if (mTop < 0)
		{
			System.Console.WriteLine("Stack if Empty");
			return 0;
		}
		return mArray[mTop];
	}

	public bool IsEmpty()
	{
		if (mTop < 0)
		{
			return true;
		}
		return false;
	}

	public bool IsFull()
	{
		if (mTop >= mArray.Length - 1)
		{
			return true;
		}
		return false;
	}
}