using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE
    {
        PLAYER,
        ENEMY
    }

    


    public Vector3 launchDirection;
    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;

   void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);

        }

        if (collision.gameObject.tag == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }



    }
     void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);

        }

        if (other.gameObject.tag == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            other.gameObject.GetComponent<PlayerController>().Damanged(1);
            Destroy(this.gameObject);
        }


    }







    void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;

        transform.Translate(launchDirection * moveAmount);
    }

   
}


