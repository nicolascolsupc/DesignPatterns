using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshPro _text;

    private void Start()
    {
        GameManager.Instance.OnScoreEvent += UpdateUI;
    }

    public void UpdateUI(int score)
    {
        _text.text = score.ToString();
    }
    
    public void OnDestroy()
    {
        GameManager.Instance.OnScoreEvent -= UpdateUI;
    }
}
