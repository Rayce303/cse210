class Program
{
    static void Main()
    {
        Person myDude = new Person("Timmy", "Wimmy", 9, 18);
        Console.WriteLine(myDude.GetPersonInfo());

        Police myOfficer = new Police("Murphy", "Wilbert", 42, 53, "nunchucks");
        Console.WriteLine(myOfficer.GetPoliceInfo());

        Doctor myDoc = new Doctor("Phil", "Philbert", 84, 3000, "Crystal Ball");
        Console.WriteLine(myDoc.GetDoctorInfo());

        List<Person> myPeeple = new List<Person>();

        myPeeple.Add(myDude);
        myPeeple.Add(myOfficer);
        myPeeple.Add(myDoc);

        foreach(Person person in myPeeple)
        {
            Console.WriteLine(person.GetPersonInfo());
        }
    }
}