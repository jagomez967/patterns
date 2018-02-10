using Entities;
using Implementations.Collections;
using Implementations.StatusAuction;
using Implementations.Strategies.Update.Auction;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Implementations.Tests
{
    public class ProvidersTest : CollectionBaseTests
    {

        private Provider _provider1 = new Provider { Status = ProviderStatusEnum.Invited };
        private Provider _provider2 = new Provider { Status = ProviderStatusEnum.Active };
        private Provider _provider3 = new Provider { Status = ProviderStatusEnum.Invited };
        private List<Provider> _originalListOfProviders;
        private Providers _sut;

        public ProvidersTest()
        {
            _originalListOfProviders = new List<Provider> { _provider1, _provider2, _provider3 };
            _sut = new Providers(_originalListOfProviders);

        }



        [Fact]
        public void Return_Only_Auction_Already_To_Open()
        {

            Assert.Equal(2, _sut.Invited().Get().Count());

        }






    }
}
