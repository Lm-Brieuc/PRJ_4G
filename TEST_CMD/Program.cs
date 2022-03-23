using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TEST_CMD
{

    internal class Program
    {
        static void Main(string[] args)
        {
            bool rr = true;
            try
            {
                List<C_ANTENNE> Antennes;
                HashSet<string> Communes = new HashSet<string>();
                HashSet<string> Operateurs = new HashSet<string>();
                HashSet<string> Departements = new HashSet<string>();
                HashSet<string> Technologies = new HashSet<string>();

                string Data_Json = File.ReadAllText("sites_mobiles_2g-3g-4g_france_metropolitaine.json");
                //Console.WriteLine(Data_Json);

                Antennes = JsonSerializer.Deserialize<List<C_ANTENNE>>(Data_Json);

                Console.WriteLine($"Num antennes : {Antennes.Count}");

                //Get Communes------------------
                foreach(C_ANTENNE antenne in Antennes)
                {
                    //Console.WriteLine(antenne.fields.commune);
                    Communes.Add(antenne.fields.commune);
                }
                //Get Operateur---------------
                foreach (C_ANTENNE operateur in Antennes)
                {
                    Operateurs.Add(operateur.fields.operateur);
                }
                //Get Departement---------------
                foreach (C_ANTENNE nom_dep in Antennes)
                {
                    Departements.Add(nom_dep.fields.nom_dep);
                }
                //Get Technologie (2G,3G,4G)--------------
                foreach (C_ANTENNE technologie in Antennes)
                {
                    Technologies.Add(technologie.fields.technologies);
                }


                foreach (string antenne in Communes)
                {
                    Console.Write($"{antenne}, ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
