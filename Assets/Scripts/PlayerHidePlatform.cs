using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHidePlatform : MonoBehaviour
{
    public Text levelText;
    public Text winText;
    private int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "Līmenis: 1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
            // ja tags ar ko ir sadursem ir "Collectable items"
        if(other.gameObject.CompareTag("Gate")){
            // disable-ot to (padarīt neredzamu)
            other.transform.parent.gameObject.SetActive(false);
            count += 1;
            updateText();
        }else if(other.gameObject.CompareTag("Final Gate")){
            // disable-ot to (padarīt neredzamu)
            other.transform.parent.gameObject.SetActive(false);
            count += 1;
            updateText();
            winText.text = "Tu uzvarēji!";
        }
        
    }
    private void updateText(){
        levelText.text = "Līmenis: " + count.ToString();
    }
}
