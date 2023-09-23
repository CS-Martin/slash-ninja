using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDamage : MonoBehaviour
{
    
    public int damage = 1;

    public void OnMouseDown(){
        FindObjectOfType<EnemyHealth>().takeDamage(damage);
    }
}
