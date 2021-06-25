using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExerciceSynthese.Models;
using ExerciceSynthese.Dal;

namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        int id = 0;
        public Detail()
        {
            InitializeComponent();
        }

        public Detail(Tache tache)
        {
            InitializeComponent();
            entTitre.Text = tache.Title;
            edtDescription.Text = tache.Description;
            dtpDate.Date = tache.Date;
            id = tache.Id;
            
        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            if (entTitre.Text != null  && edtDescription.Text != null)
            {
                Tache tache = new Tache() { Title = entTitre.Text, Date = dtpDate.Date, Description = edtDescription.Text, Id = id};
                new TacheDal().Sauvegarder(tache);
                Navigation.PopModalAsync();
            }
            else
            {
                if (entTitre.Text == null)
                {
                    entTitre.BackgroundColor = Xamarin.Forms.Color.Red;
                }
                if (entTitre.Text != null)
                {
                    entTitre.BackgroundColor = Xamarin.Forms.Color.Black;
                }
                if (edtDescription.Text == null)
                {
                    edtDescription.BackgroundColor = Xamarin.Forms.Color.Red;
                }
                if (edtDescription.Text != null)
                {
                    edtDescription.BackgroundColor = Xamarin.Forms.Color.Black;
                }
            }
            


        }

        private void Retour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}