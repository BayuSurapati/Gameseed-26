using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLevelScoringData", menuName = "ScriptableObjects/LevelScoringData")]
public class b_LevelScoringData : ScriptableObject
{
    [Header("Time Thresholds")]
    public float goldTime;
    public float silverTime;
    public float bronzeTime;

    [Header("Points")]
    public int goldPoints = 100;
    public int silverPoints = 50;
    public int bronzePoints = 30;
}
