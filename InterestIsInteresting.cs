using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance) =>
        balance switch
        {
            >= 5000 => 2.475f,
            >= 1000 => 1.621f,
            >= 0 => 0.5f,
            _ => 3.213f
        };

    public static decimal Interest(decimal balance) => (balance / 100) * (decimal)InterestRate(balance);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int amountYears = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            amountYears++;
        };
        return amountYears;
    }        
}
