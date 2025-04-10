using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance => _instance; 
    private static GameManager _instance;
    
    private int _score;
    public int Score => _score;

    private void Awake()
    {
        if (Instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        
        Destroy(gameObject);
    }

    public void AddScore(int score)
    {
        _score += score;
        Debug.Log($"Score: {_score}");
    }
}
