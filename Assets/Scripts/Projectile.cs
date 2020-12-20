using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Breakable")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            GameManager.I.gameState = GameManager.GAMESTATE.LOOSE;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "LastBreakable")
        {
            GameManager.I.gameState = GameManager.GAMESTATE.WIN;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
