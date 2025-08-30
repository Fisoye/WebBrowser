using FinalTest.Models;
using FinalTest.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest.Views
{
    public partial class AddFavourite : Form
    {
        //constructor
        public AddFavourite()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

        }
        //string favouritePath = Path.Combine(Application.StartupPath, "Favourites.txt");
        string favouritePath = "Favourites.txt";

        private int favouriteId = 0;

        public void EditUrl(FavouriteModel favourite)
        {
           



            this.label1.Text = "" + favourite.Id;
            this.txtName.Text = favourite.Name;
            this.txtUrl.Text = favourite.Url;

            this.favouriteId = favourite.Id;




        }

        //private void AssociateAndRaiseViewEvents()
        //{
        //    btnSave.Click += delegate { Save?.Invoke(this, EventArgs.Empty); };
        //}

        public string Id 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
        public string FavName 
        {
            get => txtName.Text;
            set => txtName.Text = value; 
        }
        public string URL 
        {
            get => txtUrl.Text;
            set => txtUrl.Text = value; 
        }
        
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            FavouriteModel favourite = new FavouriteModel();
            favourite.Id = this.favouriteId;
            favourite.Name = this.txtName.Text;
            favourite.Url = this.txtUrl.Text;

            var repro = new FavouriteController();

            if (favourite.Id == 0)
            {
                repro.AddFavourite(favouritePath, favourite);
            }

            else
            {
                repro.EditFavourite(favourite);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddFavouriteListBindingSource(BindingSource favourite)
        {
            throw new NotImplementedException();
        }
    }
}
