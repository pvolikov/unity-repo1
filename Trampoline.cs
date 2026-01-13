using UnityEngine;

public class Trampoline : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		other.GetComponent<Jump>().jumpStrength *= 5;
	} 

	void OnTriggerExit(Collider other)
	{
		other.GetComponent<Jump>().jumpStrength /= 5;
	} 
}
