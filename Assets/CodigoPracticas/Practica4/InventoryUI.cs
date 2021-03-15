using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    private Inventory _inventory;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        _inventory.onChange += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI() //se llama cuando hay un cambio en el inven.
    {
        //Debug.Log("Cambio el inventario");
        Slot[] slots = GetComponentsInChildren<Slot>();
        Item[] equipItems = _inventory.GetAllItemsByType(ItemType.Equip);
        Item[] medicineItems = _inventory.GetAllItemsByType(ItemType.Medicine);
        Item[] espadaItems = _inventory.GetAllItemsByType(ItemType.Espada);
        Item[] armaItems = _inventory.GetAllItemsByType(ItemType.Arma);
        Item[] armapequeItems = _inventory.GetAllItemsByType(ItemType.Armapeque);
        
        if(equipItems.Length > 0)
            slots[0].SetItem(equipItems[0], equipItems.Length);
        if(medicineItems.Length > 0)
            slots[1].SetItem(medicineItems[0], medicineItems.Length);
        if(espadaItems.Length > 0)
            slots[2].SetItem(espadaItems[0], espadaItems.Length);
        if(armaItems.Length > 0)
            slots[3].SetItem(armaItems[0], armaItems.Length);
        if(armapequeItems.Length > 0)
            slots[4].SetItem(armapequeItems[0], armapequeItems.Length);        

        // for (int i = 0; i < slots.Length; i++)
        // {
            
        //     if (i < _inventory.items.Count)
        //     {
        //        slots[i].SetItem(_inventory.items[i]);
        //    }
        //     else
        //     {
        //        slots[i].Clear();
        //     }
            
        // }
    }
}
