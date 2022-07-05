using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{
    // Start is called before the first frame update
    public bool mine;
    public Sprite[] emptyTextures;
    public Sprite mineTexture;
    public AudioSource minee;
    


    public   gameover gameover;


    void Start()
    {
        ScoreScript.score = 0;
        mine = Random.value < Gamelevel.threshhold;
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        Playfield.elements[x, y] = this;
        //loadTexture(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadTexture(int adjacentCount)
    {
        if (mine)
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        else
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
    }
    public bool isCovered()
    {
        return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
    }
    void OnMouseUpAsButton()
    {
        // It's a mine
        if (mine)
        {
            Playfield.uncoverMines();
            minee.Play();
            // TODO: do stuff..
            print("you lose");
            StartCoroutine(abc());
        }
        // It's not a mine
        else
        {
            time.timer = Gamelevel.starttime;
            int x = (int)transform.position.x;
            int y = (int)transform.position.y;
            loadTexture(Playfield.adjacentMines(x, y));
            // TODO: do stuff.
            // .
            Playfield.FFuncover(x, y, new bool[Playfield.w, Playfield.h]);
            if (Playfield.isFinished())
                print("you win");
        }
    }

    IEnumerator abc()
    {
        yield return new WaitForSeconds(1);
        gameover.Setup(ScoreScript.score);
    }
}
