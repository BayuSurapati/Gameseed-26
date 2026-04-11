using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class b_GoalArea : MonoBehaviour
{
    [Header("WinSettings")]
    [Tooltip("Jumlah karakter yang harus masuk ke area untuk win")]
    [SerializeField] private int requiredPlayers = 3;
    [SerializeField] private int dummyCounter = 0;
    [SerializeField] private b_LevelTimer levelTimer;

    //Hash set ini gunanya untuk mengecek berapa player valid yang masuk ke area
    private HashSet<GameObject> playersInGoals = new HashSet<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            playersInGoals.Add(collision.gameObject);
            
            dummyCounter += 1;

            Debug.Log("Player masuk" + dummyCounter);
            CheckWinCondition();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playersInGoals.Remove(collision.gameObject);

            dummyCounter -= 1;

            Debug.Log("Player masuk" + dummyCounter);
        }
    }

    private void CheckWinCondition()
    {
        Debug.Log($"Karakter di Garis Finish: {playersInGoals.Count} / {requiredPlayers}");
        if (playersInGoals.Count >= requiredPlayers)
        {
            TriggerWin();
        }
    }

    private void TriggerWin()
    {
        Debug.Log("SELAMAT! Semua karakter berhasil mencapai tujuan! GAME CLEAR!");

        //Kode Logic
        b_LevelManager.Instance.LevelCompleted("MENANG");
    }

}
