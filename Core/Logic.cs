using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;

namespace Core
{
    public class Logic
    {
        private List<Sim> _sims = new List<Sim>();
        private int _nextId = 1;

        //добавление
        public void AddSims(string name, int age, string sex)
        {
            Sim sim = new Sim(_nextId++, name, age, sex);
            _sims.Add(sim);
        }

        public List<Sim> GetSims()
        {
            return _sims;
        }

        public void RemoveSims(int id)
        {
            var sim = _sims.Find(s => s.Id == id);
            _sims.Remove(sim);
        }

        public void UpdateSim(int id, string Nname, int Nage, string Nsex)
        {
            var sim = _sims.Find(s => s.Id == id);
            sim.Name = Nname;
            sim.Age = Nage;
            sim.Sex = Nsex;
        }

        public List<Sim> GetSex(string sex)
        {
            List<Sim> res = new List<Sim>();
            foreach (var sim in _sims)
            {
                if (sim.Sex == sex)
                {
                    res.Add(sim);
                }
            }
            return res;
        }

        public List<Sim> GetAdult()
        {
            List<Sim> res = new List<Sim>();
            foreach (var sim in _sims)
            {
                if (sim.Age > 17)
                {
                    res.Add(sim);
                }
            }
            return res;
        }

        

    }
}
