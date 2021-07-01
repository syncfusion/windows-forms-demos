﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Continent : NotifyPropertyChanged
    {
        #region Properties       

        /// <summary>
        /// Represents the name of continent.
        /// </summary>
        private string _name;

        /// <summary>
        /// Represents the name of continent.
        /// </summary>
        public string ContinentName
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged("ContinentName"); }
        }

        /// <summary>
        /// Represents the id of continent.
        /// </summary>
        private int continentId;

        /// <summary>
        /// Represents the id of continent.
        /// </summary>
        public int ContinentId
        {
            get { return continentId; }
            set { continentId = value; RaisePropertyChanged("ContinentId"); }
        }

        /// <summary>
        /// Represents the collection of countries in the continent.
        /// </summary>
        private ObservableCollection<Country> country;

        /// <summary>
        /// Represents the collection of countries in the continent.
        /// </summary>
        public ObservableCollection<Country> Country
        {
            get { return country; }
            set { country = value; RaisePropertyChanged("Country"); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Represents the constructor of Continent class.
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_continentId"></param>
        /// <param name="_country"></param>
        public Continent(string _name, int _continentId, ObservableCollection<Country> _country)
        {
            this.ContinentName = _name;
            this.ContinentId = _continentId;
            this.Country = _country;
        }

        #endregion
    }
}
