using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

            if (gameObject.CompareTag("Collectible"))
            {
                Debug.Log("Collected Energy Orb!");
                if (scoreManager != null)
                {
                    scoreManager.AddScore(10); // Increase score by 10
                }
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Hazard"))
            {
                Debug.Log("Hit a hazard! Lose energy.");
                if (scoreManager != null)
                {
                    scoreManager.AddScore(-5); // Lose 5 points
                }
                Destroy(gameObject);
            }
        }
    }
}
