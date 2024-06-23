using UnityEngine;

/*
ButtonUIではなく，画像クリックで動かすための処理．
現在（モック作成中）は使っていない．
*/

public class StartButton : MonoBehaviour
{
    BaseButton button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<BaseButton>();
        Debug.Log(button);
    }

    // Update is called once per frame
    void Update()
    {
        button.onClickCallback = () =>
        {
            Debug.Log("タップした時の処理");
        };
    }


}
