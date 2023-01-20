using System;
namespace BlazorFullStackCrud.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty; //Empty string by default 

        public string LastName { get; set; } = string.Empty; //Empty string by default 

        public string HeroName { get; set; } = string.Empty; //Empty string by default 

        //Vi opretter relationer(Fx.Superman hører til DC)

        public Comic? Comic { get; set; } //Har relationer til Comic.cs

        public int ComicId { get; set; }
    }
}

