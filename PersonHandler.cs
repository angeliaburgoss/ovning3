using System;
namespace ovning3
{
	public class PersonHandler
	{
		public PersonHandler()
		{
            

        }



        public void SetAge(Person pers, int age)
        {
            pers.Age = age;

        }

        public int GetAge(Person pers)
        {
            return pers.Age;

        }

        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;

        }

        public string GetFName(Person pers)
        {
            return pers.FName;

        }

        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;

        }

        public string GetLName(Person pers)
        {
            return pers.LName;

        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;

        }

        public double GetWeight(Person pers)
        {
            return pers.Weight;

        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;

        }

        public double GetHeight(Person pers)
        {
            return pers.Height;

        }



        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);

            return person;
        }

        //public string PrintPerson(Person p)
        //{
        //    Console.WriteLine()

        //}
    }
}

