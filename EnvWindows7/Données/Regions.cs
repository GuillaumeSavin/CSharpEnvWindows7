using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvWindows7.Données
{
    class Regions : ObservableCollection<Region>
    {

        public void chargermentRegions()
        {
            List<Departement> listDepartARA = new List<Departement>() { new Departement("ARA1", 42, 10000), new Departement("ARA2", 64, 20000), new Departement("ARA3", 128, 40000) };
            List<Departement> listDepartBFC = new List<Departement>() { new Departement("BFC1", 21, 5000), new Departement("BFC2", 10, 2500) };
            List<Departement> listDepartB = new List<Departement>() { new Departement("B1", 500, 42000) };
            List<Departement> listDepartCVL = new List<Departement>() { new Departement("CVL1", 1000, 64000) };
            List<Departement> listDepartC = new List<Departement>() { new Departement("C1", 2000, 128000), new Departement("C2", 42000, 500000) };
            this.Add(new Region("ARA", listDepartARA));
            this.Add(new Region("BFC", listDepartBFC));
            this.Add(new Region("B", listDepartB));
            this.Add(new Region("CVL", listDepartCVL));
            this.Add(new Region("C", listDepartC));
        }
        /*
        public List<Departement> this[String regionGiven]
        {
            get
            {
                Regions reg = this;
                foreach(Region r in reg)
                {
                    if(r.Nom == regionGiven)
                    {
                        return r.ListDepart;
                    }
                }

                return new List<Departement>();
            }
        }*/

        public Region this[String regionGiven]
        {
            get
            {
                Regions reg = this;
                foreach (Region r in reg)
                {
                    if (r.Nom == regionGiven)
                    {
                        return r;
                    }
                }

                return null;
            }
        }
    }
}
