using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _scoreValue;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        
        //Add score
        GameManager.Instance.AddScore(_scoreValue);
        
        gameObject.SetActive(false);
        //return to pool
    }
}
