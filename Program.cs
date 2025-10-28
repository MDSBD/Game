// See https://aka.ms/new-console-template for more information
using Game;

IHM h=new IHM();
while (true)
{
    h.Menu2();
    h.start();

   string c= h.Choix;
    if(c == "5") break;
}