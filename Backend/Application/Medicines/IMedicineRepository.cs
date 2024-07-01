using Domain.Models;
using Domain.DomainDTO;
using Application.AppDTO;

namespace Application.Medicines
{
    public interface IMedicineRepository
    {
        Task<List<MedicineDomainDTO>> GetAllMedicinesAsync();
        Task<MedicineDomainDTO?> GetMedicineAsync(int id);
        Task<Medicine?> CreateMedicineAsync(MedicineReqDTO medicine);
        Task<bool> DeleteMedicineAsync(int id);
        Task<bool?> EditMedicineAsync(MedicineReqDTO medicineReqDTO);
    }
}
