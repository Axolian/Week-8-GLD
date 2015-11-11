// MoveTo.cs
using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	// Use this for initialization

	public Transform goal;
	NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = goal.position;

	}
}
