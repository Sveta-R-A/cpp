using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LR1._1_C_
{
    public class Clothes
    {
        private string view;
        private string color;
        private string brend;
        private string country;
        private string decor;
        private string season;
        private double cost;
        public string View { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Brend { get; set; }
        public string Country { get; set; }
        public string Decor { get; set; }
        public string Season { get; set; }
        public double Cost { get; set; }
        public override string ToString()
        {
            return View; 
        }
        public Clothes()
        {
            View = "All";
            Color = "All";
            Size = "All";
            Brend = "All";
            Country ="All";
            Decor = "All";
            Season = "All";
            Cost = 0.0;
        }
        public Clothes(string vid, string color, string size, string brand,
                   string country, string decor, string season, double cost)
        {
            View = vid;
            Color = color;
            Size = size;
            Brend = brand;
            Country = country;
            Decor = decor;
            Season = season;
            Cost = cost;
        }
        public Clothes(Clothes other)
        {
            View = other.View;
            Color = other.Color;
            Size = other.Size;
            Brend = other.Brend;
            Country = other.Country;
            Decor = other.Decor;
            Season = other.Season;
            Cost = other.Cost;
        }

    }
}
