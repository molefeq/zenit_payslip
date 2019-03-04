namespace Payslip.Calculator
{
    public interface ICalculateService
    {
        decimal CalculateGrossRemuneration();
        decimal CalculateAnnualGrossRemuneration();
        decimal CalculateRetirementFundsContributions();
        decimal CalculateAnnualRetirementFundsContributions();
        decimal CalculateLimitAnnualRetirementFundsContributions();
        decimal CalculateLimitBasedOnSalaryAnnualRetirementFundsContributions();
        decimal CalculateRetirementfundsContributionDeductions();
        decimal CalculateTaxableIncome();
        decimal CalculateTotalMedicalAidTaxCredits();
        decimal CalculatePaye();
        decimal CalculateUif();
        decimal CalculateNetPay();
    }
}
