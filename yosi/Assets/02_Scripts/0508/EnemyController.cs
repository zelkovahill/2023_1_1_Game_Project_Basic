using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{




    public float speed = 5.0f;
    private Rigidbody rb;
    private Transform player;


    void Start()
    {
        rb = GetComponent<Rigidbody>(); // �ڱ� �ڽ��� �ٵ� �� �Է�
        player = GameObject.FindGameObjectWithTag("Player").transform;    //�÷��̾��� ��ġ �� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position , transform.position) > 5.0f)   //�÷��̾��� ��ġ �� �Է�
        {
            Vector3 direction = (player.position - transform.position).normalized;  //Vector3.Distance �Ÿ� ���� �Լ�
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime); //�� �̵�
        }
        
    }
}
