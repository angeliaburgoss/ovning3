using System;
namespace ovning3
{
	public class Person
	{
		private int age;

		public int Age
		{
			get { return age; }
			set
			{
				if (value < 1)
				{
					throw new ArgumentException("Age must be higher than 0");
				}

                age = value;


            }
		}

		private string fName;

		public string FName
		{
			get { return fName; }
			set
			{
				if (value.Length < 3 || value.Length > 9)
				{
					throw new ArgumentException("The firstname must be longer than 2 charachters and shorter than 10");
				}

				fName = value;


			}
		}

		private string lName;

		public string LName
		{
			get { return lName; }
			set
			{
				if (value.Length < 4 || value.Length > 14)
				{
                    throw new ArgumentException("The lastname must be longer than 3 charachters and shorter than 15");
				}

                lName = value;


            }
		}

		private double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		private double weight;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}


		public Person(string fName, string lName)
		{
			FName = fName;
			LName = lName;
		}

        public Person(int age, string fname, string lname, double height, double weight)
        {
            FName = fname;
            LName = lname;
			Age = age;
			Height = height;
			Weight = weight;
        }
    }
}

