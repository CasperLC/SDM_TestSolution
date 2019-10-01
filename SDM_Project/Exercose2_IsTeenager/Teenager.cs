using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SDM_Project.Exercose2_IsTeenager
{
    public class Teenager : ITeenager
    {
        public bool isTeenager(DateTime birthday)
        {
            var today = DateTime.Today;

            int dayCheck;
            if (today.Month > birthday.Month)
            {
                dayCheck = 1;
            }
            else if (today.Month == birthday.Month && today.Day >= birthday.Day)
            {
                dayCheck = 1;
            }
            else if (today.Month == birthday.Month && today.Day < birthday.Day)
            {
                dayCheck = 0;
            }
            else if (today.Month < birthday.Month)
            {
                dayCheck = 0;
            }
            else
            {
                throw new InvalidDataException();
            }

            int yearsOld = ((today.Year - birthday.Year - 1) + dayCheck);

            if (yearsOld <= 19 && yearsOld >= 13)
            {
                return true;
            }

            return false;
        }
    }
}
