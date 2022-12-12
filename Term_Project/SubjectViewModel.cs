using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project
{
    public class Subject
    {

        public string Sub_name { get; set; }
        public string Sub_code { get; set; }
        public string Sub_weapon { get; set; }
        public string Sub_Power { get; set; }

        public Subject(string sub_name, string sub_code, string sub_weapon, string sub_Power)
        {
            Sub_name = sub_name;
            Sub_code = sub_code;
            Sub_weapon = sub_weapon;
            Sub_Power = sub_Power;
        }
    }
    class SubjectViewModel
    {
        ObservableCollection<Subject> _list = new ObservableCollection<Subject>();
        public ObservableCollection<Subject> List
        {
            get { return _list; }
        }
        public SubjectViewModel()
        {

        }

        public void Add(Subject subject)
        {
            _list.Add(subject);
            
        }
        public void delete(Subject subject)
        {
            _list.Remove(subject);
        }
    }
}
