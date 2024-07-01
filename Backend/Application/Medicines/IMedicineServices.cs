using Application.AppDTO;
using Domain.DomainDTO;
using Domain.Models;

namespace Application.Medicines
{
    public interface IMedicineServices
    {
        Task<List<MedicineDomainDTO>> GetAllMedicinesAsync();

        Task<MedicineDomainDTO?> GetMedicineByIdAsync(int id);

        Task<Medicine?> CreateMedicineAsync(MedicineReqDTO medicineReqDTO);

        Task<bool> DeleteMedicineAsync(int id);

        Task<bool?> EditMedicineAsync(MedicineReqDTO medicineReqDTO);
    }
}
