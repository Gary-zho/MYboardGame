using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //������l 1-3
    int �B��;
    //���I
    public Transform[] ���I;
    [SerializeField] GameObject[] ����;
    int �e�i = 0;
    public Text ��ܨB��;
    public bool �i�Y��l = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ���� = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && �i�Y��l)
        {
            �B�� = Random.Range(1, 4);
            print(�B��);
            ��ܨB��.text = "�B��: " + �B��.ToString();
            �e�i = �e�i + �B��;
            if(�e�i > ���I.Length)
            {
                �e�i = �e�i - ���I.Length;
            }
            ����[0].GetComponent<�A�Ҳ���>().�U�@�ӥؼ�(���I[�e�i]);
            �i�Y��l = false;
        }
    }
}
