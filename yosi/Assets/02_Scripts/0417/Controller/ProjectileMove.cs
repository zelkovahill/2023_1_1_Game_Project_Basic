using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

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

        if (other.gameObject.tag == "Monster")
        {
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }


    }







    void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;

        transform.Translate(launchDirection * moveAmount);
    }

   
}


