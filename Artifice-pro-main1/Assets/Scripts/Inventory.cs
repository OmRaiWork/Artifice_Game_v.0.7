using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Text OrbCounter;

    private int orbs = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectible"))
        {
            Collect(other.GetComponent<Collectible>());
        }
    }
    private void Collect(Collectible collectible)
    {
        if(collectible.Collect())
        {
            if(collectible is OrbCollectible)
            {
                AudioManager.instance.PlayAudioClip(AudioManager.AudioType.Collectible);
                orbs++;
            }
            UpdateGUI();
        }
    }
    private void UpdateGUI()
    {
        OrbCounter.text = orbs.ToString();
    }
}
