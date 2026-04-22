using UnityEngine;

public class LevelSelecter : MonoBehaviour
{
    [SerializeField] GameObject levelSelecterCanvas;

    public void SetActiveCanvas(bool isActive)
    {
        levelSelecterCanvas.SetActive(isActive);
    }

    void Start()
    {
        SetActiveCanvas(false);
    }
}
