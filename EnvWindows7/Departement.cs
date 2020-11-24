using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvWindows7
{
    class Departement
    {
        private String nom;
        private int population;
        private int surface;

        public Departement(String _nom, int _population, int _surface)
        {
            this.nom = _nom;
            this.population = _population;
            this.surface = _surface;
        }

        public String DepartementString
        {
            get
            {
                return nom;
            }
        }

        public String InfoPopulationString
        {
            get
            {
                return "" + population;
            }
        }

        public String InfoSurfaceString
        {
            get
            {
                return "" + surface;
            }
        }
    }
}
