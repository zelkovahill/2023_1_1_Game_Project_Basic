using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()
    {

        Debug.Log("HELLO");

    }


    void CallName(string name)
    {

        Debug.Log("HELLO" + name);

    }

    int Add(int a, int b)
    {

        int c = a + b;
        return c;

    }
    void Start()
    {

        SayHello();
        SayHello();
        CallName("TOM");
        CallName("SAM");
        int answer = Add(2, 5);
        Debug.Log(answer);

        }

    


        void Update()
        {

        }
    }
