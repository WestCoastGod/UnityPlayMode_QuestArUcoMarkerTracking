using UnityEngine;
using UnityEngine.UI;

public class CameraFeedToRawImage : MonoBehaviour
{
    public TryAR.MarkerTracking.ArUcoMarkerTracking markerTracking; // 拖拽 ArUcoMarkerTracking 脚本
    private RawImage rawImage;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    void Update()
    {
        if (markerTracking != null && markerTracking.resultTexture != null)
        {
            rawImage.texture = markerTracking.resultTexture;
        }
    }
}