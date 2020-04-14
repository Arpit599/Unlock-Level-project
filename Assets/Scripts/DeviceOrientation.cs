using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeviceOrientation : MonoBehaviour
{
    public Image img;

    void Update()
    {
        // Vector3 movement = Input.acceleration;

        if (Input.deviceOrientation.ToString() == "FaceDown")
          Debug.Log("The device is facing parallel and towards the ground");
        //Debug.Log(movement);

        //    Debug.Log(Input.deviceOrientation);
        if (Input.GetKey(KeyCode.A))
            StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        float i = 0;
        while(i < 1)
        {
            img.color = new Color(0f, 0f, 0f, i);
            i += Time.deltaTime * 2f;
            yield return null;
        }
    }
}
