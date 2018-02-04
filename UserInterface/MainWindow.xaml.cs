using BLL;
using EntitiesLib;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;



namespace UserInterface
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary> {} []
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //listViewContacts.View = View.Details;

        }
      
        private void listViewContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //clear list view
            listViewContacts.Items.Clear();
            //Liste des contacts
            List<Personne> listeContacts = PersonneManager.GetAll();
            string[] row = null;
            foreach (Personne p in listeContacts)
            {
                row = new string[] {p.Nom,p.Prenom,p.Coord.Telephone};
                System.Windows.Forms.ListViewItem lv = new System.Windows.Forms.ListViewItem();
                lv.Text = p.Nom;
                lv.SubItems.Add(p.Prenom);
                lv.SubItems.Add(p.Coord.Telephone);
                listViewContacts.Items.Add(lv);
            }
          
        }

        private void bttnAjoutContact_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
