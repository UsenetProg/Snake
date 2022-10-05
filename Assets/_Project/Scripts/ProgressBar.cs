using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player player;
    public Transform Finish;
    public Slider slider;
    private float startZ;
    

    private void Start()
    {
        startZ = player.transform.position.z;
    }
    private void Update()
    {
        float currentZ = player.transform.position.z;
        float finishZ = Finish.transform.position.z;
        float t = Mathf.InverseLerp(startZ, finishZ, currentZ);
        slider.value = t;
    }
}
