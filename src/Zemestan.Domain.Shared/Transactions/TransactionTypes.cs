namespace Zemestan.Transactions;
public enum TransactionTypes : int
{
    [Description("سفارش")]
    Order = 100001,
    [Description("خرید")]
    Purchase = 100002
}