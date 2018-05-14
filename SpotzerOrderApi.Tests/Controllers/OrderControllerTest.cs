using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotzerOrderApi.Context;
using SpotzerOrderApi.Controllers;
using SpotzerOrderApi.Models;

namespace SpotzerOrderApi.Tests.Controllers
{
    [TestClass]
    public class OrderControllerTest
    {
        [TestMethod]
        public void All()
        {
            // Arrange
            OrderProductController controller = new OrderProductController(new OrderContext());

            Order order = new JavaScriptSerializer().Deserialize<Order>("{\"Partner\":\"sample string 1\",\"OrderID\":\"sample string 7\",\"TypeOfOrder\":\"sample string 8\",\"SubmittedBy\":\"sample string 11\",\"CompanyID\":\"sample string 28\",\"CompanyName\":\"sample string 29\",\"ContactFirstName\":\"ContactFirstName\",\"ContactLastName\":\"ContactLastName\",\"ContactTitle\":\"ContactTitle\",\"ContactPhone\":\"ContactPhone\",\"ContactMobile\":\"ContactMobile\",\"ContactEmail\":\"ContactEmail\",\"ExposureID\":\"ExposureID\",\"UDAC\":\"UDAC\",\"RelatedOrder\":\"RelatedOrder\",\"LineItems\":[{\"ID\":1,\"ProductID\":\"sample string 17\",\"ProductType\":\"sample string 18\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"WebsiteDetails\":{\"TemplateId\":\"sample string 245\",\"WebsiteBusinessName\":\"sample string 245\",\"WebsiteAddressLine1\":\"sample string 246\",\"WebsiteAddressLine2\":\"sample string 247\",\"WebsiteCity\":\"sample string 248\",\"WebsiteState\":\"sample string 249\",\"WebsitePostCode\":\"sample string 250\",\"WebsitePhone\":\"sample string 257\",\"WebsiteEmail\":\"sample string 258\",\"WebsiteMobile\":\"sample string 259\"}},{\"ID\":1,\"ProductID\":\"6789\",\"ProductType\":\"Paid Search\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"AdWordCampaign\":{\"CampaignName\":\"sample string 1\",\"CampaignAddressLine1\":\"sample string 2\",\"CampaignPostCode\":\"sample string 6\",\"CampaignRadius\":\"sample string 13\",\"LeadPhoneNumber\":\"sample string 14\",\"SMSPhoneNumber\":\"sample string 15\",\"UniqueSellingPoint1\":\"sample string 18\",\"UniqueSellingPoint2\":\"sample string 19\",\"UniqueSellingPoint3\":\"sample string 20\",\"Offer\":\"sample string 21\",\"DestinationURL\":\"sample string 23\"}}]}");

            // Act
            IHttpActionResult actionResult = controller.Post(order);
            var contentResult = actionResult as OkNegotiatedContentResult<string>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("Sold the products succesfully", contentResult.Content);
        }

        [TestMethod]
        public void PartnerA()
        {
            // Arrange
            OrderProductController controller = new OrderProductController(new OrderContext());

            Order order = new JavaScriptSerializer().Deserialize<Order>("{\"Partner\":\"sample string 1\",\"OrderID\":\"sample string 7\",\"TypeOfOrder\":\"sample string 8\",\"SubmittedBy\":\"sample string 11\",\"CompanyID\":\"sample string 28\",\"CompanyName\":\"sample string 29\",\"ContactFirstName\":\"ContactFirstName\",\"ContactLastName\":\"ContactLastName\",\"ContactTitle\":\"ContactTitle\",\"ContactPhone\":\"ContactPhone\",\"ContactMobile\":\"ContactMobile\",\"ContactEmail\":\"ContactEmail\",\"LineItems\":[{\"ID\":1,\"ProductID\":\"sample string 17\",\"ProductType\":\"sample string 18\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"WebsiteDetails\":{\"TemplateId\":\"sample string 245\",\"WebsiteBusinessName\":\"sample string 245\",\"WebsiteAddressLine1\":\"sample string 246\",\"WebsiteAddressLine2\":\"sample string 247\",\"WebsiteCity\":\"sample string 248\",\"WebsiteState\":\"sample string 249\",\"WebsitePostCode\":\"sample string 250\",\"WebsitePhone\":\"sample string 257\",\"WebsiteEmail\":\"sample string 258\",\"WebsiteMobile\":\"sample string 259\"}},{\"ID\":1,\"ProductID\":\"6789\",\"ProductType\":\"Paid Search\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"AdWordCampaign\":{\"CampaignName\":\"sample string 1\",\"CampaignAddressLine1\":\"sample string 2\",\"CampaignPostCode\":\"sample string 6\",\"CampaignRadius\":\"sample string 13\",\"LeadPhoneNumber\":\"sample string 14\",\"SMSPhoneNumber\":\"sample string 15\",\"UniqueSellingPoint1\":\"sample string 18\",\"UniqueSellingPoint2\":\"sample string 19\",\"UniqueSellingPoint3\":\"sample string 20\",\"Offer\":\"sample string 21\",\"DestinationURL\":\"sample string 23\"}}]}");

            // Act
            IHttpActionResult actionResult = controller.Post(order);
            var contentResult = actionResult as OkNegotiatedContentResult<string>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("Sold the products succesfully", contentResult.Content);
        }

