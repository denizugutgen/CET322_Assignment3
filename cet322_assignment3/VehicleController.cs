using System;
using System.Collections.Generic;
namespace cet322_assignment3
{
	public class VehicleController
	{
		private readonly IDataAccess _dataAccess;

		public VehicleController(IDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public List<vehicle> GetVehicles()
		{
			return _dataAccess.GetVehicles();
		}
		public vehicle GetVehicle(int id)
		{
			return _dataAccess.GetVehicleById(id);
		}
		public void CreateVehicle(vehicle vehicle)
		{
			_dataAccess.CreateVehicle(vehicle);
		}
		public void UpdateVehicle(int id, vehicle vehicle)
		{
			_dataAccess.UpdateVehicle(id, vehicle);
		}
		public void DeleteVehicle(int id)
		{
			_dataAccess.DeleteVehicle(id);
		}
	}
}

