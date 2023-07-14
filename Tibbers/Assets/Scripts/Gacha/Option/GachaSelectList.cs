using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaSelectList : MonoBehaviour
{
    public List<GachaOption> gachaOptionList;

    public RectTransform container;

    public GameObject buttonPrefab;

    public Sprite eeeeeeee;
    // Start is called before the first frame update
    void Start()
    {
        // TODO: ������ ����
        gachaOptionList = new List<GachaOption>
        {
            // �ӽ� �׽�Ʈ ���̽�
            new GachaOption("�Ϲ� ��í", false, Color.red, Color.yellow, Color.black, eeeeeeee),
            new GachaOption("�Ϲ�2 ��í", false, Color.yellow, Color.yellow, Color.black, eeeeeeee),
            new GachaOption("Ȯ���� ��í", true, Color.green, Color.gray, Color.black, eeeeeeee),
            new GachaOption("Ȯ����2 ��í", true, Color.blue, Color.cyan, Color.black, eeeeeeee),
            new GachaOption("Ȯ����3 ��í", true, Color.blue, Color.cyan, Color.black, eeeeeeee),
            new GachaOption("Ȯ����4 ��í", true, Color.blue, Color.cyan, Color.black, eeeeeeee),
            new GachaOption("Ȯ����5 ��í", true, Color.blue, Color.cyan, Color.black, eeeeeeee),
            new GachaOption("Ȯ����6 ��í", true, Color.blue, Color.cyan, Color.black, eeeeeeee),
            new GachaOption("Ȯ����7 ��í", true, Color.blue, Color.cyan, Color.black, eeeeeeee),
            new GachaOption("Ȯ����8 ��í", true, Color.blue, Color.cyan, Color.black, eeeeeeee)
        };

        renderGachaEventButtons();
    }

    private void renderGachaEventButtons()
    {
        for (int i = 0; i < gachaOptionList.Count; i++)
        {
            GameObject buttonObject = Instantiate(buttonPrefab, new Vector3(0, i * 200, 0), Quaternion.identity);
            buttonObject.transform.SetParent(container.transform);
            buttonObject.GetComponentInChildren<TMPro.TMP_Text>().text = gachaOptionList[i].GetGachaOption();
            buttonObject.GetComponentInChildren<TMPro.TMP_Text>().color = gachaOptionList[i].GetGachaTextColor();
            buttonObject.GetComponent<Image>().color = gachaOptionList[i].GetGachaBackGround();
            // RectTransform buttonTransform = buttonObject.GetComponent<RectTransform>();
            // gachaOption;
            // ��ư ��ġ �� ũ�� ����
            // buttonTransform.anchoredPosition = new Vector2(0, -i * (buttonPrefab.transform.x + spacing));
            // buttonTransform.sizeDelta = new Vector2(container.sizeDelta.x, buttonHeight);

            // ��ư �ؽ�Ʈ ���� (����)
            // Text buttonText = buttonObj.GetComponentInChildren<Text>();
            // buttonText.text = "Button " + i;
        }
    }
}
