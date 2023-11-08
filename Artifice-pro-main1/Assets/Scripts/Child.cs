using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.5f;
    public GameObject playerObject;
    Vector2 difference = Vector2.zero;
    public Transform playerTransform;
    private bool isPlayerMoving = false;
    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    public void SetPlayerMoving(bool isMoving)
    {
        isPlayerMoving = isMoving;
    }
    void Update()
    {

        if (playerObject.GetComponent<Rigidbody2D>().velocity.magnitude > 0.1f)
        {
            isPlayerMoving = true;
        }



        if (isPlayerMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
