namespace huita1;

public static class Utils
{
    public static string ObjectToDouble(this object obj)
    {
        return obj.ToString().Replace(',', '.');
    }
}