public enum OrderStatuses : byte
{
    Pending = 0,   // در انتظار پرداخت
    Paid = 1,      // پرداخت شده
    Shipped = 2,   // ارسال شده
    Delivered = 3, // تحویل شده
    Canceled = 4 // لغو شده
}