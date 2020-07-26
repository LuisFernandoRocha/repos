namespace ExercicoContrato.Services
{
    interface IOnlineServicePayment
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
