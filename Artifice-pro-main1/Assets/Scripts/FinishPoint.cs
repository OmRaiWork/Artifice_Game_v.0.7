using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.instance.PlayAudioClip(AudioManager.AudioType.LevelComplete);

            if (goNextLevel)
            {
                //go to next level
                
                this.wait(() => SceneController.instance.NextLevel(), 1);
            }
            else
            {
                this.wait(() => SceneController.instance.LoadScene(levelName), 1);
            }
        }
    }
}
