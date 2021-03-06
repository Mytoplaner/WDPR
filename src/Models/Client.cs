using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Client : Account
{
    public bool magChatten {get; set;}

    [ForeignKey("ApplicatieGebruiker")]
    public virtual ApplicatieGebruiker User {get; set;}     //ef core link naar applicatiegebruiker class van identiy
    public bool Voogd {get; set;}
    public string Leeftijdscategorie {get; set;}

    public List<GroepsChat> groepChats {get; set;}
    public Hulpverlener hulpverlener {get; set;}
    public int hulpverlenerId {get; set;}
}

