using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;
    private int Power = 50;
    public void Attack()
    {
        Debug.Log(this.Power + " / 데미지를 입혔다.");
    }
    public void Damage(int damage)
    { 
        this.hp -=damage;
        Debug.Log(damage+" / 데미지를 입었다.");
    }


    public int GetHp()
    {
        return this.hp;
    }
}




public class Test_008 : MonoBehaviour
{
    Player player_01 = new Player();
    Player player_02 = new Player();
    public Text player01HP;
    public Text player02HP;


    void Start()
    {
        
        player_01.Attack();
        player_01.Damage(30);



    }




    void Update()
    {
        player01HP.text = "Player 01 HP : " + player_01.GetHp().ToString();
        player02HP.text = "Player 02 HP : " + player_02.GetHp().ToString();

        if(Input.GetMouseButtonDown(0))
        {
            player_01.Damage(1);

        }
        if (Input.GetMouseButtonDown(1))
        {
            player_02.Damage(1);

        }
    }
}
