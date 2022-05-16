using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "GameSettings")]
public class GameSettings : ScriptableObject
{
    public float mouseSenstivity;
    public void SetSens(Slider slider)
    {
        mouseSenstivity = slider.value;
    }
}

