using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Se debe ingresar la cantidad de entradas vendidas para cada tipo.
//Sabemos que el límite de espectadores totales en el predio del evento es de 20,400 personas en Campo y 16,200 en Plateas y el precio de las entradas es de $1200 para Campo y $2000 para Platea.

//El programa debe cumplir los siguientes requerimientos:
//Se debe mostrar en consola un mensaje informando la recaudación por entradas de campo y de plateas por separado y luego el total sumado. 


//Se debe mostrar qué cantidad del total de la capacidad del predio quedó vacante. Si las entradas vendidas equivalen al total de la capacidad del predio debe mostrarse además el mensaje “Sold Out!”.


//Si la suma de la cantidad de entradas para ambos tipos supera la mitad de la  capacidad del predio debe mostrarse el mensaje “El festival fue un éxito!”. Si no lo supera debe mostrarse “Debemos mejorar la convocatoria.


//Debe mostrarse un mensaje de error descriptivo y no realizar ningún cálculo si la cantidad de entradas vendidas en cualquiera de los tipos es menor a cero o superior a la capacidad del predio para ese tipo.

public class Evaluacion : MonoBehaviour
{
    int espacioCampo = 20400;
    int espacioPlatea = 16200;

    public int entradasVendidasCampo;
    public int entradasVendidasPlatea;

    
    void Start()
    {
        Debug.Log("La recaudacion por entradas de campo en caso de vender todas las entradas es: " + espacioCampo * 1200 + " pesos , la recaudacion por netradas de platea en caso de que se vendan todas la entradas es: " + espacioPlatea * 2000 + " pesos" + "y el total es: " + (espacioPlatea*2000+espacioCampo*1200));
        Debug.Log("Quedo vacante en el campo de: " + (espacioCampo - entradasVendidasCampo) + " Y quedo vacante en la platea de: " + (espacioPlatea - entradasVendidasPlatea));

        if(entradasVendidasCampo == espacioCampo && entradasVendidasPlatea == espacioPlatea)
        {
            Debug.Log("Sold OUT!");
        }
        else if((entradasVendidasCampo + entradasVendidasPlatea) >= ((espacioPlatea + espacioCampo)/2))
        {
            Debug.Log("El festival fue un éxito!");
        }
        else
        {
            Debug.Log("Debemos mejorar la convocatoria");
        }

    }
        


    // Update is called once per frame
    void Update()
    {
        
    }
}
