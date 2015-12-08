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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetCurrentRewards", "In order to avoid silly mistakes\nAs a math idiot\nI want to be told the sum of two" +
                    " numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
    }
}
#pragma warning restore
#endregion
