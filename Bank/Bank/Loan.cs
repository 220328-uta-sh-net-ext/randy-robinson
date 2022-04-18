﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Bank
{
    [Serializable()]
    public class Loan : INotifyPropertyChanged
    {
        public double LoanAmount { get; set; }
        public double InterestRatePercent { get; set; }
        //const string FileName = @"../../../SavedLoan.bin";

        [field: NonSerialized()]
        public DateTime TimeLastLoaded { get; set; }
        public int Term { get; set; }
        private string customer;
        public string Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Customer)));
            }
        }

        [field: NonSerialized()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public Loan(double loanAmount,
                    double interestRate,
                    int term,
                    string customer)
        {
            this.LoanAmount = loanAmount;
            this.InterestRatePercent = interestRate;
            this.Term = term;
            this.customer = customer;
        }
    }
}
