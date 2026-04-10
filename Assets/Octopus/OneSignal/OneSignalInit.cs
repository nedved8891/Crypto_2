using UnityEngine;
using OneSignalSDK;
using OneSignalSDK.Debug.Models;

public class OneSignalInit : MonoBehaviour
{
    async void Start()
    {
        // Enable verbose logging for debugging (remove in production)
        OneSignal.Debug.LogLevel = LogLevel.Verbose;
        // Initialize with your OneSignal App ID
        OneSignal.Initialize("f70a71df-563b-4462-9847-ebaae5aa0c49");
        // Use this method to prompt for push notifications.
        // We recommend removing this method after testing and instead use In-App Messages to prompt for notification permission.
        await OneSignal.Notifications.RequestPermissionAsync(true);
    }
}
