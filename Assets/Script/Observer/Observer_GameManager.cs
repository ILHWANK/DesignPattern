using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIType
{
    Status,
    Inventory,
    Equip,
}

public class Observer_GameManager : MonoBehaviour
{
    public ObserverPattern StatusUI;
    public ObserverPattern InventoryUI;
    public ObserverPattern EquipUI;

    // UI가 생성되거나 삭제 될때 Subject를 통해서 진행
    Subject subject = new Subject();

    // UI가 열릴 때 호출
    public void OnClickOpen(int type)
    {
        switch ((UIType)type)
        {
            case UIType.Status: // 상태창
                StatusUI.gameObject.SetActive(true);
                subject.AddObserver(StatusUI);
                break;
            case UIType.Inventory: // 인벤토리
                InventoryUI.gameObject.SetActive(true);
                subject.AddObserver(InventoryUI);
                break;
            case UIType.Equip: // 장비창
                EquipUI.gameObject.SetActive(true);
                subject.AddObserver(EquipUI);
                break;
        }
        
    }

    // UI가 닫힐 때 호출
    public void OnClickClose(int type)
    {
        switch ((UIType)type)
        {
            case UIType.Status:
                StatusUI.gameObject.SetActive(false);
                subject.RemoveObserver(StatusUI);
                break;
            case UIType.Inventory:
                InventoryUI.gameObject.SetActive(false);
                subject.RemoveObserver(InventoryUI);
                break;
            case UIType.Equip:
                EquipUI.gameObject.SetActive(false);
                subject.RemoveObserver(EquipUI);
                break;
        }
    }

    // 게임 내 변화가 있을 때
    private void Update()
    {
        // 키 입력으로 대체
        if (Input.GetKeyUp(KeyCode.A))
        {
            // 캐릭터 채인지
            Debug.Log("캐릭터에 변화가 있습니다.");
            subject.Message(Event.StatusChange);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            // 아이템 획득
            Debug.Log("아이템을 획득 했습니다.");
            subject.Message(Event.GetItem);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            // 장비 장착
            Debug.Log("장비를 장착합니다.");
            subject.Message(Event.Equipment);
        }
    }
}
