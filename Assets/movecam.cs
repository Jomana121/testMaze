using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;      // مكان تخزين موقع اللاعب
    public Vector3 offset;        // المسافة بين الكاميرا واللاعب

    void Start()
    {
        // لو ما عينتي الاوفست من الانسبكتور، تقدر تعينه هنا تلقائياً
        if (offset == Vector3.zero)
            offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // تحريك الكاميرا بحيث تلحق اللاعب مع الحفاظ على المسافة (offset)
        if (player != null)
            transform.position = player.position + offset;
    }
}
