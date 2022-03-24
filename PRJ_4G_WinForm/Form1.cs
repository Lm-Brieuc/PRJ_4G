using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Text.Json;

namespace PRJ_4G_WinForm
{
    public partial class Form1 : Form
    {
        static List<C_ANTENNE> Antennes;

        HashSet<string> Departements = new HashSet<string>();
        HashSet<string> Operateurs = new HashSet<string>();
        HashSet<string> Technologies = new HashSet<string>();
        HashSet<string> Communes = new HashSet<string>();

        HashSet<string> IDs = new HashSet<string>();
        List<C_ANTENNE> listAntennes = new List<C_ANTENNE>();




        string selected_Departements = "*";
        string selected_Operateur = "*";
        string selected_Technologie = "*";
        string selected_Commune = "*";




        public Form1()
        {

            init_comboBox_Data();

            InitializeComponent();

            inc_textBox();
            inc_comboBox();

            carte.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;


            //listBox_listAntennes.DataSource = Antennes;
            //listBox_listAntennes.DisplayMember = "Geometry.coordinates";
        }

        //Form1 - START________________________________
        private void init_comboBox_Data()
        {
            string Data_Json = File.ReadAllText("sites_mobiles_2g-3g-4g_france_metropolitaine.json");

            Antennes = JsonSerializer.Deserialize<List<C_ANTENNE>>(Data_Json);

            //Get Departement
            foreach (C_ANTENNE nom_dep in Antennes)
            {
                if (nom_dep.fields.nom_dep != null)
                { Departements.Add(nom_dep.fields.nom_dep); }
            }
            //Get Operateur
            foreach (C_ANTENNE operateur in Antennes)
            {
                if (operateur.fields.operateur != null)
                { Operateurs.Add(operateur.fields.operateur); }
            }
            //Get Technologie
            foreach (C_ANTENNE technologie in Antennes)
            {
                if (technologie.fields.technologies != null)
                { Technologies.Add(technologie.fields.technologies); }
            }
            //Get Commune
            foreach (C_ANTENNE commune in Antennes)
            {
                if (commune.fields.commune != null)
                { Communes.Add(commune.fields.commune); }
            }



            //Get Ids_________(listBox)
            foreach (C_ANTENNE id in Antennes)
            {
                if (id.recordid != null)
                { IDs.Add(id.recordid); listAntennes.Add(id); }
            }

        }

        private void inc_textBox()
        {
            textBox_Departement.Text = Departements.Count.ToString();
            textBox_Operateur.Text = Operateurs.Count.ToString();
            textBox_Tech.Text = Technologies.Count.ToString();
            textBox_Communes.Text = Communes.Count.ToString();

            textBox_Selection.Text = Antennes.Count.ToString();

            //--
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox_num_Tech);
            textBoxes.Add(textBox_num_antennes_Communes);

            foreach(TextBox Box in textBoxes)
            {
                Box.Text = Antennes.Count().ToString();
            }

        }

        private void inc_comboBox()
        {
            comboBox_Departemet.Items.Add("*");
            foreach (string dep in Departements)
            {
                comboBox_Departemet.Items.Add(dep);
            }

            comboBox_Operateur.Items.Add("*");
            foreach (string operateur in Operateurs)
            {
                comboBox_Operateur.Items.Add(operateur);
            }

            comboBox_Technologie.Items.Add("*");
            foreach (string technologie in Technologies)
            {
                comboBox_Technologie.Items.Add(technologie);
            }

            comboBox_Communes.Items.Add("*");
            foreach (string commune in Communes)
            {
                comboBox_Communes.Items.Add(commune);
            }


            //-_-_-_-
            foreach (C_ANTENNE antenne in listAntennes)
            {
                listBox_listAntennes.Items.Add(antenne.display());
            }

        }

        private string init_Antenne_Textbox()
        {
            int num_antennes = 0;
            foreach (C_ANTENNE antenne in Antennes)
            {
                if ((antenne.fields.nom_dep == selected_Departements || selected_Departements == "*")
                    && (antenne.fields.operateur == selected_Operateur || selected_Operateur == "*")
                    && (antenne.fields.technologies == selected_Technologie || selected_Technologie == "*")
                    && (antenne.fields.commune == selected_Commune || selected_Commune == "*"))
                {
                    num_antennes++;
                }
            }
            return num_antennes.ToString();
        }


        //Form1 - END___________________________________

        //----------------------------------------------------------------------
        //------------------------------------------------------------------

