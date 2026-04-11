using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class b_LevelManager : MonoBehaviour
{
    public static b_LevelManager Instance;

    [SerializeField] private b_LevelTimer levelTimer;
    private bool isGameOver = false;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelFailed(string message)
    {
        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        levelTimer.StopTimer();
        Time.timeScale = 0f;
        Debug.Log($"Game Over{message}");

        //Implementasi tambahan dibawah
    }

    public void LevelCompleted(string message)
    {
        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        levelTimer.StopTimer();
        levelTimer.CalculateFinalScore();
        Time.timeScale = 0f;
        Debug.Log($"Level Selesai{message}");
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnRestart(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Level Restart...");
            RestartLevel();
        }
    }
}
