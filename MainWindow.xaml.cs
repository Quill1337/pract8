using System;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Man man = new Man();
        private Female female = new Female();
        public MainWindow()
        {
            InitializeComponent();
            NameTextBox.Focus();
        }

        private void CloseProg_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            Peoples.Items.Clear();
            ClearingAll();
        }

        private void ClearingAll()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            AgeTextBox.Clear();
            GenderTextBox.Clear();
            NameTextBox.Focus();
        }
        private void ShowTask_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман ИСП-31");
        }

        private void AddHumanButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AgeTextBox.Text, out int age))
            {
                try
                {
                    if (GenderTextBox.Text.ToLower() == "м")
                    {
                        man.Name = NameTextBox.Text;
                        man.Surname = SurnameTextBox.Text;
                        man.Age = age;
                        man.Gender = GenderTextBox.Text;
                        Peoples.Items.Add(new Man(NameTextBox.Text, SurnameTextBox.Text, age, GenderTextBox.Text));
                    }
                    if (GenderTextBox.Text.ToLower() == "ж")
                    {
                        female.Name = NameTextBox.Text;
                        female.Surname = SurnameTextBox.Text;
                        female.Age = age;
                        female.Gender = GenderTextBox.Text;
                        Peoples.Items.Add(new Female(NameTextBox.Text, SurnameTextBox.Text, age, GenderTextBox.Text));
                    }
                    ClearingAll();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ReactNewPeople_Click(object sender, RoutedEventArgs e)
        {
            if (man.CompareTo(man) == -1 || man.CompareTo(female) == -1)
            {
                MessageBox.Show($"Привет ! {man.Name}", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Фамилии одинаковые");
            }
        }

        private void CloneObj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (man != null)
                {
                    Peoples.Items.Add(man.Clone());
                }
                if (female != null)
                {
                    Peoples.Items.Add(female.Clone());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ShallCloneObj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (man != null)
                {
                    Peoples.Items.Add(man.ShallowClone());
                }
                if (female != null)
                {
                    Peoples.Items.Add(female.ShallowClone());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
