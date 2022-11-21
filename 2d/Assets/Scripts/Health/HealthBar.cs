using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealBar;
    [SerializeField] private Image currenthealthBar;


    private void Start(){
        totalhealBar.fillAmount = playerHealth.currentHealth / 10;
    }


    private void Update() {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
    }
}
