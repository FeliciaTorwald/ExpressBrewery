using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbBox : MonoBehaviour
{
    bool canPickUp;
    public GameObject herb;
    public Transform hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canPickUp)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(herb,hand);
                
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPickUp = true;
        }
        else
        {
            canPickUp = false;
        }
    }
}
