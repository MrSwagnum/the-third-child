using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
 public float speed = 15.0f;
 public int damage = 1;
 void Update() {
 transform.Translate(0, 0, speed * Time.deltaTime);
 }
 void OnTriggerEnter(Collider other) {
 FirstPersonController player = other.GetComponent<FirstPersonController>();
 if (player != null) {
 Debug.Log("Player hit");
 }
 Destroy(this.gameObject);
 }
}