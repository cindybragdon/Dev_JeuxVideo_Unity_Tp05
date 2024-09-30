using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReduceBars : MonoBehaviour
{

    public Slider sliderToReduce;

    public Text textOfSlider;

    public float reduceValue = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow)) {
            sliderToReduce.value -= reduceValue;
            textOfSlider.text = sliderToReduce.value + "%";
        }

        if(sliderToReduce.value <= 0) {
            SceneManager.LoadScene ("CanvasStartEntree");
        }
    }
}
