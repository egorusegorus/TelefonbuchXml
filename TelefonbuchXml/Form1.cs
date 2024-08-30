using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace TelefonbuchXml
{
    public partial class TelefonbuchXml : Form
    {
        private readonly string xmlPath = "person.xml";
        private List<Person> lstPersons = new List<Person>();

        public TelefonbuchXml()
        {
            InitializeComponent();
            GridInitialisieren();
        }

        private void PersonenSpeichernXml()
        {
            try
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(xmlPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
                    xmlSerializer.Serialize(xmlWriter, lstPersons);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void PersonenLadenXml()
        {
            if (!File.Exists(xmlPath))
                return;

            try
            {
                using (XmlReader xmlReader = XmlReader.Create(xmlPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
                    lstPersons = xmlSerializer.Deserialize(xmlReader) as List<Person> ?? new List<Person>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void GridInitialisieren()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {

            PersonenSpeichernXml();
            Close();
        }

        private void btnPersonHinzufügen_Click(object sender, EventArgs e)
        {
            Person person = new Person(txtVorname.Text, txtName.Text, txtTelefon.Text, txtEmail.Text);
            lstPersons.Add(person);
            PersonenAnzeigen();
        }

        private void PersonenAnzeigen()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstPersons;
        }

        private void TelefonbuchXml_Load(object sender, EventArgs e)
        {
            PersonenLadenXml();
            PersonenAnzeigen();  // Od razu wyświetl osoby po załadowaniu
        }

        private void TelefonbuchXml_FormClosing(object sender, FormClosingEventArgs e)
        {
            PersonenSpeichernXml();
        }

        private void btnLaden_Click(object sender, EventArgs e)
        {
            PersonenLadenXml();
            PersonenAnzeigen();
        }

        private void btnPresonLöschen_Click(object sender, EventArgs e)
        {
            Person? person = dataGridView1.CurrentRow.DataBoundItem as Person;
            if (person == null)
                return;
            // Person aus der Liste löschen
            lstPersons.Remove(person);
            PersonenAnzeigen();
        }

        private void btnSpechern_Click(object sender, EventArgs e)
        {
            PersonenSpeichernXml();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Person? p = dataGridView1.CurrentRow.DataBoundItem as Person;
            if (p == null) return;                  // wenn p ist null bedeutet ende methode
            PersonAnzeigen(p);
        }

        private void PersonAnzeigen(Person? p)
        {
            txtVorname.Text = p.Vorname;
            txtName.Text = p.Name;
            txtTelefon.Text = p.Telefon;
            txtEmail.Text = p.Email;
        }
    }
}