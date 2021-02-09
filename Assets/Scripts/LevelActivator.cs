using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class LevelActivator : MonoBehaviour {

   
    public GameObject Bloco1Go;
	public GameObject Bloco1Done;
	public GameObject Bloco1Star1;
	public GameObject Bloco1Star2;
	public GameObject Bloco1Star3;

	public GameObject Bloco2Go;
	public GameObject Bloco2NoGo;
	public GameObject Bloco2Done;
	public GameObject Bloco2Star1;
	public GameObject Bloco2Star2;
	public GameObject Bloco2Star3;

	public GameObject Bloco3Go;
	public GameObject Bloco3NoGo;
	public GameObject Bloco3Done;
	public GameObject Bloco3Star1;
	public GameObject Bloco3Star2;
	public GameObject Bloco3Star3;

	public GameObject Bloco4Go;
	public GameObject Bloco4NoGo;
	public GameObject Bloco4Done;
	public GameObject Bloco4Star1;
	public GameObject Bloco4Star2;
	public GameObject Bloco4Star3;

	public GameObject Bloco5Go;
	public GameObject Bloco5NoGo;
	public GameObject Bloco5Done;
	public GameObject Bloco5Star1;
	public GameObject Bloco5Star2;
	public GameObject Bloco5Star3;

   

    public GameObject Bloco6Go;
    public GameObject Bloco6NoGo;
    public GameObject Bloco6Done;
    public GameObject Bloco6Star1;
    public GameObject Bloco6Star2;
    public GameObject Bloco6Star3;

    public GameObject Bloco7Go;
    public GameObject Bloco7NoGo;
    public GameObject Bloco7Done;
    public GameObject Bloco7Star1;
    public GameObject Bloco7Star2;
    public GameObject Bloco7Star3;

    public GameObject Bloco8Go;
    public GameObject Bloco8NoGo;
    public GameObject Bloco8Done;
    public GameObject Bloco8Star1;
    public GameObject Bloco8Star2;
    public GameObject Bloco8Star3;

    public GameObject Bloco9Go;
    public GameObject Bloco9NoGo;
    public GameObject Bloco9Done;
    public GameObject Bloco9Star1;
    public GameObject Bloco9Star2;
    public GameObject Bloco9Star3;

    public GameObject Bloco10Go;
    public GameObject Bloco10NoGo;
    public GameObject Bloco10Done;
    public GameObject Bloco10Star1;
    public GameObject Bloco10Star2;
    public GameObject Bloco10Star3;



    public GameObject Bloco11Go;
    public GameObject Bloco11NoGo;
    public GameObject Bloco11Done;
    public GameObject Bloco11Star1;
    public GameObject Bloco11Star2;
    public GameObject Bloco11Star3;

    public GameObject Bloco12Go;
    public GameObject Bloco12NoGo;
    public GameObject Bloco12Done;
    public GameObject Bloco12Star1;
    public GameObject Bloco12Star2;
    public GameObject Bloco12Star3;

    public GameObject Bloco13Go;
    public GameObject Bloco13NoGo;
    public GameObject Bloco13Done;
    public GameObject Bloco13Star1;
    public GameObject Bloco13Star2;
    public GameObject Bloco13Star3;

    public GameObject Bloco14Go;
    public GameObject Bloco14NoGo;
    public GameObject Bloco14Done;
    public GameObject Bloco14Star1;
    public GameObject Bloco14Star2;
    public GameObject Bloco14Star3;

    public GameObject Bloco15Go;
    public GameObject Bloco15NoGo;
    public GameObject Bloco15Done;
    public GameObject Bloco15Star1;
    public GameObject Bloco15Star2;
    public GameObject Bloco15Star3;	  

	void Start () {

        SaveRanking.LoadGame();

		if (global::SaveRanking.SomOn == 1) {			
			AudioListener.volume = 0f;
		}
		if (global::SaveRanking.SomOn == 0) {			
			AudioListener.volume = 1f;
		}

		if (global::SaveRanking.LevelProgress == 0) {

            Bloco1Go.SetActive (true);
            Bloco1Done.SetActive (false);
            Bloco1Star1.SetActive (false);
            Bloco1Star2.SetActive (false);
            Bloco1Star3.SetActive (false);

            Bloco2Go.SetActive (false);
            Bloco2NoGo.SetActive (true);
            Bloco2Done.SetActive (false);
            Bloco2Star1.SetActive (false);
            Bloco2Star2.SetActive (false);
            Bloco2Star3.SetActive (false);

            Bloco3Go.SetActive (false);
            Bloco3NoGo.SetActive (true);
            Bloco3Done.SetActive (false);
            Bloco3Star1.SetActive (false);
            Bloco3Star2.SetActive (false);
            Bloco3Star3.SetActive (false);

            Bloco4Go.SetActive (false);
            Bloco4NoGo.SetActive (true);
            Bloco4Done.SetActive (false);
            Bloco4Star1.SetActive (false);
            Bloco4Star2.SetActive (false);
            Bloco4Star3.SetActive (false);

            Bloco5Go.SetActive (false);
            Bloco5NoGo.SetActive (true);
            Bloco5Done.SetActive (false);
            Bloco5Star1.SetActive (false);
            Bloco5Star2.SetActive (false);
            Bloco5Star3.SetActive (false);


            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(true);
            Bloco6Done.SetActive(false);
            Bloco6Star1.SetActive(false);
            Bloco6Star2.SetActive(false);
            Bloco6Star3.SetActive(false);

            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(true);
            Bloco7Done.SetActive(false);
            Bloco7Star1.SetActive(false);
            Bloco7Star2.SetActive(false);
            Bloco7Star3.SetActive(false);

            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(true);
            Bloco8Done.SetActive(false);
            Bloco8Star1.SetActive(false);
            Bloco8Star2.SetActive(false);
            Bloco8Star3.SetActive(false);

            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);
            Bloco9Star1.SetActive(false);
            Bloco9Star2.SetActive(false);
            Bloco9Star3.SetActive(false);

            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);
            Bloco10Star1.SetActive(false);
            Bloco10Star2.SetActive(false);
            Bloco10Star3.SetActive(false);

            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);
            Bloco11Star1.SetActive(false);
            Bloco11Star2.SetActive(false);
            Bloco11Star3.SetActive(false);

            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);
            Bloco12Star1.SetActive(false);
            Bloco12Star2.SetActive(false);
            Bloco12Star3.SetActive(false);

            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);
            Bloco13Star1.SetActive(false);
            Bloco13Star2.SetActive(false);
            Bloco13Star3.SetActive(false);

            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);
            Bloco14Star1.SetActive(false);
            Bloco14Star2.SetActive(false);
            Bloco14Star3.SetActive(false);

            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);
            Bloco15Star1.SetActive(false);
            Bloco15Star2.SetActive(false);
            Bloco15Star3.SetActive(false);

        }
		if (global::SaveRanking.LevelProgress == 1) {

            Bloco1Go.SetActive (false);
            Bloco1Done.SetActive (true);

            Bloco2Go.SetActive (true);
            Bloco2NoGo.SetActive (false);
            Bloco2Done.SetActive (false);

            Bloco3Go.SetActive (false);
            Bloco3NoGo.SetActive (true);
            Bloco3Done.SetActive (false);

            Bloco4Go.SetActive (false);
            Bloco4NoGo.SetActive (true);
            Bloco4Done.SetActive (false);

            Bloco5Go.SetActive (false);
            Bloco5NoGo.SetActive (true);
            Bloco5Done.SetActive (false);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(true);
            Bloco6Done.SetActive(false);
          

            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(true);
            Bloco7Done.SetActive(false);
           

            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(true);
            Bloco8Done.SetActive(false);
           

            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);
        

            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);
           

            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);
         

            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);
        

            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);
       

            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);
          

            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);
           


        }
		if (global::SaveRanking.LevelProgress == 2) {

            Bloco1Go.SetActive (false);
            Bloco1Done.SetActive (true);

            Bloco2Go.SetActive (false);
            Bloco2NoGo.SetActive (false);
            Bloco2Done.SetActive (true);

            Bloco3Go.SetActive (true);
            Bloco3NoGo.SetActive (false);
            Bloco3Done.SetActive (false);

            Bloco4Go.SetActive (false);
            Bloco4NoGo.SetActive (true);
            Bloco4Done.SetActive (false);

            Bloco5Go.SetActive (false);
            Bloco5NoGo.SetActive (true);
            Bloco5Done.SetActive (false);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(true);
            Bloco6Done.SetActive(false);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(true);
            Bloco7Done.SetActive(false);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(true);
            Bloco8Done.SetActive(false);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }
		if (global::SaveRanking.LevelProgress == 3) {

            Bloco1Go.SetActive (false);
            Bloco1Done.SetActive (true);

            Bloco2Go.SetActive (false);
            Bloco2NoGo.SetActive (false);
            Bloco2Done.SetActive (true);

            Bloco3Go.SetActive (false);
            Bloco3NoGo.SetActive (false);
            Bloco3Done.SetActive (true);

            Bloco4Go.SetActive (true);
            Bloco4NoGo.SetActive (false);
            Bloco4Done.SetActive (false);

            Bloco5Go.SetActive (false);
            Bloco5NoGo.SetActive (true);
            Bloco5Done.SetActive (false);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(true);
            Bloco6Done.SetActive(false);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(true);
            Bloco7Done.SetActive(false);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(true);
            Bloco8Done.SetActive(false);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }
		if (global::SaveRanking.LevelProgress == 4) {

            Bloco1Go.SetActive (false);
            Bloco1Done.SetActive (true);

            Bloco2Go.SetActive (false);
            Bloco2NoGo.SetActive (false);
            Bloco2Done.SetActive (true);

            Bloco3Go.SetActive (false);
            Bloco3NoGo.SetActive (false);
            Bloco3Done.SetActive (true);

            Bloco4Go.SetActive (false);
            Bloco4NoGo.SetActive (false);
            Bloco4Done.SetActive (true);

            Bloco5Go.SetActive (true);
            Bloco5NoGo.SetActive (false);
            Bloco5Done.SetActive (false);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(true);
            Bloco6Done.SetActive(false);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(true);
            Bloco7Done.SetActive(false);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(true);
            Bloco8Done.SetActive(false);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }
		if (global::SaveRanking.LevelProgress == 5) {

            Bloco1Go.SetActive (false);
            Bloco1Done.SetActive (true);

            Bloco2Go.SetActive (false);
            Bloco2NoGo.SetActive (false);
            Bloco2Done.SetActive (true);

            Bloco3Go.SetActive (false);
            Bloco3NoGo.SetActive (false);
            Bloco3Done.SetActive (true);

            Bloco4Go.SetActive (false);
            Bloco4NoGo.SetActive (false);
            Bloco4Done.SetActive (true);

            Bloco5Go.SetActive (false);
            Bloco5NoGo.SetActive (false);
            Bloco5Done.SetActive (true);

            Bloco6Go.SetActive(true);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(false);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(true);
            Bloco7Done.SetActive(false);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(true);
            Bloco8Done.SetActive(false);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }

        
        if (global::SaveRanking.LevelProgress == 6)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(true);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(false);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(true);
            Bloco8Done.SetActive(false);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }
        if (global::SaveRanking.LevelProgress == 7)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(true);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(false);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(true);
            Bloco9Done.SetActive(false);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);

        }
        if (global::SaveRanking.LevelProgress == 8)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(true);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(false);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(true);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }
        if (global::SaveRanking.LevelProgress == 9)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(true);


            Bloco10Go.SetActive(true);
            Bloco10NoGo.SetActive(false);
            Bloco10Done.SetActive(false);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(true);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }
        

		if (global::SaveRanking.LevelProgress == 10)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(true);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(false);
            Bloco10Done.SetActive(true);


            Bloco11Go.SetActive(true);
            Bloco11NoGo.SetActive(false);
            Bloco11Done.SetActive(false);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(true);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);


        }
        if (global::SaveRanking.LevelProgress == 11)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(true);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(false);
            Bloco10Done.SetActive(true);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(false);
            Bloco11Done.SetActive(true);


            Bloco12Go.SetActive(true);
            Bloco12NoGo.SetActive(false);
            Bloco12Done.SetActive(false);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(true);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);

        }
        if (global::SaveRanking.LevelProgress == 12)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(true);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(false);
            Bloco10Done.SetActive(true);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(false);
            Bloco11Done.SetActive(true);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(false);
            Bloco12Done.SetActive(true);


            Bloco13Go.SetActive(true);
            Bloco13NoGo.SetActive(false);
            Bloco13Done.SetActive(false);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(true);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);

        }
        if (global::SaveRanking.LevelProgress == 13)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(true);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(false);
            Bloco10Done.SetActive(true);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(false);
            Bloco11Done.SetActive(true);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(false);
            Bloco12Done.SetActive(true);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(false);
            Bloco13Done.SetActive(true);


            Bloco14Go.SetActive(true);
            Bloco14NoGo.SetActive(false);
            Bloco14Done.SetActive(false);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(true);
            Bloco15Done.SetActive(false);

        }

        if (global::SaveRanking.LevelProgress == 14)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(true);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(false);
            Bloco10Done.SetActive(true);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(false);
            Bloco11Done.SetActive(true);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(false);
            Bloco12Done.SetActive(true);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(false);
            Bloco13Done.SetActive(true);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(false);
            Bloco14Done.SetActive(true);


			Bloco15Go.SetActive(true);
			Bloco15NoGo.SetActive(false);
            Bloco15Done.SetActive(false);

        }
        if (global::SaveRanking.LevelProgress == 15)
        {

            Bloco1Go.SetActive(false);
            Bloco1Done.SetActive(true);

            Bloco2Go.SetActive(false);
            Bloco2NoGo.SetActive(false);
            Bloco2Done.SetActive(true);

            Bloco3Go.SetActive(false);
            Bloco3NoGo.SetActive(false);
            Bloco3Done.SetActive(true);

            Bloco4Go.SetActive(false);
            Bloco4NoGo.SetActive(false);
            Bloco4Done.SetActive(true);

            Bloco5Go.SetActive(false);
            Bloco5NoGo.SetActive(false);
            Bloco5Done.SetActive(true);

            Bloco6Go.SetActive(false);
            Bloco6NoGo.SetActive(false);
            Bloco6Done.SetActive(true);


            Bloco7Go.SetActive(false);
            Bloco7NoGo.SetActive(false);
            Bloco7Done.SetActive(true);


            Bloco8Go.SetActive(false);
            Bloco8NoGo.SetActive(false);
            Bloco8Done.SetActive(true);


            Bloco9Go.SetActive(false);
            Bloco9NoGo.SetActive(false);
            Bloco9Done.SetActive(true);


            Bloco10Go.SetActive(false);
            Bloco10NoGo.SetActive(false);
            Bloco10Done.SetActive(true);


            Bloco11Go.SetActive(false);
            Bloco11NoGo.SetActive(false);
            Bloco11Done.SetActive(true);


            Bloco12Go.SetActive(false);
            Bloco12NoGo.SetActive(false);
            Bloco12Done.SetActive(true);


            Bloco13Go.SetActive(false);
            Bloco13NoGo.SetActive(false);
            Bloco13Done.SetActive(true);


            Bloco14Go.SetActive(false);
            Bloco14NoGo.SetActive(false);
            Bloco14Done.SetActive(true);


            Bloco15Go.SetActive(false);
            Bloco15NoGo.SetActive(false);
            Bloco15Done.SetActive(true);


        }
    
      





        if (global::SaveRanking.Bloco1StarINT == 0){

            Bloco1Star1.SetActive(false);
            Bloco1Star2.SetActive(false);
            Bloco1Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco1StarINT == 1){

            Bloco1Star1.SetActive(true);
            Bloco1Star2.SetActive(false);
            Bloco1Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco1StarINT == 2){

            Bloco1Star1.SetActive(true);
            Bloco1Star2.SetActive(true);
            Bloco1Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco1StarINT == 3){

            Bloco1Star1.SetActive(true);
            Bloco1Star2.SetActive(true);
            Bloco1Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco2StarINT == 0)
        {

            Bloco2Star1.SetActive(false);
            Bloco2Star2.SetActive(false);
            Bloco2Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco2StarINT == 1)
        {

            Bloco2Star1.SetActive(true);
            Bloco2Star2.SetActive(false);
            Bloco2Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco2StarINT == 2)
        {

            Bloco2Star1.SetActive(true);
            Bloco2Star2.SetActive(true);
            Bloco2Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco2StarINT == 3)
        {

            Bloco2Star1.SetActive(true);
            Bloco2Star2.SetActive(true);
            Bloco2Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco3StarINT == 0)
        {

            Bloco3Star1.SetActive(false);
            Bloco3Star2.SetActive(false);
            Bloco3Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco3StarINT == 1)
        {

            Bloco3Star1.SetActive(true);
            Bloco3Star2.SetActive(false);
            Bloco3Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco3StarINT == 2)
        {

            Bloco3Star1.SetActive(true);
            Bloco3Star2.SetActive(true);
            Bloco3Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco3StarINT == 3)
        {

            Bloco3Star1.SetActive(true);
            Bloco3Star2.SetActive(true);
            Bloco3Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco4StarINT == 0)
        {

            Bloco4Star1.SetActive(false);
            Bloco4Star2.SetActive(false);
            Bloco4Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco4StarINT == 1)
        {

            Bloco4Star1.SetActive(true);
            Bloco4Star2.SetActive(false);
            Bloco4Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco4StarINT == 2)
        {

            Bloco4Star1.SetActive(true);
            Bloco4Star2.SetActive(true);
            Bloco4Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco4StarINT == 3)
        {

            Bloco4Star1.SetActive(true);
            Bloco4Star2.SetActive(true);
            Bloco4Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco5StarINT == 0)
        {

            Bloco5Star1.SetActive(false);
            Bloco5Star2.SetActive(false);
            Bloco5Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco5StarINT == 1)
        {

            Bloco5Star1.SetActive(true);
            Bloco5Star2.SetActive(false);
            Bloco5Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco5StarINT == 2)
        {

            Bloco5Star1.SetActive(true);
            Bloco5Star2.SetActive(true);
            Bloco5Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco5StarINT == 3)
        {

            Bloco5Star1.SetActive(true);
            Bloco5Star2.SetActive(true);
            Bloco5Star3.SetActive(true);

        }



        if (global::SaveRanking.Bloco6StarINT == 0)
        {

            Bloco6Star1.SetActive(false);
            Bloco6Star2.SetActive(false);
            Bloco6Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco6StarINT == 1)
        {

            Bloco6Star1.SetActive(true);
            Bloco6Star2.SetActive(false);
            Bloco6Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco6StarINT == 2)
        {

            Bloco6Star1.SetActive(true);
            Bloco6Star2.SetActive(true);
            Bloco6Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco6StarINT == 3)
        {

            Bloco6Star1.SetActive(true);
            Bloco6Star2.SetActive(true);
            Bloco6Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco7StarINT == 0)
        {

            Bloco7Star1.SetActive(false);
            Bloco7Star2.SetActive(false);
            Bloco7Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco7StarINT == 1)
        {

            Bloco7Star1.SetActive(true);
            Bloco7Star2.SetActive(false);
            Bloco7Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco7StarINT == 2)
        {

            Bloco7Star1.SetActive(true);
            Bloco7Star2.SetActive(true);
            Bloco7Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco7StarINT == 3)
        {

            Bloco7Star1.SetActive(true);
            Bloco7Star2.SetActive(true);
            Bloco7Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco8StarINT == 0)
        {

            Bloco8Star1.SetActive(false);
            Bloco8Star2.SetActive(false);
            Bloco8Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco8StarINT == 1)
        {

            Bloco8Star1.SetActive(true);
            Bloco8Star2.SetActive(false);
            Bloco8Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco8StarINT == 2)
        {

            Bloco8Star1.SetActive(true);
            Bloco8Star2.SetActive(true);
            Bloco8Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco8StarINT == 3)
        {

            Bloco8Star1.SetActive(true);
            Bloco8Star2.SetActive(true);
            Bloco8Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco9StarINT == 0)
        {

            Bloco9Star1.SetActive(false);
            Bloco9Star2.SetActive(false);
            Bloco9Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco9StarINT == 1)
        {

            Bloco9Star1.SetActive(true);
            Bloco9Star2.SetActive(false);
            Bloco9Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco9StarINT == 2)
        {

            Bloco9Star1.SetActive(true);
            Bloco9Star2.SetActive(true);
            Bloco9Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco9StarINT == 3)
        {

            Bloco9Star1.SetActive(true);
            Bloco9Star2.SetActive(true);
            Bloco9Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco10StarINT == 0)
        {

            Bloco10Star1.SetActive(false);
            Bloco10Star2.SetActive(false);
            Bloco10Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco10StarINT == 1)
        {

            Bloco10Star1.SetActive(true);
            Bloco10Star2.SetActive(false);
            Bloco10Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco10StarINT == 2)
        {

            Bloco10Star1.SetActive(true);
            Bloco10Star2.SetActive(true);
            Bloco10Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco10StarINT == 3)
        {

            Bloco10Star1.SetActive(true);
            Bloco10Star2.SetActive(true);
            Bloco10Star3.SetActive(true);

        }




        if (global::SaveRanking.Bloco11StarINT == 0)
        {

            Bloco11Star1.SetActive(false);
            Bloco11Star2.SetActive(false);
            Bloco11Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco11StarINT == 1)
        {

            Bloco11Star1.SetActive(true);
            Bloco11Star2.SetActive(false);
            Bloco11Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco11StarINT == 2)
        {

            Bloco11Star1.SetActive(true);
            Bloco11Star2.SetActive(true);
            Bloco11Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco11StarINT == 3)
        {

            Bloco11Star1.SetActive(true);
            Bloco11Star2.SetActive(true);
            Bloco11Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco12StarINT == 0)
        {

            Bloco12Star1.SetActive(false);
            Bloco12Star2.SetActive(false);
            Bloco12Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco12StarINT == 1)
        {

            Bloco12Star1.SetActive(true);
            Bloco12Star2.SetActive(false);
            Bloco12Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco12StarINT == 2)
        {

            Bloco12Star1.SetActive(true);
            Bloco12Star2.SetActive(true);
            Bloco12Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco12StarINT == 3)
        {

            Bloco12Star1.SetActive(true);
            Bloco12Star2.SetActive(true);
            Bloco12Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco13StarINT == 0)
        {

            Bloco13Star1.SetActive(false);
            Bloco13Star2.SetActive(false);
            Bloco13Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco13StarINT == 1)
        {

            Bloco13Star1.SetActive(true);
            Bloco13Star2.SetActive(false);
            Bloco13Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco13StarINT == 2)
        {

            Bloco13Star1.SetActive(true);
            Bloco13Star2.SetActive(true);
            Bloco13Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco13StarINT == 3)
        {

            Bloco13Star1.SetActive(true);
            Bloco13Star2.SetActive(true);
            Bloco13Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco14StarINT == 0)
        {

            Bloco14Star1.SetActive(false);
            Bloco14Star2.SetActive(false);
            Bloco14Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco14StarINT == 1)
        {

            Bloco14Star1.SetActive(true);
            Bloco14Star2.SetActive(false);
            Bloco14Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco14StarINT == 2)
        {

            Bloco14Star1.SetActive(true);
            Bloco14Star2.SetActive(true);
            Bloco14Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco14StarINT == 3)
        {

            Bloco14Star1.SetActive(true);
            Bloco14Star2.SetActive(true);
            Bloco14Star3.SetActive(true);

        }
        if (global::SaveRanking.Bloco15StarINT == 0)
        {

            Bloco15Star1.SetActive(false);
            Bloco15Star2.SetActive(false);
            Bloco15Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco15StarINT == 1)
        {

            Bloco15Star1.SetActive(true);
            Bloco15Star2.SetActive(false);
            Bloco15Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco15StarINT == 2)
        {

            Bloco15Star1.SetActive(true);
            Bloco15Star2.SetActive(true);
            Bloco15Star3.SetActive(false);

        }
        if (global::SaveRanking.Bloco15StarINT == 3)
        {

            Bloco15Star1.SetActive(true);
            Bloco15Star2.SetActive(true);
            Bloco15Star3.SetActive(true);

        }

	
	}

}