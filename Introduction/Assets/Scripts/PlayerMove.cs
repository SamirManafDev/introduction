using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
    [SerializeField] private float speed=1;
    private float _vertical;
    private float _horizontal;
    
    private void Start()
    {
        BoxCollider [] coll = GetComponentsInChildren<BoxCollider>();
        

        for (int i = 0; i < coll.Length; i++)
        {
            coll[i].enabled = false;
        }
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    gameObject.name = "Mini";
        //    gameObject.tag = "Player";
        //    Debug.Log("Enemy adı və tag-ı dəyişdirildi: Mini");
        //}
        

            _vertical=Input.GetAxis("Vertical");
            _horizontal=Input.GetAxis("Horizontal");
            
            transform.position += new Vector3(_horizontal, 0, _vertical)*Time.deltaTime*speed;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag=="Coin") 
    //    {
    //        collision.gameObject.SetActive(false);
    //        //Destroy(collision.gameObject);
    //    }
    //}
}
