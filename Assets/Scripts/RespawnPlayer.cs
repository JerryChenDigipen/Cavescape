using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.CompareTag("Obstacle")){
            player.transform.position = respawnPoint.transform.position;
        }
        
    }
}