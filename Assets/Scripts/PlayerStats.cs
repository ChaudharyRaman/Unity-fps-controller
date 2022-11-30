using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CHaracterStats
{
    private PlayerHUD hud;
    private void Start() {
        GetReferences();
        InitVariable();
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.T)){
            TakeDamage(10);
        }
    }
    private void GetReferences(){
        hud = GetComponent<PlayerHUD>();
    }
    public override void CheckHealth()
    {
        base.CheckHealth();
        hud.UpdateHealth(health,maxHealth);
    }
}
