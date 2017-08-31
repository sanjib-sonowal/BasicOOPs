using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class SkillsPage : Document
    {
        public override Page Create()
        {
            return new Resume();
        }
    }

    public class EducationPage : Document
    {
        public override Page Create()
        {
            return new Report();
        }
    }

    public class ExperiencePage : Document
    {
        public override Page Create()
        {
            return new Resume();
        }
    }
}
