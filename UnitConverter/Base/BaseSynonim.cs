using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Units;

namespace UnitConverter.Base
{
    public class BaseSynonim
    {
        private List<string> synonyms;

        public List<string> Synonims
        {
            get { return synonyms; }
        }

       
        public void AddSynonim(string synonim)
        {
            bool containsSiPrefix = SiPrefixes.Prefixes.Any(p => synonim.Contains(p.Key));

            if (containsSiPrefix)
                throw new ArgumentException("Synonim cannot contain SI Standart Prefix in it's name");

            if (synonyms.Contains(synonim) == false)
                synonyms.Add(synonim);
            else
                throw new ArgumentException("Synonim already exists");
        }

        public void RemoveSynonim(string synonim)
        {
            synonyms.Remove(synonim);
        }

        public bool SynonimExists(string input)
        {
            return synonyms.Contains(input);
        }

    }
}
