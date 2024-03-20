using System;
namespace cet322_assignment3
{
	public interface IDataAccess
	{
		List<brand> GetBrands();
		brand GetBrandById(int id);
		void CreateBrand(brand brand);
		void UpdateBrand(int id, brand brand);
		void DeleteBrand(int id);

		List<vehicle> GetVehicles();
		vehicle GetVehicleById(int id);
		void CreateVehicle(vehicle vehicle);
		void UpdateVehicle(int id, vehicle vehicle);
		void DeleteVehicle(int id);
	}
	}


