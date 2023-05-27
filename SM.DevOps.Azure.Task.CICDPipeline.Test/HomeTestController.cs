using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SM.DevOps.Azure.Task.CICDPipeline.Pages;
using System;

namespace SM.DevOps.Azure.Task.CICDPipeline.Test
{
    public class HomeTestController
    {

        [Fact]
        public void Test_Index_View_Result()
        {
            var pageModel = new IndexModel();
            pageModel.OnGet();
        }
    }
}