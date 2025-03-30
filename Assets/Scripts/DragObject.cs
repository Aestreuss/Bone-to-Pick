using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour
{
    private Vector2 mousePosition;

    private float offsetX, offsetY;

    public static bool mouseButtonReleased;

    private void OnMouseDown()
    {
        Debug.Log("clicking");
        mouseButtonReleased = false; //checks for mouse
        // calculates offset between mouse position and the center of the game object that will be dragged (without this it will jump directly to the mouse pointer)
        offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;   
        offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag()
    {
        //
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - offsetX, mousePosition.y - offsetY);
    }

    private void OnMouseUp()
    {
        mouseButtonReleased = true; //checks for mouse 
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        string thisGameobjectName;
        string collisionGameobjectName;

        //grabs the names of the objects being merged when they are colliding with another object of the same type 
        thisGameobjectName = gameObject.name.Substring(0, name.IndexOf("_")); 
        collisionGameobjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));

        //will check if button is release and if the names are equal to what i want them to be.
        if (mouseButtonReleased && thisGameobjectName == "bone1" && thisGameobjectName == collisionGameobjectName)
        {
            Instantiate(Resources.Load("bone2_object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (mouseButtonReleased && thisGameobjectName == "bone2" && thisGameobjectName == collisionGameobjectName)
        {
            Instantiate(Resources.Load("bone3_object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (mouseButtonReleased && thisGameobjectName == "bone3" && thisGameobjectName == collisionGameobjectName)
        {
            Instantiate(Resources.Load("bone4_object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (mouseButtonReleased && thisGameobjectName == "bone4" && thisGameobjectName == collisionGameobjectName)
        {
            Instantiate(Resources.Load("bone5_object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (mouseButtonReleased && thisGameobjectName == "bone5" && thisGameobjectName == collisionGameobjectName)
        {
            Instantiate(Resources.Load("bone6_object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
