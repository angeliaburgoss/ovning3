// Angelia Burgos Zamora
// angeliaburgos55@gmail.com





namespace ovning3;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Person p1 = new Person("luna", "llano");
            // p1.Age = 0;

            //  Console.WriteLine(p1.Age);
            //  Console.WriteLine(p1.FName);
            //  Console.WriteLine(p1.LName);


            PersonHandler personhandler = new PersonHandler();
            Person person1 = personhandler.CreatePerson(6, "Luna", "Llano", 49.5, 23);
       
            Person person2 = personhandler.CreatePerson(28, "Angelia", "Burgos", 172.5, 90);

            Person person3 = personhandler.CreatePerson(12, "Andres", "Llano", 183.5, 99.99);

            Console.WriteLine(personhandler.GetAge(person1) + (" ") + personhandler.GetFName(person1) + (" ") + personhandler.GetLName(person1) + (" ") + personhandler.GetWeight(person1) + (" ") + personhandler.GetHeight(person1));
            Console.WriteLine();
            Console.WriteLine(personhandler.GetAge(person2) + (" ") + personhandler.GetFName(person2) + (" ") + personhandler.GetLName(person2) + (" ") + personhandler.GetWeight(person2) + (" ") + personhandler.GetHeight(person2));
            Console.WriteLine();
            Console.WriteLine(personhandler.GetAge(person3) + (" ") + personhandler.GetFName(person3) + (" ") + personhandler.GetLName(person3) + (" ") + personhandler.GetWeight(person3) + (" ") + personhandler.GetHeight(person3));
            Console.WriteLine();

            personhandler.SetAge(person1, 12);
            personhandler.SetFName(person1, "anul");
            personhandler.SetLName(person1, "onall");
            personhandler.SetWeight(person1, 5.94);
            personhandler.SetHeight(person1, 32);

            Console.WriteLine();
            Console.WriteLine(personhandler.GetAge(person1) + (" ") + personhandler.GetFName(person1) + (" ") + personhandler.GetLName(person1) + (" ") + personhandler.GetWeight(person1) + (" ") + personhandler.GetHeight(person1));
            Console.WriteLine();

        }

        catch (Exception e)
        {
            Console.WriteLine(e);



        }

        NumericInputError numericInputError1 = new NumericInputError();
        TextInputError textInputError1 = new TextInputError();
        Test1 test1 = new Test1();
        Test2 test2 = new Test2();
        Test3 test3 = new Test3();

        List<UserError> userErrors = new List<UserError>();

        userErrors.Add(numericInputError1);
        userErrors.Add(textInputError1);
        userErrors.Add(test1);
        userErrors.Add(test2);
        userErrors.Add(test3);

        foreach (var element in userErrors)
        {
            Console.WriteLine(element.UEMessage());
        }

     
        

  
    }

}


