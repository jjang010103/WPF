using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarten.Model
{
    public class ChildrenInfo : ObservableObject
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        public ChildrenInfo(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
    }
}
