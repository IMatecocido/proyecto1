using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;

        print("algo salio mal");

    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        Debug.Log("hola desde update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola mundo desdes logwarning 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("hola desde latedate");
    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitado");
    }
}
