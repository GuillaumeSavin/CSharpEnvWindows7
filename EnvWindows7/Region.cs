using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvWindows7
{
    class Region
    {
        private String nom;
        private List<Departement> listDepart;

        public Region(String _nom, List<Departement> _list)
        {
            this.nom = _nom;
            this.listDepart = _list;
        }

        public String Nom
        {
            get => nom;
        }

        public List<Departement> ListDepart
        {
            get => listDepart;
        }

        public String RegionString
        {
            get
            {
                return nom;
            }
        }
    }
}
