using System;
using System.Collections.Generic;

class Fordon{
   private string tillverkare; 
   private string modell;
   private  int år;

     public Fordon(string tv, string md, int å){
        tillverkare = tv;
        modell = md;
        år = å;
     }

     public string GetTillverkare(){
        return tillverkare;
     }

     public string GetModell(){
        return modell;
     }

     public int  GetÅr(){
        return år;
     }
}