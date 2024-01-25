using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class StartCamScript : MonoBehaviour
{
    public RectTransform SplitScreenBoarder;
    public GameObject playerCams;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Task.Delay(1000);
        Vector2 size = SplitScreenBoarder.sizeDelta;
        float interpolation = 1 * Time.deltaTime;
        size.y = Mathf.Lerp(SplitScreenBoarder.sizeDelta.y, 630, interpolation);
        SplitScreenBoarder.sizeDelta = size;
        if (SplitScreenBoarder.sizeDelta.y > 605)
        {
            playerCams.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
