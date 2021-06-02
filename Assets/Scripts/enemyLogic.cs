using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLogic : MonoBehaviour
{
    public GameObject Guardian;
    public GameObject Player;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag("Player")) Destroy(Player); GameObject.Find("");
    }
}
