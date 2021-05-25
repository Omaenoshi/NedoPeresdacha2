using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedoExam2
{
    class Data
    { 
        public static Dictionary<string, int> Op { get; private set; }

        public static List<string> PeopleNames { get; private set; }

        public static List<string> RelationShips { get; private set; }

        public static List<Person> People { get; set; }

        public Data(string[] filedata)
        {
            PeopleNames = new List<string>();
            RelationShips = new List<string>();
            Op = new Dictionary<string, int>();
            People = new List<Person>();
            SeparationInfo(filedata);
            AddPeople();

        }

        private void AddPeople()
        {
            for (var i = 0; i < PeopleNames.Count; i++)
            {
                var person = PeopleNames[i].Split(';');
                People.Add(new Person(person[Op["Id"]], person[Op["FirstName"]], person[Op["LastName"]], person[Op["BirthDate"]]));
            }
        }

        private void SeparationInfo(string[] peopleInfo)
        {
            var options = peopleInfo[0].Split(';');
            for (var j = 0; j < options.Length; j++)
            {
                if (!Op.ContainsKey(options[j]))
                    Op.Add(options[j], j);
            }
            var i = 1;
            while (peopleInfo[i] != "")
            {
                PeopleNames.Add(peopleInfo[i]);
                i++;
            }
            i++;
            while (i < peopleInfo.Length)
            {
                RelationShips.Add(peopleInfo[i]);
                i++;
            }
        }

        private void SelectPerson(int id)
        {

            var currentPerson = (Person)People.Select(x => x.Id == id.ToString());

            
        }
    }
}
