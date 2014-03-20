public class OpEval
	{
	///////////////////////
	private int GetOp(int ch)
		{
		if(ch=='.') { return 0; }
		if(ch=='+') { return 1; }
		if(ch=='*') { return 2; }
		if(ch=='$') { return 0; }
		System.Console.WriteLine("**Get OP Got a bad oeprator");
		return -1; 
		}	

	///////////////////////
	public int Eval(string str)
		{
		Stack opstack=new Stack(300);
		Stack numstack=new Stack(300);
		

		opstack.Push('.');
		for(int i=0;i<str.Length;++i)
			{
			char ch=str[i];
			if(ch>='0' && ch<='9')
				{
				numstack.Push(ch-'0');
				continue;
				}


			for(;;)
				{
				if(GetOp(opstack.GetTop() ) < GetOp(ch) )
					{
					opstack.Push(ch);
					break; 
					}

				int performop=opstack.GetTop();
				if(performop=='+')
					{
					int num1=numstack.GetTop();
					numstack.Pop();
					int num2=numstack.GetTop();
					numstack.Pop();
					numstack.Push(num1+num2);
					opstack.Pop();
					continue;
					}


				if(performop=='*')
					{
					int num1=numstack.GetTop();
					numstack.Pop();
					int num2=numstack.GetTop();
					numstack.Pop();
					numstack.Push(num1*num2);
					opstack.Pop();
					continue;
					}

				if(performop=='.')
					{
					return numstack.Pop();
					}

				//=Error
				System.Console.WriteLine("** Stack Processing Error");
				}

			}

		System.Console.WriteLine("** Error in Eval()");
		return 0;
		}


	//////////////////////////////////////////////////////////////
	static public void Main()
		{
		OpEval tst=new OpEval();
		int num=tst.Eval("2+3*3+5$");
		System.Console.WriteLine("Answer={0}",num);
		System.Console.ReadKey();
		}
	}