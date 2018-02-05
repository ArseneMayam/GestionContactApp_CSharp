using BLL;
using EntitiesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ModifierContact : Form
    {
        private Personne p;
        // les elements modifiés
        private string edNom;
        private string edPrenom;
        private int edAge;
        private string edTel;
        private string edFax;
        private string edProfession;
        private string edEntreprise;
        private string edRue;
        private string edPays;
        private string edCodePostal;
        private string edCategorie;

        // constructeur
        public ModifierContact(Personne personne)
        {
            InitializeComponent();
            this.p = personne;
            //initialise les elements
            nomText.Text = personne.Nom;
            prenomText.Text = personne.Prenom;
            ageText.Text = personne.Age.ToString();
            telephoneText.Text = personne.Coord.Telephone;
            emailText.Text = personne.Coord.Email;
            faxText.Text = personne.Coord.Fax;
            professionText.Text = personne.Profession.Titre;
            entrepriseText.Text = personne.Profession.NomEntreprise;
            rueText.Text = personne.Adresse.Rue;
            villeText.Text = personne.Adresse.Ville;
            codePostalText.Text = personne.Adresse.CodePostal;
            paysTextBox.Text = personne.Adresse.Pays;
            categorieText.Text = personne.Categorie.Titre;
        }

        // Modifier Contact
        private void bttnModifier_Click(object sender, EventArgs e)
        {
            // modifier personne
            p.Nom = nomText.Text.ToString();
            p.Prenom = prenomText.Text.ToString();
            p.Age = int.Parse(ageText.Text.ToString());
            p.Coord.Telephone = telephoneText.Text.ToString();
            p.Coord.Fax = faxText.Text.ToString();
            p.Coord.Email = emailText.Text.ToString();
            p.Profession.Titre = professionText.Text.ToString();
            p.Profession.NomEntreprise = entrepriseText.Text.ToString();
            p.Adresse.Rue = rueText.Text.ToString();
            p.Adresse.Ville = villeText.Text.ToString();
            p.Adresse.CodePostal = codePostalText.Text.ToString();
            p.Adresse.Pays = paysTextBox.Text.ToString();
            p.Categorie.Titre = categorieText.Text.ToString();

            PersonneManager.Edit(p);
            System.Windows.Forms.MessageBox.Show("Modification Enrégistré!");

        }
        // Retour page principale (fermer)
        private void bttnRetour_Click(object sender, EventArgs e)
        {

        }
    }
}
