using UnityEngine;

public class PathFindingAStar : MonoBehaviour {
	private UnityEngine.AI.NavMeshAgent agent;
	public  Transform    target;

	public void Start() {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.SetDestination(target.position);
	}

	public void Update() {
		agent.SetDestination(target.position);
	}
}