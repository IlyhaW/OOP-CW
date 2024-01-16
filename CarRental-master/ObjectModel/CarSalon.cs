using System;
using System.Collections.Generic;


namespace CarRental
{
    public class CarSalon
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Adress { get; set; }
        public string BeginWork { get; set; }
        public string EndWork { get; set; }

        private List<Car> _carsList { get; set; }
        private List<WorkerOfSalon> _workersOfSalon { get; set; }
        private List<Order> _orders { get; set; }

        public CarSalon()
        {
            _carsList = new List<Car>();
            _workersOfSalon = new List<WorkerOfSalon>();
            _orders = new List<Order>();
        }

        public bool AddProduct(Car newCar)
        {
            foreach (Car car in _carsList)
            {
                if (car.CarItem.Name == newCar.CarItem.Name)
                    return false;
            }
            _carsList.Add(newCar);
            return true;
        }

        public bool DeleteProduct(int index)
        {
            foreach (Car car in _carsList)
            {
                if (index == car.CarItem.Id)
                {
                    return _carsList.Remove(car);
                }
            }

            return false;
        }

        public IReadOnlyCollection<Car> GetCars()
        {
            return _carsList.AsReadOnly();
        }

        public IReadOnlyCollection<WorkerOfSalon> GetWorker()
        {
            return _workersOfSalon.AsReadOnly();
        }
        public IReadOnlyCollection<Order> GetOrders()
        {
            return _orders.AsReadOnly();
        }

        public bool AddEmployee(WorkerOfSalon newWorkerOfSalon)
        {
            foreach (WorkerOfSalon workerOfSalon in _workersOfSalon)
            {
                if ((workerOfSalon.Firstname == newWorkerOfSalon.Firstname) && (workerOfSalon.Lastname == newWorkerOfSalon.Lastname))
                    return false;
            }
            _workersOfSalon.Add(newWorkerOfSalon);
            return true;
        }

        public bool DeleteEmployee(string firstname, string lastname)
        {
            foreach (WorkerOfSalon employee in _workersOfSalon)
            {
                if ((employee.Firstname == firstname) && (employee.Lastname == lastname))
                {
                    return _workersOfSalon.Remove(employee);
                }
            }

            return false;
        }
        public bool AddOrder(Order newOrder)
        {
            foreach (Order order in _orders)
            {
                if (order.OrderId == newOrder.OrderId)
                    return false;
            }
            _orders.Add(newOrder);
            return true;
        }
        public bool DeleteOrder(int index)
        {
            foreach (Order order in _orders)
            {
                if (index == order.OrderId)
                {
                    return _orders.Remove(order);
                }
            }
            return false;
        }
    }
}