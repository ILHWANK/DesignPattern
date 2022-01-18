using UnityEngine;

public class UI_Equipment : ObserverPattern
{
    private void Start()
    {
        type = UIType.Equip;
    }

    public override void Notify(Event type)
    {
        switch (type)
        {
            // 장비 관련 부분만 업데이트
            case Event.Equipment:
                Debug.Log("장비 UI를 업데이트 합니다.");
                break;
        }
    }
}
