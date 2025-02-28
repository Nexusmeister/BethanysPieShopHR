using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Server.Services
{
    public class MockEmployeeDataService : IEmployeeDataService
    {
        private List<Employee?> _employees;
        private List<Country> _countries;
        private List<JobCategory> _jobCategories;

        private IEnumerable<Employee?> Employees
        {
            get
            {
                if (_employees == null)
                    InitializeEmployees();
                return _employees;
            }
        }

        private List<Country> Countries
        {
            get
            {
                if (_countries == null)
                    InitializeCountries();
                return _countries;
            }
        }

        private List<JobCategory> JobCategories
        {
            get
            {
                if (_jobCategories == null)
                    InitializeJobCategories();
                return _jobCategories;
            }
        }

        private void InitializeJobCategories()
        {
            _jobCategories = new List<JobCategory>()
            {
                new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
                new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
                new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
                new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
                new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}

            };
        }

        private void InitializeCountries()
        {
            _countries = new List<Country>
            {
                new Country {CountryId = 1, Name = "Belgium"},
                new Country {CountryId = 2, Name = "Netherlands"},
                new Country {CountryId = 3, Name = "USA"},
                new Country {CountryId = 4, Name = "Japan"},
                new Country {CountryId = 5, Name = "China"},
                new Country {CountryId = 6, Name = "UK"},
                new Country {CountryId = 7, Name = "France"},
                new Country {CountryId = 8, Name = "Brazil"}
            };
        }

        private void InitializeEmployees()
        {
            if (_employees == null)
            {
                var e1 = new Employee
                {
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1989, 3, 11),
                    City = "Brussels",
                    Email = "bethany@bethanyspieshop.com",
                    EmployeeId = 1,
                    FirstName = "Bethany",
                    LastName = "Smith",
                    Gender = Gender.Female,
                    PhoneNumber = "324777888773",
                    Smoker = false,
                    Street = "Grote Markt 1",
                    Zip = "1000",
                    JobCategory = JobCategories[2],
                    JobCategoryId = JobCategories[2].JobCategoryId,
                    Comment = "Lorem Ipsum",
                    ExitDate = null,
                    JoinedDate = new DateTime(2015, 3, 1),
                    Country = Countries[0],
                    CountryId = Countries[0].CountryId
                };

                var e2 = new Employee
                {
                    MaritalStatus = MaritalStatus.Married,
                    BirthDate = new DateTime(1979, 1, 16),
                    City = "Antwerp",
                    Email = "gill@bethanyspieshop.com",
                    EmployeeId = 2,
                    FirstName = "Gill",
                    LastName = "Cleeren",
                    Gender = Gender.Female,
                    PhoneNumber = "33999909923",
                    Smoker = false,
                    Street = "New Street",
                    Zip = "2000",
                    JobCategory = JobCategories[1],
                    JobCategoryId = JobCategories[1].JobCategoryId,
                    Comment = "Lorem Ipsum",
                    ExitDate = null,
                    JoinedDate = new DateTime(2017, 12, 24),
                    Country = Countries[1],
                    CountryId = Countries[1].CountryId
                };

                var e3 = new Employee
                {
                    MaritalStatus = MaritalStatus.Married,
                    BirthDate = new DateTime(1979, 1, 16),
                    City = "Antwerp",
                    Email = "gill@bethanyspieshop.com",
                    EmployeeId = 2,
                    FirstName = "Jane",
                    LastName = string.Empty,
                    Gender = Gender.Female,
                    PhoneNumber = "33999909923",
                    Smoker = false,
                    Street = "New Street",
                    Zip = "2000",
                    JobCategory = JobCategories[1],
                    JobCategoryId = JobCategories[1].JobCategoryId,
                    Comment = "Lorem Ipsum",
                    ExitDate = null,
                    JoinedDate = new DateTime(2017, 12, 24),
                    Country = Countries[1],
                    CountryId = Countries[1].CountryId
                };
                _employees = [e1, e2, e3];
            }
        }

        public async Task<IEnumerable<Employee?>> GetAllEmployees()
        {
            return await Task.Run(() => Employees);
        }

        public async Task<List<Country>> GetAllCountries()
        {
            return await Task.Run(() => Countries);
        }

        public async Task<List<JobCategory>> GetAllJobCategories()
        {
            return await Task.Run(() => JobCategories);
        }

        public Task<Employee?> GetEmployeeDetails(int employeeId)
        {
            Task<Employee?> t = Task.FromResult(Employees.FirstOrDefault(e => e.EmployeeId == employeeId) ?? new Employee());
            return t;
        }

        public Task<Employee> AddEmployee(Employee? employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(Employee? employee)
        {
            throw new NotImplementedException();
        }
    }
}
