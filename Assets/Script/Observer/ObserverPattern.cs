using UnityEngine;

// 옵저버 패턴의 원형
public class ObserverPattern : MonoBehaviour
{
    public ObserverPattern nextOb = null;

    public UIType type;


    // 옵저버를 산속받는 클래스틀은 다음 함스를 꼭 구현해야 한다.
    public virtual void Notify(Event type)
    {
        // 데이터가 전잘 되었을 때 수행해야 하는 일들을 진행할 수 있다.
    }
}
