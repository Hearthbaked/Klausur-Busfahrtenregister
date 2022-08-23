using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Klausur
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=root;database=fahrtenbuch;");
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from fahrt";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Fahrt fa = new Fahrt(reader.GetInt64(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetFloat(4));
                listBoxFahrten.Items.Add(fa);
            }
            reader.Close();
        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            string f = textBoxFahrtnummer.Text;
            if (f == "") return;
            int fahrtnummer = int.Parse(f);
            string stadt = textBoxStadt.Text;
            if (stadt == "") return;
            string bundesland = textBoxBundesland.Text;
            if (bundesland == "") return;
            string enf = textBoxEntfernung.Text;
            if (enf == "") return;
            float entfernung = float.Parse(enf);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into fahrt(fahrtnummer,stadt,bundesland,entfernung) values(@fahrtnummer,@stadt,@bundesland,@entfernung)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@fahrtnummer", fahrtnummer);
            cmd.Parameters.AddWithValue("@stadt", stadt);
            cmd.Parameters.AddWithValue("@bundesland", bundesland);
            cmd.Parameters.AddWithValue("@entfernung", entfernung);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;

            Fahrt fa = new Fahrt(id, fahrtnummer, stadt, bundesland, entfernung);
            listBoxFahrten.Items.Add(fa);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            conn = null;
        }

        float gesamtStrecke = 0.0f;
        private void buttonErrechne_Click(object sender, EventArgs e)
        {
            
            Fahrt fa = (Fahrt)listBoxFahrten.SelectedItem;
            if (fa == null) return;
            string f = textBoxAnzahl.Text;
            if (f == "") return;
            int anzahl = Int32.Parse(f);
            if (anzahl == 0) return;
            float entfernung = float.Parse(f);
            if (entfernung == 0) return;

            Strecke st = new Strecke(fa, anzahl);
            listBoxGesamteStrecke.Items.Add(fa);
            gesamtStrecke += st.GetGesamtStrecke();
            labelGesamtStrecke.Text = "" + gesamtStrecke + "km";
            if (gesamtStrecke > 1000)
            {
                MessageBox.Show("Warnung! Mehr als 1000km!");
            }
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            listBoxGesamteStrecke.Items.Clear();
            labelGesamtStrecke.Text = string.Empty;
            
        }
    }
}
