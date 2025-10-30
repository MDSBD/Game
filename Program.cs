using Game;

IHM h=new IHM();
  h.Menu2();
while (true)
{
  
    h.start();
    if (h.Isconnected)
    {
        if (h.Ut.Role == "admin")
        {
            h.Menu();
        }
        else
        { 
            h.Choix= "6";
        }
          
    }

    string c= h.Choix;
    if(c == "5") break;
}