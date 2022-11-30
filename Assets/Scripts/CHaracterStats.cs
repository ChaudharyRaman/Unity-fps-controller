using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHaracterStats : MonoBehaviour
{
   [SerializeField] protected int health;
   [SerializeField] protected int maxHealth;

   [SerializeField] protected bool isDead;
   private void Start() {
      InitVariable();
   }

   public virtual  void CheckHealth(){
      if(health<=0){
         health = 0;
         Die();
      }
      if(health >= maxHealth){
         health = maxHealth;
      }
   }
   public void Die(){
      isDead = true;
   }
   public void SetHealthTo(int healthToSetTo){
      health = healthToSetTo;
      CheckHealth();
   }
   public void TakeDamage(int damage){
      int healthAfterDamage = health - damage;
      SetHealthTo(healthAfterDamage);
   }
   public void Heal(int heal){
      int healthAfterHeal = health + heal;
      SetHealthTo(healthAfterHeal);
   }
   public void InitVariable(){
      maxHealth = 100;
      SetHealthTo(maxHealth);
      isDead = false;
   }
}
