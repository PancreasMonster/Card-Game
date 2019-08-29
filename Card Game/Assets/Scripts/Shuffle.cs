using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public static class Shuffle 
{
    public static void ShuffleList<T>(this IList<T> list, System.Random rnd)
    {
        for (var i = 0; i < list.Count - 1; i++)
            list.Swap(i, rnd.Next(i, list.Count));
    }
    public static void Swap<T>(this IList<T> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }

}
