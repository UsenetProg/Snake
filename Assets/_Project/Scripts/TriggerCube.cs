using UnityEngine;

public class TriggerCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        
    }
}
