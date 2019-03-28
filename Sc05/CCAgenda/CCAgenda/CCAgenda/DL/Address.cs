using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DL
{
    public class Address
    {
        private Int32 addID;
        private String addStreet;
        private String addZip;
        private String addNeighborhood;
        private String addNumber;
        private String addOpt;
        private String addCity;
        private String addState;
        private Boolean addIsBilling;


        public Address()
        {
            this.addStreet = String.Empty;
            this.addZip = String.Empty;
            this.addNeighborhood = String.Empty;
            this.addNumber = String.Empty;
            this.addOpt = String.Empty;
            this.addCity = String.Empty;
            this.addState = String.Empty;
        }

        public string AddStreet { get => addStreet; set => addStreet = value; }
        public string AddZip { get => addZip; set => addZip = value; }
        public string AddNeighborhood { get => addNeighborhood; set => addNeighborhood = value; }
        public string AddNumber { get => addNumber; set => addNumber = value; }
        public string AddOpt { get => addOpt; set => addOpt = value; }
        public string AddCity { get => addCity; set => addCity = value; }
        public string AddState { get => addState; set => addState = value; }
        public bool AddIsBilling { get => addIsBilling; set => addIsBilling = value; }
        public int AddID { get => addID; set => addID = value; }
    }
}
