using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Models
{
    public class HistoryModel
    {
        //Feilds
        private int id;
        private string url = "";

        //Properties


        public int Id
        {
            get => id;
            set => id = value;
        }


        



        public string Url
        {
            get => url;
            set => url = value;
        }


    }
}
