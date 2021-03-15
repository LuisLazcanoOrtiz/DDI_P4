using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaDos : MonoBehaviour
{
    public string Nombre; //variable publica para que el usuario coloque el nombre a encontrar
    private string Mensaje;

    // Start is called before the first frame update
    void Start()
    {
        
        //Ordena nombres en orden alfabetico
        List<string> names = new List<string>();

        //nombres desordenados alfabeticamente 
            names.Add("Felix Quintero");   
            names.Add("Araceli Luevano");
            names.Add("Luis Eloy");
            names.Add("Muguel Rosas");
            names.Add("Raul Rodriguez");
            names.Add("Ivan Morales");
            names.Sort();
            
            //imprime nombres ordenados alfabeticamente
            foreach (string s in names) 
            Debug.Log(s);
            
        NumbersLessThan( names,  Nombre ); //llamada a la funcion

        Debug.Log(Mensaje); //imprime mensaje true o false
       
    }
     
     //funcion para buscar el nombre intruducido en la lista de nombres
     private string NumbersLessThan(List<string> names, string Nombre )
    {
        int comparador = 0;

        //for para comparar nombre introducido con la lista de nombres
       for(int i = 0; i <= 5; i++ ){

            if(names[i] == Nombre)
            comparador = 1;
        }
        
        if(comparador == 1)
        Mensaje="True";
        else
        Mensaje="Flase";
      
      return Mensaje;
    } 
    
}
