﻿
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public  abstract class Examen
{ 
    private int date_debut ;
    private string lieu;
    private int note;

    public Examen(int date_debut) 
    {
        this.date_debut = date_debut;
    
    }

    public void set_lieu( string nouveau_lieu)
    {
        this.lieu = nouveau_lieu;
    }

    public void set_note( int nouveau_note)
    {
        note = nouveau_note;
    }

    public double getmesure_duree( int date_fin)
    {

        return date_debut + date_fin;

    } 

    public void set_date( int nouveau_date)
    {
        date_debut = nouveau_date;
    }


}



public class Question 
{
    private string type;
    


    public Question() { }
    public bool repondre( bool reponder) 
    {
        return reponder;
        
    }


}




public class Reponse
{
    private int degre_certitude;
    private int duree_pour_repondre;

    public Reponse() { }
    public  int get_degre_certitude()
    {
        return degre_certitude;
    }
    public void set_duree_pour_repondre( int nouveau_duree)
    {
        duree_pour_repondre = nouveau_duree;
    }
    
     
}




    


    
}




public class Etudiant
{
    private string Nom;
    private string Prenom;
    private double note;

    public Etudiant(string Nom, string Prenom, double note)
    {
        this.Nom = Nom;
        this.Prenom = Prenom;
        this.note=note;
    }

    
     
}
  





