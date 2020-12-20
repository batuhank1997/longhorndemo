using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject breakableObj;
    public Transform spawnPoint; 
    // Start is called before the first frame update
    void Start()
    {
        //spawnin breakables
        int rand = Random.Range(5, 15);
        for(int i = 0; i < rand; i++)
        {
            GameObject breakable = Instantiate(breakableObj, spawnPoint.position + new Vector3(0, i, 0), Quaternion.identity);
            if (i % 2 == 0)
                breakable.GetComponent<MeshRenderer>().material.color = Color.red;
            else
                breakable.GetComponent<MeshRenderer>().material.color = Color.yellow;
            if(i == rand - 1)
            {
                breakable.tag = "LastBreakable";
            }
        }
    }
}
