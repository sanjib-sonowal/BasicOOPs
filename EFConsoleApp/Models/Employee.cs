using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Models
{
    public class MEmployee
    {
        private int _id;
        private string _name;
        private string _jobDescription;
        private string _number;
        private string _department;

        public int Id {
            get{ return _id; }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string JobDescription
        {
            get { return _jobDescription; }
            set
            {
                _jobDescription = value;
            }
        }
        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
            }
        }
        public string Department
        {
            get { return _department; }
            set
            {
                _department = value;
            }
        }
    }
}
