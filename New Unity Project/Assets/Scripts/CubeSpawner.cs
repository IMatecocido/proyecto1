using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject prefabCubo;
    public List<GameObject> listadeCubos;
    public float factordeescalamiento;
    public int numcubos = 0;


    // Start is called before the first frame update
    void Start()
    {
        listadeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numcubos++;
        GameObject tempgameobject = Instantiate<GameObject>(prefabCubo);
        tempgameobject.name = "cubonumero" + numcubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempgameobject.GetComponent<MeshRenderer>().material.color = c;
        tempgameobject.transform.position = Random.insideUnitSphere;

        listadeCubos.Add(tempgameobject);
        List<GameObject> objetosparaeliminar = new List<GameObject>();
        foreach (GameObject go in listadeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factordeescalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosparaeliminar.Add(go);
            }
        }
        foreach (GameObject go in objetosparaeliminar)
        {
            listadeCubos.Remove(go);
            Destroy(go);
        }
    }
}


       

    

