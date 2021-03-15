using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//añadir objeto al invetario
public class PickUpObject : Interacteble
{
    public Item item;
    public override void Interact()
  {
      //base.Interact();
      //refer al inventario, llamar metodo de insert
      Inventory.InventoryInstance.Add(this.item);
      Destroy(this.gameObject);
  }

}
