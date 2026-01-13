using UnityEngine;

public class Accelerator : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		other.GetComponent<FirstPersonMovement>().speed *= 2;
		other.GetComponent<FirstPersonMovement>().runSpeed *= 2;
	} 

	void OnTriggerExit(Collider other)
	{
		other.GetComponent<FirstPersonMovement>().speed /= 2;
		other.GetComponent<FirstPersonMovement>().runSpeed /= 2;
	} 
}
