using System;
namespace ovning3
{
	public abstract class Animal
	{
		public string name;
		public int age;
		public double weight;
		public abstract void DoSound();

		public Animal(string name, int age, double weight)
		{
			this.name = name;
			this.age = age;
			this.weight = weight;
		}

        public class Horse : Animal
        {
            public int horsePower;
            public Horse(string name, int age, double weight, int horsePower) : base(name, age, weight)
            {
                this.horsePower = horsePower;
            }

            public override void DoSound()
            {
                Console.WriteLine("The horse says: neigh neigh");
            }

        }

        public class Dog : Animal
        {
            public double tailLenght;
            public Dog(string name, int age, double weight, double tailLenght) : base(name, age, weight)
            {
                this.tailLenght = tailLenght;
            }

            public override void DoSound()
            {
                Console.WriteLine("The dog says: woof woof");
            }
        }

        public class Hedgehog : Animal
        {
            public int tagAmount;
            public Hedgehog(string name, int age, double weight, int tagAmount) : base(name, age, weight)
            {
                this.tagAmount = tagAmount;
            }

            public override void DoSound()
            {
                Console.WriteLine("The hedgehod says: snörp snörp");
            }
        }

        public class Worm : Animal
        {
            public int totalLenght;
            public Worm(string name, int age, double weight, int totalLength) : base(name, age, weight)
            {
                this.totalLenght = totalLenght;
            }

            public override void DoSound()
            {
                Console.WriteLine("The worm says: brum brum");
            }
        }

        public class Bird : Animal
        {
            public int amountFeather;
            public Bird(string name, int age, double weight, int amountFeather) : base(name, age, weight)
            {
                this.amountFeather = amountFeather;
            }

            public override void DoSound()
            {
                Console.WriteLine("The bird says: kraa kraa");
            }
        }

        public class Wolf : Animal
        {
            public string furColor;
            public Wolf(string name, int age, double weight, string furColor) : base(name, age, weight)
            {
                this.furColor = furColor;
            }

            public override void DoSound()
            {
                Console.WriteLine("The wolf says: aaauuu aaauuu");
            }
        }

        public class Pelican : Bird
        {
            public int beakLength;
            public Pelican(string name, int age, double weight, int amountFeather, int beakLength) : base(name, age, weight, amountFeather)
            {
                this.beakLength = beakLength;
            }

        }

        public class Flamingo : Bird
        {
            public string featherColor;
            public Flamingo(string name, int age, double weight, int amountFeather, string featherColor) : base(name, age, weight, amountFeather)
            {
                this.featherColor = featherColor;
            }
        }

        public class Swan : Bird
        {
            public int neckLenght;
            public Swan(string name, int age, double weight, int amountFeather, int neckLenght) : base(name, age, weight, amountFeather)
            {
                this.neckLenght = neckLenght;
            }
        }

        interface IPerson
        {
            void Talk();
        }

        public class Wolfman : Wolf, IPerson
        {
            public Wolfman(string name, int age, double weight, string furColor) : base(name, age, weight, furColor)
            { }
            public void Talk()
            {
                Console.WriteLine("aaauuu aaauuu hello");
            }
        }


        // F1: Om det är ett attribut som ska gälla för alla fåglar läggs detta in i Bird. Om det gäller specifikt för en fågel läggs det
        // in i den sub-klassen.

        // F2: Om alla behöver ett nytt attribut läggs detta in i Animal klassen. 
    }
}

