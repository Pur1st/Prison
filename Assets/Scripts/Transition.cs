using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Transition {
    [SerializeField]
    private KeyCode key;
    [SerializeField]
    private GameObject nextRoom;

    public KeyCode GetKey() {
        return key;
    }

    public GameObject GetNextRoom() {
        return nextRoom;
    }
}
