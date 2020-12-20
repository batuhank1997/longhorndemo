using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public enum GAMESTATE { WIN, LOOSE, START}
    public GAMESTATE gameState;

    public GameObject winObj;
    public GameObject LostObj;

    private void Awake()
    {
        II = this;
    }
    private void Start()
    {
        gameState = GAMESTATE.START;
    }

    private void Update()
    {
        if(gameState == GAMESTATE.WIN)
            Win();
        else if(gameState == GAMESTATE.LOOSE)
            Loose();
    }
    void Win()
    {
        winObj.SetActive(true);
        Clean();
    }

    void Loose()
    {
        LostObj.SetActive(true);
        Clean();
    }
    
    void Clean()
    {
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Singleton
    public static GameManager II;
    public static GameManager I
    {
        get
        {
            if (II == null)
                GameObject.Find("GameManager").GetComponent<GameManager>();
            return II;
        }
    }

}
