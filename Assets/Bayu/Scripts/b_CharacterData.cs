using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "ScriptableObjects/CharacterData")]
public class b_CharacterData : ScriptableObject
{
    public string CharacterName;
    public float moveSpeed;
    public float jumpForce;
    public float gravityScale;
    public Color characterColor;
}
