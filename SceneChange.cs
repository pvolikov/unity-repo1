using UnityEngine;
using UnityEditor.SceneManagement;

public class Accelerator : MonoBehaviour
{
	public string sceneName;
	
	void OnTriggerEnter(Collider other)
	{
		EditorSceneManager.LoadScene(sceneName);
	} 
}
