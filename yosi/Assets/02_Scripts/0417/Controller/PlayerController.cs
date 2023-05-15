using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6;             
    public GameObject PlayerPivot;
    Camera viewCamera;
    Vector3 velocity;
    public ProjectleController projectileController;

    public int Player_Hp = 5;

    public void Damanged(int Damage)
    {
        Player_Hp -= Damage;
        if ( Player_Hp < 0)
        {
            Destroy(this.gameObject);

        }
    }


    void Start()
    {
        viewCamera = Camera.main;   //메인 카메랄르 가져오기 위해서, start에서 찾아서 입력
        
    }

    



    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
        // 컴퓨터 화면 2D의 마우스 좌표에서 카메라를 통과한 후 3D 영역에서의 마우스 위치 값을 가져오기 위해서
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        //플레이어가 봐야할 타켓 포인트
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        //풀레이어 피봇이 봐라봐야 하는 좌표를 설정
        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);

        // Input 을 통해 캐릭터 이동 백터를 생성한다.
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;



    }

    private void FixedUpdate()
    {
        //계산한 벡터를 플레이어 컨트롤러에 있는 Rigidbody에 접근해서 이동 벡터를 고정시간 Time 만큼 이동시켜주는 라인
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);

    }
}
