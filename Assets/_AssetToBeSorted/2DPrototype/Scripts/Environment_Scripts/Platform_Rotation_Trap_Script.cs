using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Platform_Rotation_Trap_Script : MonoBehaviour
{
    public float platformDelayTimer;
    public float platformRotationSpeed;
    public Transform startPlatformStage;
    public Transform endPlatformStage;

    public bool platformStartTimer = false;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            platformStartTimer = true;
            startRotationTimer();
        }
        
     }


    public void startRotationTimer() {

        transform.rotation = Quaternion.Lerp(startPlatformStage.rotation, endPlatformStage.rotation, Time.time * platformRotationSpeed);

    }


}
