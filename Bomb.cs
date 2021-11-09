using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject Player;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            Instantiate(explosionPrefab, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
