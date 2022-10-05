using UnityEngine;

public class Food : MonoBehaviour
{
    private Vector3 newPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player snakehead))
        {
            snakehead.Tail();
            Destroy(gameObject);

        }
    }
}
