using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public Transform[] ���u��m; //�ؼ�
    public GameObject[] ����;
    public int ��l�I��;
    int �ثe��m = 0;
    public bool �i�Y��l = false;
    public Text ��ܨB��;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ���� = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse1)) //�p�G���U(��})�ƹ��k��
        {
            //�i���Y��l���ʧ@
            ��l�I�� = Random.Range(1, 4);
            print(��l�I��);
            

            int �e�i�I�� = (��l�I�� + �ثe��m) ;
            if (�e�i�I�� >= ���u��m.Length) {
                �e�i�I�� = �e�i�I�� - ���u��m.Length;
            }
            �ثe��m = �e�i�I��;

            // ���u��m[��l�I��] 
            ����[0].GetComponent<�A�Ҳ���>().�U�@�ӥؼ�(���u��m[�e�i�I��]);
        }
    }
}