        [TestMethod]
        public void PartnerB()
        {
            // Arrange
            OrderProductController controller = new OrderProductController(new OrderContext());

            Order order = new JavaScriptSerializer().Deserialize<Order>("{\"Partner\":\"sample string 1\",\"OrderID\":\"sample string 7\",\"TypeOfOrder\":\"sample string 8\",\"SubmittedBy\":\"sample string 11\",\"CompanyID\":\"sample string 28\",\"CompanyName\":\"sample string 29\",\"LineItems\":[{\"ID\":1,\"ProductID\":\"sample string 17\",\"ProductType\":\"sample string 18\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"WebsiteDetails\":{\"TemplateId\":\"sample string 245\",\"WebsiteBusinessName\":\"sample string 245\",\"WebsiteAddressLine1\":\"sample string 246\",\"WebsiteAddressLine2\":\"sample string 247\",\"WebsiteCity\":\"sample string 248\",\"WebsiteState\":\"sample string 249\",\"WebsitePostCode\":\"sample string 250\",\"WebsitePhone\":\"sample string 257\",\"WebsiteEmail\":\"sample string 258\",\"WebsiteMobile\":\"sample string 259\"}},{\"ID\":1,\"ProductID\":\"6789\",\"ProductType\":\"Paid Search\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"AdWordCampaign\":{\"CampaignName\":\"sample string 1\",\"CampaignAddressLine1\":\"sample string 2\",\"CampaignPostCode\":\"sample string 6\",\"CampaignRadius\":\"sample string 13\",\"LeadPhoneNumber\":\"sample string 14\",\"SMSPhoneNumber\":\"sample string 15\",\"UniqueSellingPoint1\":\"sample string 18\",\"UniqueSellingPoint2\":\"sample string 19\",\"UniqueSellingPoint3\":\"sample string 20\",\"Offer\":\"sample string 21\",\"DestinationURL\":\"sample string 23\"}}]}");

            // Act
            IHttpActionResult actionResult = controller.Post(order);
            var contentResult = actionResult as OkNegotiatedContentResult<string>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("Sold the products succesfully", contentResult.Content);
        }

        [TestMethod]
        public void PartnerC()
        {
            // Arrange
            OrderProductController controller = new OrderProductController(new OrderContext());

            Order order = new JavaScriptSerializer().Deserialize<Order>("{\"Partner\":\"sample string 1\",\"OrderID\":\"sample string 7\",\"TypeOfOrder\":\"sample string 8\",\"SubmittedBy\":\"sample string 11\",\"CompanyID\":\"sample string 28\",\"CompanyName\":\"sample string 29\",\"ExposureID\":\"ExposureID\",\"UDAC\":\"UDAC\",\"RelatedOrder\":\"RelatedOrder\",\"LineItems\":[{\"ID\":1,\"ProductID\":\"sample string 17\",\"ProductType\":\"sample string 18\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"WebsiteDetails\":{\"TemplateId\":\"sample string 245\",\"WebsiteBusinessName\":\"sample string 245\",\"WebsiteAddressLine1\":\"sample string 246\",\"WebsiteAddressLine2\":\"sample string 247\",\"WebsiteCity\":\"sample string 248\",\"WebsiteState\":\"sample string 249\",\"WebsitePostCode\":\"sample string 250\",\"WebsitePhone\":\"sample string 257\",\"WebsiteEmail\":\"sample string 258\",\"WebsiteMobile\":\"sample string 259\"}},{\"ID\":1,\"ProductID\":\"6789\",\"ProductType\":\"Paid Search\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"AdWordCampaign\":{\"CampaignName\":\"sample string 1\",\"CampaignAddressLine1\":\"sample string 2\",\"CampaignPostCode\":\"sample string 6\",\"CampaignRadius\":\"sample string 13\",\"LeadPhoneNumber\":\"sample string 14\",\"SMSPhoneNumber\":\"sample string 15\",\"UniqueSellingPoint1\":\"sample string 18\",\"UniqueSellingPoint2\":\"sample string 19\",\"UniqueSellingPoint3\":\"sample string 20\",\"Offer\":\"sample string 21\",\"DestinationURL\":\"sample string 23\"}}]}");

            // Act
            IHttpActionResult actionResult = controller.Post(order);
            var contentResult = actionResult as OkNegotiatedContentResult<string>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("Sold the products succesfully", contentResult.Content);
        }

