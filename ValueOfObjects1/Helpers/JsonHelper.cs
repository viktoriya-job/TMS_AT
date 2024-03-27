using System.Text.Json;
using ValueOfObjects1.Models;

namespace ValueOfObjects1.Helpers;

public static class JsonHelper<T>
{
    public static T FromJson(string path, FileMode open)
    {
        using FileStream fs = new FileStream(path, FileMode.Open);
        return JsonSerializer.Deserialize<T>(fs);
    }

    public static string ToJson(T obj)
    {
        return JsonSerializer.Serialize(obj);
    }

    //public static Project ProjectFromJson(string path)
    //{
    //    using FileStream fs = new FileStream(path, FileMode.Open);
    //    return JsonSerializer.Deserialize<Project>(fs);
    //}

    //public static string ToJson(Project obj)
    //{
    //    return JsonSerializer.Serialize(obj);
    //}
}