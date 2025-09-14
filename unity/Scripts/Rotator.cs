// This file must be placed in [Unity Project]/Assets/Scripts for detection to work
using UnityEngine;
public class Rotator : MonoBehaviour {
  public Vector3 SpeedEuler = new Vector3(0, 45, 0); // deg/sec
  void Update() { transform.Rotate(SpeedEuler * Time.deltaTime); }
}
