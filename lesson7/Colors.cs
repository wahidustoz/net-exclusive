[Flags]
public enum Colors
{
    None = 0,
    Red = 1,
    Green = 2,
    Blue = 4,
    Yellow = Red | Green,
    Cyan = Green | Blue,
    Magenta = Red | Blue,
    White = Red | Green | Blue
}