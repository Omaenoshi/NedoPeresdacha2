using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedoExam2
{
    class Person
    {
        public string Id { get; set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string BirthDate { get; private set; }



        public Person(string id, string firstName, string lastName, string birstDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birstDate;
        }
    }
}
