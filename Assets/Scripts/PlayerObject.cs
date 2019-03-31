using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[System.Serializable]
public class PlayerObject : MonoBehaviour
{
    public bool isDead;
    public bool Guard;
    public bool Evasion;


    [HideInInspector]
    public float baseHP = 200, currentHP, baseStamina = 100, currentStamina;

    //lambrogini, leg lock, dungeon slam

    void Start()
    {
        currentHP = Mathf.Clamp(currentHP, 0, 200);
        currentStamina = Mathf.Clamp(currentStamina, 0, 100);
        currentHP = baseHP;
        currentStamina = baseStamina;
    }

}