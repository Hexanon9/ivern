using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaEventList : MonoBehaviour
{
    public List<GachaEvent> gachaEventList;

    public RectTransform container;

    public GameObject buttonPrefab;

    public Sprite eeeeeeee;
    // Start is called before the first frame update
    void Start()
    {
        // TODO: ������ ����
        gachaEventList = new List<GachaEvent>
        {
            // �ӽ� �׽�Ʈ ���̽�
            new GachaEvent("�Ϲ� ��í", System.DateTime.Now, Color.red,  Color.black, eeeeeeee),
            new GachaEvent("�Ϲ�2 ��í", System.DateTime.Now, Color.yellow,  Color.black, eeeeeeee),
            new GachaEvent("Ȯ���� ��í", System.DateTime.Now, Color.green, Color.black, eeeeeeee),
            new GachaEvent("Ȯ����2 ��í", System.DateTime.Now, Color.blue, Color.black, eeeeeeee),
            new GachaEvent("Ȯ����3 ��í", System.DateTime.Now, Color.blue, Color.black, eeeeeeee),
            new GachaEvent("Ȯ����4 ��í", System.DateTime.Now, Color.blue, Color.black, eeeeeeee),
            new GachaEvent("Ȯ����5 ��í", System.DateTime.Now, Color.blue, Color.black, eeeeeeee),
            new GachaEvent("Ȯ����6 ��í", System.DateTime.Now, Color.blue, Color.black, eeeeeeee),
            new GachaEvent("Ȯ����7 ��í", System.DateTime.Now, Color.blue, Color.black, eeeeeeee),
            new GachaEvent("Ȯ����8 ��í", System.DateTime.Now, Color.blue, Color.black, eeeeeeee)
        };

        renderGachaEventButtons();
    }

    private void renderGachaEventButtons()
    {
        for (int i = 0; i < gachaEventList.Count; i++)
        {
            GameObject buttonObject = Instantiate(buttonPrefab, new Vector3(0, i * 200, 0), Quaternion.identity);
            buttonObject.transform.SetParent(container.transform);
            buttonObject.GetComponentInChildren<TMPro.TMP_Text>().text = gachaEventList[i].GetGachaEventName();
            buttonObject.GetComponentInChildren<TMPro.TMP_Text>().color = gachaEventList[i].GetGachaEventTextColor();
            buttonObject.GetComponent<Image>().color = gachaEventList[i].GetGachaEventBackGroundColor();
        }
    }
}
