using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Client : Account
{
    public bool magChatten {get; set;}

    [ForeignKey("ApplicatieGebruiker")]
    public virtual ApplicatieGebruiker User {get; set;}     //ef core link naar applicatiegebruiker class van identiy
}

