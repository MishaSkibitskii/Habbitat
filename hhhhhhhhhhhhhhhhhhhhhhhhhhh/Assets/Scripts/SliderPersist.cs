using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPersist : MonoBehaviour
{
    [SerializeField] GameSettings settings;
    [SerializeField] Text sensText;
    private Slider slider;
    private void OnEnable()
    {
        slider = GetComponent<Slider>();

        slider.value = settings.mouseSenstivity;

    }
    private void Update()
    {
        sensText.text = (Mathf.Round(slider.value * 10f) / 10f).ToString();
    }
}
