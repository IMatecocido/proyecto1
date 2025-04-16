using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
       
    }
    void Start()
    {
        Componente1.miObjeto.name = "NuevoNombredemiObjeto";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
