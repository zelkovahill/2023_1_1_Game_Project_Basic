using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ּ� ������ �����̽��� �ƴ϶� TAB
        int age; //������ int ���� �̸��� age
        age = 30; //age�� 30�� �Է�(=)�� �Է�
        Debug.Log(age); //Console.Logâ�� age�� ���� �����ش�.

        float height1 = 160.5f; //�ε��Ҽ����� float ���� �̸��� height1�̰� 106.5f �� �Է�
        float height2; //float�� heught2���� (�Է� ���� ���� ���� NULL)
        height2 = height1; //height�� �ִ� height2�� �Է�
        Debug.Log(height2); //Console.log â�� height2�� ���� �����ش�.

        string name; // ���ڿ� name ����
        name = "Sera"; // name�� Sera �Է�
        Debug.Log(name); // Console.log â�� name�� ���� �����ش�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
