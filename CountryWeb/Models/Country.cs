using Microsoft.AspNetCore.SignalR;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;
using static NuGet.Packaging.PackagingConstants;
using System.Drawing;

namespace CountryWeb.Models
{
    public class Country
    {


        public Name Name { get; set; }

        public List<string> Tld { get; set; }
        public string Cioc { get; set; }
        public bool Independent { get; set; }
        public bool UnMember { get; set; }
        public Dictionary<string, Currency> Currencies { get; set; }
        public Idd Idd { get; set; }
        public List<string> Capital { get; set; }
        public List<string> AltSpellings { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public Dictionary<string, string> Languages { get; set; }
        public List<double> Latlng { get; set; }
        public List<string> Borders { get; set; }
        public double Area { get; set; }
        public Demonyms Demonyms { get; set; }
        public string Flag { get; set; }
        public int Population { get; set; }
        public Dictionary<string, double> Gini { get; set; }
       
        public Flags Flags { get; set; }
       
 
    }





    public class Name
    {
        public string Common { get; set; }
        public string Official { get; set; }
        public NativeName NativeName { get; set; }
    }

    public class NativeName
    {
        public Spa Spa { get; set; }
    }

    public class Spa
    {
        public string Official { get; set; }
        public string Common { get; set; }
    }

    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class Idd
    {
        public string Root { get; set; }
        public List<string> Suffixes { get; set; }
    }


    public class Demonyms
    {
        public len Eng { get; set; }
        public len Fra { get; set; }
    }

    public class len
    {
        public string Official { get; set; }
        public string Common { get; set; }
    }


    public class Flags
    {
        public string Png { get; set; }
        public string Svg { get; set; }
        public string Alt { get; set; }
    }



    public class CoatOfArms
    {
        public string Png { get; set; }
        public string Svg { get; set; }
    }

    public class CapitalInfo
    {
        public List<double> Latlng { get; set; }
    }


  

}
