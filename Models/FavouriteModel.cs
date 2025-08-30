using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FinalTest.Models
{
    public class FavouriteModel
    {
        //Feilds
        private int id;
        private string name = "";
        private string url ="";

        //Properties

    
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        
        public string Name 
        {   get => name; 
            set => name = value; 
        }
        

      
        public string Url 
        {   get => url; 
            set => url = value; 
        }
    }


    
}
