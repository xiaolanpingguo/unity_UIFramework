using System.Collections;
using System.Collections.Generic;

public static class DictionaryExtension
{
    // 字典的扩展方法
    public static Tvalue TryGet<Tkey, Tvalue>(this Dictionary<Tkey, Tvalue> dict, Tkey key)
    {
        Tvalue value;
        dict.TryGetValue(key, out value);
        return value;
    }

}
