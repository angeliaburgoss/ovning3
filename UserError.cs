using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ovning3
{
	public abstract class UserError
	{
		public abstract string UEMessage();

    }

	public class NumericInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use a numeric input in a text only field. This fired an error!"; 
		}

	}

	public class TextInputError : UserError
	{
        public override string UEMessage()
        {
			return "You tried to use a text input in a numeric only field. This fired an error!";
        }

    }

	public class Test1 : UserError
	{
        public override string UEMessage()
        {
			return "test 1";
        }
    }

    public class Test2 : UserError
    {
        public override string UEMessage()
        {
            return "test 2";
        }
    }

    public class Test3 : UserError
    {
        public override string UEMessage()
        {
            return "test 3";
        }
    }
}

