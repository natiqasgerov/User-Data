using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class User
    {
        public User()
        {

        }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Surname: {SurName}\n" +
                $"Father's name: {FatherName}\n" +
                $"Country: {Country}\n" +
                $"City: {City}\n" +
                $"Phone: {Phone}\n" +
                $"Birthday: {Birthday}\n" +
                $"Gender: {Gender}";
        }

    }
}
