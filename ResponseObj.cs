using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class monthlypayment
{
    [JsonProperty("total")]
    public double total { get; set; }

    [JsonProperty("mortgage")]
    public double mortgage { get; set; }

    [JsonProperty("property_tax")]
    public int propertytax { get; set; }

    [JsonProperty("hoa")]
    public int hoa { get; set; }

    [JsonProperty("home_insurance")]
    public int homeinsurance { get; set; }

}

public class annualpayment
{
    [JsonProperty("total")]
    public double total { get; set; }

    [JsonProperty("mortgage")]
    public double mortgage { get; set; }

    [JsonProperty("property_tax")]
    public int propertytax { get; set; }

    [JsonProperty("hoa")]
    public int hoa { get; set; }

    [JsonProperty("home_insurance")]
    public int homeinsurance { get; set; }

}

public class amortizationschedule
{
    [JsonProperty("month")]
    public int month { get; set; }

    [JsonProperty("interest_payment")]
    public int interestpayment { get; set; }

    [JsonProperty("principal_payment")]
    public double principalpayment { get; set; }

    [JsonProperty("remaining_balance")]
    public double remainingbalance { get; set; }

}

public class data
{
    [JsonProperty("amount")]
    public int amount { get; set; }

    [JsonProperty("downpayment")]
    public int downpayment { get; set; }

    [JsonProperty("rate")]
    public double rate { get; set; }

    [JsonProperty("years")]
    public int years { get; set; }

    [JsonProperty("total_interest_paid")]
    public double totalinterestpaid { get; set; }

    [JsonProperty("monthly_payment")]
    public monthlypayment monthlypayment { get; set; }

    [JsonProperty("annual_payment")]
    public annualpayment annualpayment { get; set; }

    [JsonProperty("amortization_schedule")]
    public amortizationschedule[] amortizationschedule { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
