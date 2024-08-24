using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class LevelController : MonoBehaviour
{
    public Spawner spawner;
 
    public static bool finished = false;
 
    public static int level = 1;
 
    public GameObject victoryPanel;
    public GameObject defeatPanel;
 
    private void Awake()
    {
        level = PlayerPrefs.GetInt("level", 1);
    }
 
    private void Start()
    {
        finished = false;
    }
 
    private void Update()
    {
        if(finished == false)
        {
            Check();
        }
    }
 
    public void Check()
    {
        if (spawner.spawnCounter <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
 
            if (enemies.Length <= 0)
            {
                Victory();
 
            }
        } 
 
        if(Corn.singleton.health <= 0)
        {
            Defeat();
        }
 
    }
