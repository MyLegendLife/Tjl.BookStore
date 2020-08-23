﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Tjl.BookStore.Pages
{
    public class Index_Tests : BookStoreWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
