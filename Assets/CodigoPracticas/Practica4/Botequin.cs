using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Botequin", menuName="Inventory/Medicine")]
public class Botequin : Item
{

    public float LifeAmount = 5.0f;
    public float effectiveness = 10f;

    public override void Use()
    {
        base.Use();
        //subir la vida
        Debug.Log($"Aumenta la vida en{LifeAmount} unidades");
    }
}
