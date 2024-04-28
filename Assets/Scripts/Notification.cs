using Unity.Notifications.Android;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    public string typeNotification;
    public string NotificationText;
    public void Activ()
    {
        Noting.typeNotification = typeNotification;
        Noting.NotificationText = NotificationText;
    }
}
