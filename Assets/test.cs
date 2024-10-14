using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private int count=0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
        Debug.LogWarning("hello Unity");
        Debug.LogError("hi unity");
    }

    // Update is called once per frame

    //프레임마다 갱신되는값을 호출(1프레임= 1/60 초)
    void Update()
    {
        Debug.Log("updating.");
        Debug.Log(count++);
    }
}

//public class Praogram
//{
//    public static void Main(string[] args)
//    {

//        System.Console.WriteLine();
//    }
//}