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

    //�����Ӹ��� ���ŵǴ°��� ȣ��(1������= 1/60 ��)
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