using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboarding : MonoBehaviour
{
    private Camera theCam;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MyFunction", 4, 1.5f);
        theCam = Camera.main;
    }
void MyFunction()
{
    

    // Update is called once per frame
      transform.LookAt(theCam.transform);
        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
}
}
