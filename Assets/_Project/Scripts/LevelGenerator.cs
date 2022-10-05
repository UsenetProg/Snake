using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] Prefabs;
    public int MinimumElement;
    public int MaximumElement;
    public float DistanceBeetwin;
    public Transform Finish;
    public Transform GroundRoot;
    private void Awake()
    {
        int platformsCount = Random.Range(MinimumElement, MaximumElement +1);
        for(int i = 0; i < platformsCount; i++)
        {
            int prefabIndex = Random.Range(0, Prefabs.Length);
            GameObject platform = Instantiate(Prefabs[prefabIndex], transform);
            platform.transform.localPosition = CalculatePrefabs(i);
            platform.transform.localRotation = Quaternion.identity;
        }
        Finish.localPosition = CalculatePrefabs(platformsCount);
        GroundRoot.localScale = new Vector3(1, 1, platformsCount * DistanceBeetwin);
    }
    private Vector3 CalculatePrefabs(int prefabIndex)
    {
        return new Vector3(0, 0, DistanceBeetwin * prefabIndex);
    }
}
