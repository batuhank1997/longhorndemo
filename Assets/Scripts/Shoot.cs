using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectileObj;
    public Transform spawnPoint;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Instantiating projectiles
        if(GameManager.I.gameState == GameManager.GAMESTATE.START)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject projectile = Instantiate(projectileObj, spawnPoint.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
            }
        }
    }
}
