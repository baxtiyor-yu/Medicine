
using Domain.Models;

namespace Domain.DomainDTO
{
    public class MedicinesWithSubstances
    {
        public int Id { get; set; }
        public string? TradeName { get; set; }
        public string? InterName { get; set; }
        public string? ImageUrl { get; set; }
        public Manufacturer? Manufacturer {  get; set; }
        public string? Medform { get; set; }
        public List<Substance> SubstancesOfMedication { get; set; } = [];
        public List<Dose> Doses { get; set; } = [];
    }
}
