using System;

namespace WpfApp1
{
    internal class Man : IPerson
    {
        protected int _age;
        protected string _gender;
        public string Gender
        {
            get => _gender;
            set
            {
                if (value.ToUpper() != "М" && value.ToUpper() != "Ж")
                {
                    throw new ArgumentException($"Пол не может быть {value}\n(он должен быть М или Ж)");
                }
                _gender = value;
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Возраст не может быть меньше или равен 0");
                }
                _age = value;
            }
        }

        public Man(string name, string surname, int age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public Man()
        {

        }
        public object Clone()
        {
            Man male = new Man();
            male.Name = Name;
            male.Surname = Surname;
            male.Age = Age;
            male.Gender = Gender;
            return male;
        }

        public int CompareTo(object obj)
        {
            Man temp = (Man)obj;
            if (Surname == temp.Surname) return 1;
            if (Surname != temp.Surname) return -1;
            return 0;
        }

        public Man ShallowClone()
        {
            return (Man)MemberwiseClone();
        }
    }
}
