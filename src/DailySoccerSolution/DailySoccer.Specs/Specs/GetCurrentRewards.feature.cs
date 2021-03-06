﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DailySoccer.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class GetCurrentRewardsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetCurrentRewards.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetCurrentRewards", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
                    "wo numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "GetCurrentRewards")))
            {
                DailySoccer.Specs.GetCurrentRewardsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
 testRunner.Given("Setup mocking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ขอข้อมูลของรางวัลในตอนที่ไม่มีกลุ่มของรางวัลในระบบ ระบบส่งรายการของรางวัลเปล่ากลั" +
            "บไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetCurrentRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ขอขอมลของรางวลในตอนทไมมกลมของรางวลในระบบระบบสงรายการของรางวลเปลากลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ขอข้อมูลของรางวัลในตอนที่ไม่มีกลุ่มของรางวัลในระบบ ระบบส่งรายการของรางวัลเปล่ากลั" +
                    "บไป", new string[] {
                        "mock",
                        "mock"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
#line 12
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
#line 14
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table2, "And ");
#line 16
 testRunner.When("ขอข้อมูลของรางวัลในรอบล่าสุด", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
#line 17
 testRunner.Then("ระบบส่งรายการของรางวัลกลับไปเป็น", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดยังไม่มีรายการของรางวัล ระบบส่ง" +
            "รายการของรางวัลเปล่ากลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetCurrentRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ขอขอมลของรางวลในตอนทกลมของรางวลเดอนลาสดยงไมมรายการของรางวลระบบสงรายการของรางวลเปลากลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดยังไม่มีรายการของรางวัล ระบบส่ง" +
                    "รายการของรางวัลเปล่ากลับไป", new string[] {
                        "mock"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table4.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
#line 22
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
#line 25
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table5, "And ");
#line 27
 testRunner.When("ขอข้อมูลของรางวัลในรอบล่าสุด", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
#line 28
 testRunner.Then("ระบบส่งรายการของรางวัลกลับไปเป็น", ((string)(null)), table6, "Then ");
#line 30
 testRunner.And("ราคา Ticket ของเดือนนี้คือ \'100\' Points", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดมีรายการของรางวัลครบ ระบบส่งราย" +
            "การของรางวัลเดือนล่าสุดกลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetCurrentRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ขอขอมลของรางวลในตอนทกลมของรางวลเดอนลาสดมรายการของรางวลครบระบบสงรายการของรางวลเดอนลาสดกลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดมีรายการของรางวัลครบ ระบบส่งราย" +
                    "การของรางวัลเดือนล่าสุดกลับไป", new string[] {
                        "mock"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table7.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
#line 34
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table8.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table8.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table8.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
#line 37
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table8, "And ");
#line 42
 testRunner.When("ขอข้อมูลของรางวัลในรอบล่าสุด", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table9.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table9.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table9.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
#line 43
 testRunner.Then("ระบบส่งรายการของรางวัลกลับไปเป็น", ((string)(null)), table9, "Then ");
#line 48
 testRunner.And("ราคา Ticket ของเดือนนี้คือ \'100\' Points", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดยังไม่มีรายการของรางวัล แต่ข้อม" +
            "ูลกลุ่มเดือนก่อนหน้ามีข้อมูลครบ ระบบส่งรายการของรางวัลเปล่ากลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetCurrentRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ขอขอมลของรางวลในตอนทกลมของรางวลเดอนลาสดยงไมมรายการของรางวลแตขอมลกลมเดอนกอนหนามขอมลครบระบบสงรายการของรางวลเปลากลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดยังไม่มีรายการของรางวัล แต่ข้อม" +
                    "ูลกลุ่มเดือนก่อนหน้ามีข้อมูลครบ ระบบส่งรายการของรางวัลเปล่ากลับไป", new string[] {
                        "mock"});
#line 51
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table10.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
            table10.AddRow(new string[] {
                        "2",
                        "200",
                        "2/1/2015 00:00"});
#line 52
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table11.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table11.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table11.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
#line 56
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table11, "And ");
#line 61
 testRunner.When("ขอข้อมูลของรางวัลในรอบล่าสุด", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
#line 62
 testRunner.Then("ระบบส่งรายการของรางวัลกลับไปเป็น", ((string)(null)), table12, "Then ");
#line 64
 testRunner.And("ราคา Ticket ของเดือนนี้คือ \'200\' Points", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดและเดือนก่อนหน้ามีข้อมูลครับ แต" +
            "่ข้อมูลกลุ่มเดือนก่อนหน้ามีข้อมูลครบ ระบบส่งรายการของรางวัลเดือนล่าสุดกลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetCurrentRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ขอขอมลของรางวลในตอนทกลมของรางวลเดอนลาสดและเดอนกอนหนามขอมลครบแตขอมลกลมเดอนกอนหนามขอมลครบระบบสงรายการของรางวลเดอนลาสดกลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ขอข้อมูลของรางวัลในตอนที่กลุ่มของรางวัลเดือนล่าสุดและเดือนก่อนหน้ามีข้อมูลครับ แต" +
                    "่ข้อมูลกลุ่มเดือนก่อนหน้ามีข้อมูลครบ ระบบส่งรายการของรางวัลเดือนล่าสุดกลับไป", new string[] {
                        "mock"});
#line 67
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table13.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
            table13.AddRow(new string[] {
                        "2",
                        "200",
                        "2/1/2015 00:00"});
#line 68
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table14.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table14.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table14.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
            table14.AddRow(new string[] {
                        "4",
                        "2",
                        "XBox 365",
                        "XBox 365 description",
                        "100",
                        "110",
                        "xbox365.jpg"});
            table14.AddRow(new string[] {
                        "5",
                        "2",
                        "XBoxOne",
                        "XBoxOne description",
                        "200",
                        "120",
                        "xboxone.jpg"});
#line 72
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table14, "And ");
#line 79
 testRunner.When("ขอข้อมูลของรางวัลในรอบล่าสุด", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table15.AddRow(new string[] {
                        "4",
                        "2",
                        "XBox 365",
                        "XBox 365 description",
                        "100",
                        "110",
                        "xbox365.jpg"});
            table15.AddRow(new string[] {
                        "5",
                        "2",
                        "XBoxOne",
                        "XBoxOne description",
                        "200",
                        "120",
                        "xboxone.jpg"});
#line 80
 testRunner.Then("ระบบส่งรายการของรางวัลกลับไปเป็น", ((string)(null)), table15, "Then ");
#line 84
 testRunner.And("ราคา Ticket ของเดือนนี้คือ \'200\' Points", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
