using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Monthlypayment data
    /// </summary>
    public class Monthlypayment
    {
        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("mortgage")]
        public double Mortgage { get; set; }

        [JsonProperty("property_tax")]
        public int Propertytax { get; set; }

        [JsonProperty("hoa")]
        public int Hoa { get; set; }

        [JsonProperty("home_insurance")]
        public int Homeinsurance { get; set; }

    }
    /// <summary>
    /// Annualpayment data
    /// </summary>
    public class Annualpayment
    {
        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("mortgage")]
        public double Mortgage { get; set; }

        [JsonProperty("property_tax")]
        public int Propertytax { get; set; }

        [JsonProperty("hoa")]
        public int Hoa { get; set; }

        [JsonProperty("home_insurance")]
        public int Homeinsurance { get; set; }

    }
    /// <summary>
    /// Amortizationschedule data
    /// </summary>
    public class Amortizationschedule
    {
        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("interest_payment")]
        public int Interestpayment { get; set; }

        [JsonProperty("principal_payment")]
        public double Principalpayment { get; set; }

        [JsonProperty("remaining_balance")]
        public double Remainingbalance { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("downpayment")]
        public int Downpayment { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("years")]
        public int Years { get; set; }

        [JsonProperty("total_interest_paid")]
        public double Totalinterestpaid { get; set; }

        [JsonProperty("monthly_payment")]
        public Monthlypayment Monthlypayment { get; set; }

        [JsonProperty("annual_payment")]
        public Annualpayment Annualpayment { get; set; }

        [JsonProperty("amortization_schedule")]
        public Amortizationschedule[] Amortizationschedule { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
