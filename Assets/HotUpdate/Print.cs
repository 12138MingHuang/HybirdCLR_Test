using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    List<string> testStrList = new List<string> { "a11111", "b22222", "c33333" };
    void Start()
    {
        Debug.Log($"[Print] GameObject:{this.name}");
        Debug.Log($"[Print] GameObject......:{this.name}");

        for (int i = 0; i < testStrList.Count; ++i)
        {
            Debug.Log($"[Print] testStrList:{testStrList[i]}");
        }
        
        List<MyVector3> myVecList = new List<MyVector3>();
        myVecList.Add(new MyVector3 { x = 1, y = 2, z = 3 });
        myVecList.Add(new MyVector3 { x = 4, y = 5, z = 6 });
        myVecList.Add(new MyVector3 { x = 7, y = 8, z = 9 });

        for (int i = 0; i < myVecList.Count; ++i)
        {
            Debug.Log($"[Print] myVecList{i+1}: {myVecList[i].x},{myVecList[i].y},{myVecList[i].z}");
        }
    }
}

public class MyVector3
{
    public float x;
    public float y;
    public float z;
}
