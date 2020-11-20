using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Platform_Movement_Script : MonoBehaviour
{
    public float platformMovementSpeed = 2;
    public GameObject[] wayPoints;

    int nextWaypoint = 1;
    float distToPoint;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }

    // Update is called once per frame
    void Update() {
        Move();
    }

    void Move() {

        distToPoint = Vector2.Distance(transform.position, wayPoints[nextWaypoint].transform.position);
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[nextWaypoint].transform.position, platformMovementSpeed * Time.deltaTime);
        
        if(distToPoint < 0.2) {
            ChooseNextWaypoint();
        } 
    }

    void ChooseNextWaypoint() {

        nextWaypoint++;

        if (nextWaypoint == wayPoints.Length) {
            nextWaypoint = 0;
        }
    }
}
