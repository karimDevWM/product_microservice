﻿using productMicroservice.Data;
using productMicroservice.IoC.IoCTest;

namespace productMicroservice.Tests.Common
{
    public class TestBase
    {
        protected ServiceProvider _serviceProvider;

        protected DbContextClass _dbContextClass;

        private void InitTestDatabase()
        {
            _dbContextClass = _serviceProvider.GetService<DbContextClass>();
            _dbContextClass?.Database.EnsureDeleted();
            _dbContextClass?.Database.EnsureCreated();
        }

        public void SetupTest()
        {
            _serviceProvider = new ServiceCollection()
                .AddLogging()
                .ConfigureDBContextTest()
                .ConfigureInjectionDependencyRepositoryTest()
                .BuildServiceProvider();

            InitTestDatabase();
        }

        public void CleanTest()
        {
            _dbContextClass?.Database.EnsureCreated();
            _serviceProvider!.Dispose();
            _dbContextClass?.Dispose();
        }
    }
}
