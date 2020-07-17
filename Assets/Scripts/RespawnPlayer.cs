using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip deathAudio;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.CompareTag("Obstacle")){
          audioSource.clip = deathAudio;
          audioSource.Play();
          player.transform.position = respawnPoint.transform.position;
        }
        if (coll.CompareTag("FinalTransition")){
          player.transform.position = respawnPoint.transform.position;
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