        [TestMethod]
        public void PartnerD()
        {
            // Arrange
            OrderProductController controller = new OrderProductController(new OrderContext());

            Order order = new JavaScriptSerializer().Deserialize<Order>("{\"Partner\":\"sample string 1\",\"OrderID\":\"sample string 7\",\"TypeOfOrder\":\"sample string 8\",\"SubmittedBy\":\"sample string 11\",\"CompanyID\":\"sample string 28\",\"CompanyName\":\"sample string 29\",\"LineItems\":[{\"ID\":1,\"ProductID\":\"6789\",\"ProductType\":\"Paid Search\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"AdWordCampaign\":{\"CampaignName\":\"sample string 1\",\"CampaignAddressLine1\":\"sample string 2\",\"CampaignPostCode\":\"sample string 6\",\"CampaignRadius\":\"sample string 13\",\"LeadPhoneNumber\":\"sample string 14\",\"SMSPhoneNumber\":\"sample string 15\",\"UniqueSellingPoint1\":\"sample string 18\",\"UniqueSellingPoint2\":\"sample string 19\",\"UniqueSellingPoint3\":\"sample string 20\",\"Offer\":\"sample string 21\",\"DestinationURL\":\"sample string 23\"}}]}");

            // Act
            IHttpActionResult actionResult = controller.Post(order);
            var contentResult = actionResult as OkNegotiatedContentResult<string>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("Sold the products succesfully", contentResult.Content);
        }

        [TestMethod]
        public void RequriedFieldValidation()
        {
            // Arrange
            OrderProductController controller = new OrderProductController(new OrderContext());

            Order order = new JavaScriptSerializer().Deserialize<Order>("{\"Partner\":\"sample string 1\",\"OrderID\":\"sample string 7\",\"SubmittedBy\":\"sample string 11\",\"CompanyID\":\"sample string 28\",\"CompanyName\":\"sample string 29\",\"ContactFirstName\":\"ContactFirstName\",\"ContactLastName\":\"ContactLastName\",\"ContactTitle\":\"ContactTitle\",\"ContactPhone\":\"ContactPhone\",\"ContactMobile\":\"ContactMobile\",\"ContactEmail\":\"ContactEmail\",\"ExposureID\":\"ExposureID\",\"UDAC\":\"UDAC\",\"RelatedOrder\":\"RelatedOrder\",\"LineItems\":[{\"ID\":1,\"ProductID\":\"sample string 17\",\"ProductType\":\"sample string 18\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"WebsiteDetails\":{\"TemplateId\":\"sample string 245\",\"WebsiteBusinessName\":\"sample string 245\",\"WebsiteAddressLine1\":\"sample string 246\",\"WebsiteAddressLine2\":\"sample string 247\",\"WebsiteCity\":\"sample string 248\",\"WebsiteState\":\"sample string 249\",\"WebsitePostCode\":\"sample string 250\",\"WebsitePhone\":\"sample string 257\",\"WebsiteEmail\":\"sample string 258\",\"WebsiteMobile\":\"sample string 259\"}},{\"ID\":1,\"ProductID\":\"6789\",\"ProductType\":\"Paid Search\",\"Notes\":\"sample string 53\",\"Category\":\"sample string 245\",\"AdWordCampaign\":{\"CampaignName\":\"sample string 1\",\"CampaignAddressLine1\":\"sample string 2\",\"CampaignPostCode\":\"sample string 6\",\"CampaignRadius\":\"sample string 13\",\"LeadPhoneNumber\":\"sample string 14\",\"SMSPhoneNumber\":\"sample string 15\",\"UniqueSellingPoint1\":\"sample string 18\",\"UniqueSellingPoint2\":\"sample string 19\",\"UniqueSellingPoint3\":\"sample string 20\",\"Offer\":\"sample string 21\",\"DestinationURL\":\"sample string 23\"}}]}");

            // Act
            IHttpActionResult actionResult = controller.Post(order);
            var contentResult = actionResult as BadRequestErrorMessageResult;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Message);
            Assert.AreEqual("Please provided data in the correct format", contentResult.Message);
        }

    }
}
