namespace WpfApp1
{
    internal class Female : Man, IPerson
    {
        public Female()
        {

        }
        public Female(string name, string surname, int age, string gender) : base(name, surname, age, gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public new object Clone()
        {
            Female female = new Female();
            female.Name = Name;
            female.Surname = Surname;
            female.Age = Age;
            female.Gender = Gender;
            return female;
        }
        public new int CompareTo(object obj)
        {
            Man temp = (Man)obj;
            if (Surname == temp.Surname) return 1;
            if (Surname != temp.Surname) return -1;
            return 0;
        }
        public new Female ShallowClone()
        {
            return (Female)MemberwiseClone();
        }
    }
}
