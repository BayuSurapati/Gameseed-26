using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_LevelTimer : MonoBehaviour
{
    [SerializeField] private b_LevelScoringData scoringData;

    private float elapsedTime;
    private bool isTimerRunning;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f; // Memaksa waktu berjalan normal
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    public void StartTimer() => isTimerRunning = true;

    public void StopTimer()
    {
        isTimerRunning = false;
        //CalculateFinalScore();
    }

    public void CalculateFinalScore()
    {
        int finalScore;

        if (elapsedTime <= scoringData.goldTime)
        {
            finalScore = scoringData.goldPoints;
            Debug.Log($"GOLD! Waktu: {elapsedTime:F2}s | Skor {finalScore}");
        }
        else if (elapsedTime <= scoringData.silverTime)
        {
            finalScore = scoringData.silverPoints;
            Debug.Log($"SILVER! Waktu: {elapsedTime:F2}s | Skor {finalScore}");
        }
        else
        {
            finalScore = scoringData.bronzePoints;
            Debug.Log($"BRONZE! Waktu: {elapsedTime:F2}s | Skor {finalScore}");
        }
    }

    public float GetCurrentTime => elapsedTime;
}
