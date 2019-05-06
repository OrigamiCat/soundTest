using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public float vector;
    public GameObject Meteorite;

    void Start()
    {

    }

    void Update()
    {
        this.transform.position += new Vector3(0, 0, vector);

        if(this.transform.position.z < -100.0)
        {
            Destroy(this.gameObject);

            Instantiate(Meteorite);
        }
    }
}