        private void Update_listAntenne_listBox()
        {
            IDs.Clear();
            listAntennes.Clear();
            //Get Ids_________(listBox)
            foreach (C_ANTENNE id in Antennes)
            {
                if (id.recordid != null
                    && (id.fields.nom_dep == selected_Departements || selected_Departements == "*")
                    && (id.fields.operateur == selected_Operateur || selected_Operateur == "*")
                    && (id.fields.technologies == selected_Technologie || selected_Technologie == "*")
                    && (id.fields.commune == selected_Commune || selected_Commune == "*"))
                { 
                    IDs.Add(id.recordid); 
                    listAntennes.Add(id);
                }
            }

            listBox_listAntennes.Items.Clear();
            foreach (C_ANTENNE antenne in listAntennes)
            {
                listBox_listAntennes.Items.Add(antenne.display());
            }

        }

        private void comboBox_Departemet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num_Antennes_Departement = 0;
            selected_Departements = (string)comboBox_Departemet.SelectedItem;
            textBox_Selection.Text = init_Antenne_Textbox();
            foreach (C_ANTENNE antenne in Antennes)
            {
                if (antenne.fields.nom_dep == selected_Departements || selected_Departements == "*")
                {
                    num_Antennes_Departement++;
                    
                }
            }
            textBox1.Text = num_Antennes_Departement.ToString();
            Commune_Adjustment();
            Update_listAntenne_listBox();
        }
        private void Commune_Adjustment()
        {
            comboBox_Communes.SelectedItem = "*";

            Communes.Clear();
            foreach (C_ANTENNE commune in Antennes)
            {
                if (commune.fields.commune != null 
                    && (commune.fields.nom_dep == selected_Departements || selected_Departements == "*"))
                { Communes.Add(commune.fields.commune); }
            }
            comboBox_Communes.Items.Clear();
            comboBox_Communes.Items.Add("*");
            foreach (string commune in Communes)
            {
                comboBox_Communes.Items.Add(commune);
            }
        }

        private void comboBox_Operateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num_Antennes_Operateur = 0;
            selected_Operateur = (string)comboBox_Operateur.SelectedItem;
            textBox_Selection.Text = init_Antenne_Textbox();

            foreach (C_ANTENNE antenne in Antennes)
            {
                if (antenne.fields.operateur == selected_Operateur || selected_Operateur == "*")
                {
                    num_Antennes_Operateur++;
                }
            }
            textBox2.Text = num_Antennes_Operateur.ToString();
            Update_listAntenne_listBox();
        }

        private void comboBox_Technologie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num_Antennes_Technologie = 0;
            selected_Technologie = (string)comboBox_Technologie.SelectedItem;
            textBox_Selection.Text = init_Antenne_Textbox();

            foreach (C_ANTENNE antenne in Antennes)
            {
                if (antenne.fields.technologies == selected_Technologie || selected_Technologie == "*")
                {
                    num_Antennes_Technologie++;
                }
            }
            textBox_num_Tech.Text = num_Antennes_Technologie.ToString();
            Update_listAntenne_listBox();
        }

        private void comboBox_Communes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = 0;
            selected_Commune = (string)comboBox_Communes.SelectedItem;
            textBox_Selection.Text = init_Antenne_Textbox();

            foreach (C_ANTENNE antenne in Antennes)
            {
                if (antenne.fields.commune == selected_Commune || selected_Commune == "*")
                {
                    num++;
                }
            }
            textBox_num_antennes_Communes.Text = num.ToString();
            Update_listAntenne_listBox();
        }
        //--
        private void listBox_listAntennes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string id in IDs)
            {
                //if (antenne.recordid == (string)listBox_listAntennes.SelectedItem)
                if (id == listAntennes[listBox_listAntennes.SelectedIndex].recordid)
                {
                    C_ANTENNE antenne = listAntennes[listBox_listAntennes.SelectedIndex];
                    textBox_Coords.Text = $"{antenne.geometry.coordinates[1]} / {antenne.geometry.coordinates[0]}";
                    carte.Position = new GMap.NET.PointLatLng(antenne.geometry.coordinates[1], antenne.geometry.coordinates[0]);

                    GMapOverlay markers = new GMapOverlay("markers");
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(listAntennes[listBox_listAntennes.SelectedIndex].fields.coordonnees[0], listAntennes[listBox_listAntennes.SelectedIndex].fields.coordonnees[1]),
                        GMarkerGoogleType.blue_pushpin);
                    markers.Markers.Add(marker);
                    carte.Overlays.Add(markers);
                }
            }
        }





        //useless_____________________________________________________________________
        private void label_num_Operateur_Click(object sender, EventArgs e)
        {

        }


        private void comboBox_Departemet_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Sorting_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_num_antennes_Communes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Communes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Communes_Click(object sender, EventArgs e)
        {

        }

        private void textBox_num_Tech_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Operateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Avaliable_Antennes_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Selection_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Coords_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Coords_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Technologie_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Departement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}