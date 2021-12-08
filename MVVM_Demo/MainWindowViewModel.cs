using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo
{
    public class MainWindowViewModel
    {
        public Person Person { get; set; }
        public List<Person> PersonList { get; set; }

        public MainWindowViewModel()
        {
            Person = new Person
            {
                Name = "Test",
                Vorname = "Tester"
            };

            PersonList = new List<Person>
            {                

                new Person()
                {
                    Name = "Muster",
                    Vorname = "Musterfrau"
                },

                new Person()
                {
                    Name = "Muster",
                    Vorname = "Mustermann"
                }
            };


        }

        
    }
}
