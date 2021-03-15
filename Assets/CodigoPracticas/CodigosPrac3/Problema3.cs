using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

      int[] nums = {15,2,11,7};
      int target = 9; 

      SumaDos( nums, target);
      
      for(int p = 0; p <= 1 ; p++ )
      Debug.Log(nums[p]);

    }
    
    //Funcion que regresa los dos indice de los dos numeros enteros que sumados den igual a target
    public int[] SumaDos(int[] nums, int target)
    {
        int[] aux = nums;
        int auxTarget = 0, cont = 0;
        
        //ciclo para buscar indices
        for(int i = 0; i <= nums.Length; i++)
        {
            
            auxTarget = aux[cont] + nums[i];
            
            if(auxTarget == target){ 
                
                  nums[0] = cont;
                  nums[1] = i;
                  i=nums.Length;
            }
            else
            {
                if(i==nums.Length-1){
                    i=0;
                    cont++;
                }
                
            }
            auxTarget = 0;
         
        }

        
        return nums;

    }
    
}
