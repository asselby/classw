using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Doctor
    {
        private string name;
        private string surname;
        private string profile;
        private double experience;
        private double freeTime;

        public Doctor() {
            this.name = name;
        }
              
        public void SetName(string name) {
            this.name=name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public string GetSurname() {
            return surname;
        }

        public void SetProfile(string profile)
        {
            this.profile = profile;
        }

        public string GetProfile() {
            return profile;
        }

        public void SetExperience(double experience)
        {
            this.experience = experience;
        }

        public double GetExperience()
        {
            return experience;            
        }

        
        public void SetFreeTime(double freeTime)
        {
            this.freeTime = freeTime;
        }

        public double GetFreeTime()
            {
            return freeTime;
            }
        
    }

}
