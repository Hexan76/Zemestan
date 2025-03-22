using System.ComponentModel;

public enum OrderTypes : byte
{
    [Description("اینترتی")]
    Online = 0,
    [Description("تلفنی")]
    Phone = 1,
    [Description("حضوری")]
    InPerson = 2,
    [Description("سایر روش ها")]
    Other = 3
}