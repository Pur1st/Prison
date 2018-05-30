using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour {
    [SerializeField]
    private List<Transition> transitions;

	void Update () {
        HandleTransition();
	}

    void HandleTransition() {
        foreach (Transition transition in transitions)
        {
            if (Input.GetKeyDown(transition.GetKey()))
            {
                GameObject nextRoom = Instantiate(transition.GetNextRoom(), transform.parent);
                Destroy(this.gameObject);
            }
        }
    }
}
