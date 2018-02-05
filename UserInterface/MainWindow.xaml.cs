using BLL;
using EntitiesLib;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System;

namespace UserInterface
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary> {} []
    public partial class MainWindow : Window
    {
        ModifierContact modifWindow;
        public MainWindow()
        {
            InitializeComponent();
            //listViewContacts.View = View.Details;
        }
      
        private void listViewContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             Personne p = (Personne)listViewContacts.SelectedItem;
            //System.Windows.Forms.MessageBox.Show(p.Prenom);
            //modifWindow = new ModifierContact(p);
            //modifWindow.ShowDialog();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Personne> listeContacts = PersonneManager.GetAll();
            UpdateListeContact(listeContacts);

        }

        private void bttnAjoutContact_Click(object sender, RoutedEventArgs e)
        {

        }

        ////// Recherche Par Saisie
        private string choix;
        private string choixInput;
        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Add("Nom");
            comboBox.Items.Add("Prenom");
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            choix = comboBox.SelectedItem.ToString();
            //System.Windows.Forms.MessageBox.Show(choix);
        }
        private void rechercheTexte_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            
        }
        private void bttnRechercher_Click(object sender, RoutedEventArgs e)
        {
            if (choix.Equals("Nom"))
            {
               
                choixInput = rechercheTexte.Text.ToString();
                //System.Windows.Forms.MessageBox.Show(choixInput);
                List<Personne> liste = PersonneManager.GetByName(choixInput);
                UpdateListeContact(liste);
            }
            else if (choix.Equals("Prenom"))
            {
                //System.Windows.Forms.MessageBox.Show(choix);
                choixInput = rechercheTexte.Text.ToString();
                //System.Windows.Forms.MessageBox.Show(choixInput);
                List<Personne> liste = PersonneManager.GetByFname(choixInput);
                UpdateListeContact(liste);
            }
        }
       
        //////// Recherche Par Ville Combo
        private void rechParVilleCombo_Loaded(object sender, RoutedEventArgs e)
        {
            List<Adresse> listAddr = AdresseManager.GetAll();
            foreach(Adresse a in listAddr)
            {
                rechParVilleCombo.Items.Add(a.Ville);

            }
        }
        private void rechParVilleCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ville = rechParVilleCombo.SelectedItem.ToString();
            List<Personne> liste = PersonneManager.GetByVille(ville);
            UpdateListeContact(liste);

        }
        ////////////// Recherche Par Pays Combo
        private void rechParPaysCombo_Loaded(object sender, RoutedEventArgs e)
        {
            List<Adresse> listAdrr = AdresseManager.GetAll();
            foreach(Adresse a in listAdrr)
            {
                rechParPaysCombo.Items.Add(a.Pays);
            }
        }
        private void rechParPaysCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show(rechParPaysCombo.Text);
            string pays = rechParPaysCombo.SelectedItem.ToString();
            List<Personne> liste = PersonneManager.GetByPays(pays);
            UpdateListeContact(liste);
        }

        // Update liste View
        private void UpdateListeContact(List<Personne> listeContacts)
        {
            //clear list view
            listViewContacts.Items.Clear();
            //Liste des contacts
            string[] row = null;
            foreach (Personne p in listeContacts)
            {
                row = new string[] { p.Nom, p.Prenom, p.Coord.Telephone };
                System.Windows.Forms.ListViewItem lv = new System.Windows.Forms.ListViewItem();
                lv.Tag = p;
                lv.Text = p.Nom;
                lv.SubItems.Add(p.Prenom);
                lv.SubItems.Add(p.Coord.Telephone);
                listViewContacts.Items.Add(lv);
            }
        }

        
    }
}
