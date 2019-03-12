using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temperatureControl : MonoBehaviour
{
    int minValue = 0, maxValue = 100, variationAmount = 2;
    public Slider tempSlider;

    // Start is called before the first frame update
    void Start()
    {
        tempSlider = this.gameObject.GetComponent<Slider>();
        tempSlider.minValue = minValue;
        tempSlider.maxValue = maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down"))
        {
            tempSlider.value -= variationAmount;
        }
        else if (Input.GetKey("up"))
        {
            tempSlider.value += variationAmount;
        }
    }
}
