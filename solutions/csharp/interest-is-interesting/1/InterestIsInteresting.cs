static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float InterestRate;
        switch (balance)
        {
            case < 0:
                InterestRate = 3.213f;
                break;
            case >= 0m and < 1000:
            InterestRate = 0.5f;
                break;
            case >= 1000 and < 5000:
            InterestRate = 1.621f;
                break;
            case >= 5000:
                InterestRate = 2.475f;
                break;
        }

        return InterestRate;
    }

    public static decimal Interest(decimal balance)
    {
        return Convert.ToDecimal(InterestRate(balance)) * balance / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while(balance < targetBalance){
            balance = AnnualBalanceUpdate(balance);
            years++;
        }

        return years;
    }
}
