using BLL;
using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserInterface
{
    /// <summary>
    /// Logique d'interaction pour NouveauContact.xaml
    /// </summary>
    public partial class NouveauContact : Window
    {
        private int id;
        private string categorie;
        public NouveauContact()
        {
            InitializeComponent();
             
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // get id du dernier contact
            List<Personne> liste = new List<Personne>();
            liste = PersonneManager.GetAllPersonne();
            Personne dernier = liste.Last();
            id = dernier.Id + 1;
        }
        private void categorieComboxbBox_Loaded(object sender, RoutedEventArgs e)
        {
            categorieComboxbBox.Items.Add("Travail");
            categorieComboxbBox.Items.Add("Famille");
            categorieComboxbBox.Items.Add("Ami(e)");
        }
        private void categorieComboxbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            categorie = categorieComboxbBox.SelectedItem.ToString();
        }
        private void bttnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            Personne p = new Personne();
            p.Nom = nomTxt.Text.ToString();
            p.Prenom = prenomTxt.Text.ToString();
            p.Age = int.Parse(ageTxt.Text.ToString());
            p.Coord.Telephone = teletphoneTxt.Text.ToString();
            p.Coord.Fax = faxTxt.Text.ToString();
            p.Coord.Email = emailTxt.Text.ToString();
            p.Profession.Titre = professionTxt.Text.ToString();
            p.Profession.NomEntreprise = entrepriseTxt.Text.ToString();
            p.Adresse.Rue = rueTxt.Text.ToString();
            p.Adresse.Ville = villeTxt.Text.ToString();
            p.Adresse.CodePostal = codePostalTxt.Text.ToString();
            p.Adresse.Pays = paysTxt.Text.ToString();
            p.Categorie.Titre = categorie;
            p.Id = id;
            p.Coord.Id = id;
            p.Coord.Id_personne = id;
            p.Profession.Id = id;
            p.Profession.Id_personne = id;
            p.Adresse.Id = id;
            p.Adresse.Id_personne = id;
            p.Categorie.Id = id;
            p.Categorie.Id_personne = id;
            p.Contact.Id = id;
            p.Contact.Id_personne = id;

            PersonneManager.Add(p);
            System.Windows.Forms.MessageBox.Show("Contact Ajouté!");
        }
        private void bttnAnnuler_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
