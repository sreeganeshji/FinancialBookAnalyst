using System.Collections.Generic;
using System.Text.Json.Serialization;

public class IncomeStatement
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("annualReports")]
    public List<IncomeStatementAnnualReport> AnnualReports { get; set; }
}

public class IncomeStatementAnnualReport
{
    [JsonPropertyName("fiscalDateEnding")]
    public string FiscalDateEnding { get; set; }

    [JsonPropertyName("reportedCurrency")]
    public string ReportedCurrency { get; set; }

    [JsonPropertyName("grossProfit")]
    public string GrossProfit { get; set; }

    [JsonPropertyName("totalRevenue")]
    public string TotalRevenue { get; set; }

    [JsonPropertyName("costOfRevenue")]
    public string CostOfRevenue { get; set; }

    [JsonPropertyName("costofGoodsAndServicesSold")]
    public string CostofGoodsAndServicesSold { get; set; }

    [JsonPropertyName("operatingIncome")]
    public string OperatingIncome { get; set; }

    [JsonPropertyName("sellingGeneralAndAdministrative")]
    public string SellingGeneralAndAdministrative { get; set; }

    [JsonPropertyName("researchAndDevelopment")]
    public string ResearchAndDevelopment { get; set; }

    [JsonPropertyName("operatingExpenses")]
    public string OperatingExpenses { get; set; }

    [JsonPropertyName("investmentIncomeNet")]
    public string InvestmentIncomeNet { get; set; }

    [JsonPropertyName("netInterestIncome")]
    public string NetInterestIncome { get; set; }

    [JsonPropertyName("interestIncome")]
    public string InterestIncome { get; set; }

    [JsonPropertyName("interestExpense")]
    public string InterestExpense { get; set; }

    [JsonPropertyName("nonInterestIncome")]
    public string NonInterestIncome { get; set; }

    [JsonPropertyName("otherNonOperatingIncome")]
    public string OtherNonOperatingIncome { get; set; }

    [JsonPropertyName("depreciation")]
    public string Depreciation { get; set; }

    [JsonPropertyName("depreciationAndAmortization")]
    public string DepreciationAndAmortization { get; set; }

    [JsonPropertyName("incomeBeforeTax")]
    public string IncomeBeforeTax { get; set; }

    [JsonPropertyName("incomeTaxExpense")]
    public string IncomeTaxExpense { get; set; }

    [JsonPropertyName("interestAndDebtExpense")]
    public string InterestAndDebtExpense { get; set; }

    [JsonPropertyName("netIncomeFromContinuingOperations")]
    public string NetIncomeFromContinuingOperations { get; set; }

    [JsonPropertyName("comprehensiveIncomeNetOfTax")]
    public string ComprehensiveIncomeNetOfTax { get; set; }

    [JsonPropertyName("ebit")]
    public string Ebit { get; set; }

    [JsonPropertyName("ebitda")]
    public string Ebitda { get; set; }

    [JsonPropertyName("netIncome")]
    public string NetIncome { get; set; }
}
