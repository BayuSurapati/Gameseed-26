using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class b_CharacterSwitcher : MonoBehaviour
{
    [SerializeField] private List<b_PlayerMovement> players;
    private int currentIndex = 0;
    [SerializeField] private int defaultCharacterIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentIndex = Mathf.Clamp(defaultCharacterIndex, 0, players.Count -1);
        UpdateActiveCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSwitch(InputValue value)
    {
        if (value.isPressed)
        {
            SwitchCharacter();
        }
    }

    private void SwitchCharacter()
    {
        currentIndex++;
        if(currentIndex == players.Count)
        {
            currentIndex = 0;
        }

        UpdateActiveCharacter();
    }

    private void UpdateActiveCharacter()
    {
        for (int i = 0; i < players.Count; i++)
        {
            players[i].IsActive = (i == currentIndex);
        }

        Debug.Log("Sekarang mengontrol: " + players[currentIndex].gameObject.name);
    }
}
