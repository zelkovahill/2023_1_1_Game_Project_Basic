using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectleController : MonoBehaviour
{
    public GameObject Projectile;

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(Projectile);

        temp.transform.position = this.gameObject.transform.position;

        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        Destroy(temp, 10.0f);
    }
}
