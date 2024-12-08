namespace LogisTrack.Domain.Enums;

public enum EOrderStatus
{
    Pending = 1,
    Processing,
    Dispatched,
    InTransit,
    OutForDelivery,
    Delivered,
    Cancelled,
    Returned,
    FailedDelivery,
    OnHold,
    Completed
}
