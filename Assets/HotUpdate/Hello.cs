using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello
{
    public static void Run()
    {
        Debug.Log("Hello, World!");
        Debug.Log("333333");

        GameObject go = new GameObject("Test1");
        go.AddComponent<Print>();
        
        GameObject go2 = new GameObject("Test2");
        go2.AddComponent<Print>();
    }
}
