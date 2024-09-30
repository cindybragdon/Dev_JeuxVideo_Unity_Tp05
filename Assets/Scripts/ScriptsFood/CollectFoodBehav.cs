using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollectFoodBehav : MonoBehaviour
{

    public Slider sliderNourriture;
    public Slider sliderEnergie;
    public Text textNourriture;
    public Text textEnergie;

    public float valueNourritureToAdd = 20;

    public float valueEnergieNourritureToAdd = 30;

    void OnCollisionEnter(Collision other) {

        if(other.gameObject.CompareTag("Nourriture")) {
            sliderNourriture.value += valueNourritureToAdd;
            textNourriture.text = sliderNourriture.value + "%";
            Destroy(other.gameObject);
        }

        
        if(other.gameObject.CompareTag("Energie")) {
            sliderEnergie.value += valueEnergieNourritureToAdd;
            textEnergie.text = sliderEnergie.value + "%";
            Destroy(other.gameObject);
        }
    }

}
