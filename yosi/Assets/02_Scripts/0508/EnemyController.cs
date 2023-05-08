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
        rb = GetComponent<Rigidbody>(); // 자기 자신의 바디 값 입력
        player = GameObject.FindGameObjectWithTag("Player").transform;    //플레이어의 위치 값 입력
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position , transform.position) > 5.0f)   //플레이어의 위치 값 입력
        {
            Vector3 direction = (player.position - transform.position).normalized;  //Vector3.Distance 거리 지원 함수
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime); //적 이동
        }
        
    }
}
