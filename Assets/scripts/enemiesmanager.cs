using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesmanager : MonoBehaviour
{
    public Enemy[] enemies;
    void Start()
    {
        enemies = FindObjectsOfType<Enemy>();
        Debug.Log(enemies[enemies.Length - 1].damagepoints);
        setallenemiesdamagepointsto(Random.Range(1, 11));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setallenemiesdamagepointsto(int value)
    {
        for ( int i = 0; i < enemies.Length; i++)
        {
            enemies[i].damagepoints = value;
        }
    }

}
