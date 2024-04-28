using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;
using UnityEngine.UI;

public class Noting : MonoBehaviour
{
    public Dropdown HourDrop, MinutDrop, SecondDrop;
    private const int HourCount = 24, MinutAndSecondCount = 60;
    AndroidNotification notification = new AndroidNotification();

    public static string typeNotification;
    public static string NotificationText;


    private void Start()
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel();
        channel.Name = "Мой питомец";
        channel.Description = "что-то пришло...";
        channel.Id = "Notification";
        channel.Importance = Importance.High;

        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        RefrechCounDate(HourCount, HourDrop);
        RefrechCounDate(MinutAndSecondCount, MinutDrop);
        RefrechCounDate(MinutAndSecondCount, SecondDrop);
    }

    private void RefrechCounDate(int count, Dropdown dropdown)
    {
        for (int i = 0; i < count; i++)
        {
            dropdown.options.Add(new Dropdown.OptionData(i.ToString(), null));
        }
        dropdown.RefreshShownValue();
    }

    public void Notifications()
    {
        notification.Title = typeNotification;
        notification.Text = NotificationText;
        notification.FireTime = System.DateTime.Now.AddHours(HourDrop.value);
        notification.FireTime = System.DateTime.Now.AddMinutes(MinutDrop.value);
        notification.FireTime = System.DateTime.Now.AddSeconds(SecondDrop.value);

        Debug.Log(notification.FireTime);
        AndroidNotificationCenter.SendNotification(notification, "Notification");
    }
}
