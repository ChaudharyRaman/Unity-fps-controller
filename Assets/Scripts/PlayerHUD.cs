using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField]private Text currentHealthText;
    [SerializeField] private Text maxHealthText;

    
    public void UpdateHealth(int currentHealth, int maxHealth){
        currentHealthText.text = currentHealth.ToString();
        maxHealthText.text = maxHealth.ToString();
    }
    
       
}
 