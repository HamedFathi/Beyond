// ReSharper disable UnusedMember.Global

namespace Beyond.Enums;

[Flags]
// ReSharper disable once UnusedType.Global
public enum HttpVerbs
{
    Get = 1 << 0,
    Post = 1 << 1,
    Put = 1 << 2,
    Delete = 1 << 3,
    Head = 1 << 4,
    Patch = 1 << 5,
    Options = 1 << 6
}