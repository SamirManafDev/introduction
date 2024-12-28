using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.name = "MiniEn";
            gameObject.tag = "MiniEn";
            Debug.Log("Enemy adı və tag-ı dəyişdirildi: MiniEn");
        }
    }
}
