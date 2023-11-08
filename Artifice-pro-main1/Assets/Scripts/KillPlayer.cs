using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;
   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.instance.PlayAudioClip(AudioManager.AudioType.Death);

            //SceneManager.LoadScene(Respawn);
            this.wait(() => SceneManager.LoadScene(Respawn),1);
        }

        if (other.CompareTag("player"))
        {
            AudioManager.instance.PlayAudioClip(AudioManager.AudioType.Death);
            //SceneManager.LoadScene(Respawn);
            this.wait(() => SceneManager.LoadScene(Respawn), 1);
        }
    }
}
