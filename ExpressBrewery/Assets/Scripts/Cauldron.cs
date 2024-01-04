using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    //public List<HerbTypes> herbsInside = new List<HerbTypes>();
    //bool canInteract;
    //public Player player;
    //private void Update()
    //{
    //    if (canInteract)
    //    {
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            HerbTypes heldHerb = player.heldHerb;
    //            InteractWithCauldron(heldHerb);
    //        }
    //    }
    //}

    //public void AddHerbToCauldron(HerbTypes herbTypes)
    //{
    //    herbsInside.Add(herbTypes);
    //    Debug.Log("Added " + herbTypes + " to the cauldron.");
    //}

    //public void CheckHerbsInCauldron()
    //{
    //    if (herbsInside.Count > 0)
    //    {
    //        Debug.Log("Herbs in the cauldron:");
    //        foreach (var herb in herbsInside)
    //        {
    //            Debug.Log("- " + herb);
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("The cauldron is empty.");
    //    }
    //}

    //public void InteractWithCauldron(HerbTypes heldHerb)
    //{
    //    // Check which herb type the player is holding
    //    if (heldHerb != HerbTypes.None) // Assume you have a None option in your HerbType enum for no herb
    //    {
    //        // Add the held herb to the cauldron
    //        AddHerbToCauldron(heldHerb);

    //        // Check the herbs in the cauldron
    //        CheckHerbsInCauldron();
    //    }
    //    else
    //    {
    //        Debug.Log("No herb to add to the cauldron.");
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        canInteract = true;
    //    }
    //    else
    //    {
    //        canInteract = false;
    //    }
    //}
}

