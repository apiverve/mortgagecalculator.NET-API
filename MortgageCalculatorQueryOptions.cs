using System;
using System.Collections.Generic;
using System.Text;

namespace APIVerve
{
    public class MortgageCalculatorQueryOptions {
public double amount { get; set; }
public double rate { get; set; }
public int years { get; set; }
public double downpayment { get; set; }
public double annual_propertytax { get; set; }
public double annual_homeinsurance { get; set; }
public double annual_hoa { get; set; }
}

}
