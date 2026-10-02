using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageboxmanager : MonoBehaviour
{
    public DamageBox[] damageboxes;
    void Awake()
    {
        damageboxes = FindObjectsOfType<DamageBox>();
    }

    void Start()
    {
        setallboxesdamagepointsto(Random.Range(1, 11));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setallboxesdamagepointsto(int value)
    {
        for ( int i = 0; i < damageboxes.Length; i++)
        {
            damageboxes[i].vaninitydamage = value;
        }
    }
}

