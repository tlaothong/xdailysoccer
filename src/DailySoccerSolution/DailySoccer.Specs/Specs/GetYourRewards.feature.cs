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
    public partial class GetYourRewardsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetYourRewards.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetYourRewards", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "GetYourRewards")))
            {
                DailySoccer.Specs.GetYourRewardsFeature.FeatureSetup(null);
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
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "SecretCode",
                        "Points",
                        "MaximumGuessAmount",
                        "CurrentOrderedCoupon"});
            table1.AddRow(new string[] {
                        "1",
                        "s01",
                        "0",
                        "5",
                        "0"});
            table1.AddRow(new string[] {
                        "2",
                        "s02",
                        "0",
                        "5",
                        "0"});
#line 9
 testRunner.And("ผู้ใช้ในระบบมีดังนี้", ((string)(null)), table1, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ขอข้อมูลของรางวัลที่เคยได้ ในตอนที่ยังไม่เคยมีข้อมูลของรางวัล ระบบส่งรายการ" +
            "ของรางวัลที่เคยได้เปล่ากลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetYourRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชขอขอมลของรางวลทเคยไดในตอนทยงไมเคยมขอมลของรางวลระบบสงรายการของรางวลทเคยไดเปลากลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ขอข้อมูลของรางวัลที่เคยได้ ในตอนที่ยังไม่เคยมีข้อมูลของรางวัล ระบบส่งรายการ" +
                    "ของรางวัลที่เคยได้เปล่ากลับไป", new string[] {
                        "mock",
                        "mock"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
#line 16
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table2, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
#line 18
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "AccountSecrectCode",
                        "RewardId",
                        "ReferenceCode"});
#line 20
 testRunner.And("รายชื่อผู้โชคดีทั้งหมดในระบบเป็นดังนี้", ((string)(null)), table4, "And ");
#line 22
 testRunner.When("ผู้ใช้ UserId: \'s01\' ขอข้อมูลของรางวัลที่เคยได้", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 23
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ปัจจุบันกลับมาเป็น", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 25
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ที่ผ่านมากลับมาเป็น", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ไม่เคยได้รับของรางวัล ขอข้อมูลของรางวัลที่เคยได้ ระบบส่งรายการของรางวัลท" +
            "ี่เคยได้เปล่ากลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetYourRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทไมเคยไดรบของรางวลขอขอมลของรางวลทเคยไดระบบสงรายการของรางวลทเคยไดเปลากลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ไม่เคยได้รับของรางวัล ขอข้อมูลของรางวัลที่เคยได้ ระบบส่งรายการของรางวัลท" +
                    "ี่เคยได้เปล่ากลับไป", new string[] {
                        "mock"});
#line 29
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
#line 30
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
#line 33
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "AccountSecrectCode",
                        "RewardId",
                        "ReferenceCode"});
#line 38
 testRunner.And("รายชื่อผู้โชคดีทั้งหมดในระบบเป็นดังนี้", ((string)(null)), table9, "And ");
#line 40
 testRunner.When("ผู้ใช้ UserId: \'s01\' ขอข้อมูลของรางวัลที่เคยได้", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 41
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ปัจจุบันกลับมาเป็น", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 43
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ที่ผ่านมากลับมาเป็น", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ไม่เคยได้รับของรางวัล (มีผู้ใช้อื่นเคยได้รับรางวัล) ขอข้อมูลของรางวัลที่" +
            "เคยได้ ระบบส่งรายการของรางวัลที่เคยได้เปล่ากลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetYourRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทไมเคยไดรบของรางวลมผใชอนเคยไดรบรางวลขอขอมลของรางวลทเคยไดระบบสงรายการของรางวลทเคยไดเปลากลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ไม่เคยได้รับของรางวัล (มีผู้ใช้อื่นเคยได้รับรางวัล) ขอข้อมูลของรางวัลที่" +
                    "เคยได้ ระบบส่งรายการของรางวัลที่เคยได้เปล่ากลับไป", new string[] {
                        "mock"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table12.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
#line 48
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table13.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table13.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table13.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
#line 51
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "AccountSecrectCode",
                        "RewardId",
                        "ReferenceCode"});
            table14.AddRow(new string[] {
                        "1",
                        "s02",
                        "1",
                        "r01"});
#line 56
 testRunner.And("รายชื่อผู้โชคดีทั้งหมดในระบบเป็นดังนี้", ((string)(null)), table14, "And ");
#line 59
 testRunner.When("ผู้ใช้ UserId: \'s01\' ขอข้อมูลของรางวัลที่เคยได้", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 60
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ปัจจุบันกลับมาเป็น", ((string)(null)), table15, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 62
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ที่ผ่านมากลับมาเป็น", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้มีของรางวัลที่เคยได้ชิ้นเดียว ขอข้อมูลของรางวัลที่เคยได้ ระบบส่งรายการของรา" +
            "งวัลที่เคยได้ทั้งหมดกลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetYourRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชมของรางวลทเคยไดชนเดยวขอขอมลของรางวลทเคยไดระบบสงรายการของรางวลทเคยไดทงหมดกลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้มีของรางวัลที่เคยได้ชิ้นเดียว ขอข้อมูลของรางวัลที่เคยได้ ระบบส่งรายการของรา" +
                    "งวัลที่เคยได้ทั้งหมดกลับไป", new string[] {
                        "mock"});
#line 66
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table17.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
#line 67
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table17, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table18.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table18.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table18.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
#line 70
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table18, "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "AccountSecrectCode",
                        "RewardId",
                        "ReferenceCode"});
            table19.AddRow(new string[] {
                        "1",
                        "s01",
                        "1",
                        "r01"});
#line 75
 testRunner.And("รายชื่อผู้โชคดีทั้งหมดในระบบเป็นดังนี้", ((string)(null)), table19, "And ");
#line 78
 testRunner.When("ผู้ใช้ UserId: \'s01\' ขอข้อมูลของรางวัลที่เคยได้", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
            table20.AddRow(new string[] {
                        "1",
                        "r01",
                        "iPhone 6S description",
                        "iphone6S.jpg",
                        "1/1/2015 00:00"});
#line 79
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ปัจจุบันกลับมาเป็น", ((string)(null)), table20, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 82
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ที่ผ่านมากลับมาเป็น", ((string)(null)), table21, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้มีของรางวัลที่เคยได้หลายชิ้น (ของรางวัลเดือนเดียวกันทั้งหมด) ขอข้อมูลของราง" +
            "วัลที่เคยได้ ระบบส่งรายการของรางวัลที่เคยได้ทั้งหมดกลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetYourRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชมของรางวลทเคยไดหลายชนของรางวลเดอนเดยวกนทงหมดขอขอมลของรางวลทเคยไดระบบสงรายการของรางวลทเคยไดทงหมดกลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้มีของรางวัลที่เคยได้หลายชิ้น (ของรางวัลเดือนเดียวกันทั้งหมด) ขอข้อมูลของราง" +
                    "วัลที่เคยได้ ระบบส่งรายการของรางวัลที่เคยได้ทั้งหมดกลับไป", new string[] {
                        "mock"});
#line 86
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table22.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
#line 87
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table22, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table23.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table23.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table23.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
#line 90
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table23, "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "AccountSecrectCode",
                        "RewardId",
                        "ReferenceCode"});
            table24.AddRow(new string[] {
                        "1",
                        "s01",
                        "1",
                        "r01"});
            table24.AddRow(new string[] {
                        "2",
                        "s01",
                        "1",
                        "r02"});
            table24.AddRow(new string[] {
                        "3",
                        "s01",
                        "2",
                        "r03"});
            table24.AddRow(new string[] {
                        "4",
                        "s01",
                        "3",
                        "r04"});
#line 95
 testRunner.And("รายชื่อผู้โชคดีทั้งหมดในระบบเป็นดังนี้", ((string)(null)), table24, "And ");
#line 101
 testRunner.When("ผู้ใช้ UserId: \'s01\' ขอข้อมูลของรางวัลที่เคยได้", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
            table25.AddRow(new string[] {
                        "1",
                        "r01",
                        "iPhone 6S description",
                        "iphone6S.jpg",
                        "1/1/2015 00:00"});
            table25.AddRow(new string[] {
                        "2",
                        "r02",
                        "iPhone 6S description",
                        "iphone6S.jpg",
                        "1/1/2015 00:00"});
            table25.AddRow(new string[] {
                        "3",
                        "r03",
                        "iPhone 6 description",
                        "iphone6.jpg",
                        "1/1/2015 00:00"});
            table25.AddRow(new string[] {
                        "4",
                        "r04",
                        "iPhone 5S description",
                        "iphone5S.jpg",
                        "1/1/2015 00:00"});
#line 102
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ปัจจุบันกลับมาเป็น", ((string)(null)), table25, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 108
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ที่ผ่านมากลับมาเป็น", ((string)(null)), table26, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้มีของรางวัลที่เคยได้หลายชิ้น (ของรางวัลที่ผ่านมาแล้วทั้งหมด) ขอข้อมูลของราง" +
            "วัลที่เคยได้ ระบบส่งรายการของรางวัลที่เคยได้ทั้งหมดกลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetYourRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชมของรางวลทเคยไดหลายชนของรางวลทผานมาแลวทงหมดขอขอมลของรางวลทเคยไดระบบสงรายการของรางวลทเคยไดทงหมดกลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้มีของรางวัลที่เคยได้หลายชิ้น (ของรางวัลที่ผ่านมาแล้วทั้งหมด) ขอข้อมูลของราง" +
                    "วัลที่เคยได้ ระบบส่งรายการของรางวัลที่เคยได้ทั้งหมดกลับไป", new string[] {
                        "mock"});
#line 112
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table27.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
            table27.AddRow(new string[] {
                        "2",
                        "200",
                        "2/1/2015 00:00"});
#line 113
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table27, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table28.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table28.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table28.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
            table28.AddRow(new string[] {
                        "4",
                        "2",
                        "XBox 365",
                        "XBox 365 description",
                        "100",
                        "110",
                        "xbox365.jpg"});
            table28.AddRow(new string[] {
                        "5",
                        "2",
                        "XBoxOne",
                        "XBoxOne description",
                        "200",
                        "120",
                        "xboxone.jpg"});
#line 117
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table28, "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "AccountSecrectCode",
                        "RewardId",
                        "ReferenceCode"});
            table29.AddRow(new string[] {
                        "1",
                        "s01",
                        "1",
                        "r01"});
            table29.AddRow(new string[] {
                        "2",
                        "s01",
                        "1",
                        "r02"});
            table29.AddRow(new string[] {
                        "3",
                        "s01",
                        "2",
                        "r03"});
            table29.AddRow(new string[] {
                        "4",
                        "s01",
                        "3",
                        "r04"});
#line 124
 testRunner.And("รายชื่อผู้โชคดีทั้งหมดในระบบเป็นดังนี้", ((string)(null)), table29, "And ");
#line 130
 testRunner.When("ผู้ใช้ UserId: \'s01\' ขอข้อมูลของรางวัลที่เคยได้", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
#line 131
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ปัจจุบันกลับมาเป็น", ((string)(null)), table30, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
            table31.AddRow(new string[] {
                        "1",
                        "r01",
                        "iPhone 6S description",
                        "iphone6S.jpg",
                        "1/1/2015 00:00"});
            table31.AddRow(new string[] {
                        "2",
                        "r02",
                        "iPhone 6S description",
                        "iphone6S.jpg",
                        "1/1/2015 00:00"});
            table31.AddRow(new string[] {
                        "3",
                        "r03",
                        "iPhone 6 description",
                        "iphone6.jpg",
                        "1/1/2015 00:00"});
            table31.AddRow(new string[] {
                        "4",
                        "r04",
                        "iPhone 5S description",
                        "iphone5S.jpg",
                        "1/1/2015 00:00"});
#line 133
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ที่ผ่านมากลับมาเป็น", ((string)(null)), table31, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้มีของรางวัลที่เคยได้หลายชิ้น (ของรางวัลเดือนปัจจุบันและผ่านมาแล้ว) ขอข้อมูล" +
            "ของรางวัลที่เคยได้ ระบบส่งรายการของรางวัลที่เคยได้ทั้งหมดกลับไป")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetYourRewards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชมของรางวลทเคยไดหลายชนของรางวลเดอนปจจบนและผานมาแลวขอขอมลของรางวลทเคยไดระบบสงรายการของรางวลทเคยไดทงหมดกลบไป()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้มีของรางวัลที่เคยได้หลายชิ้น (ของรางวัลเดือนปัจจุบันและผ่านมาแล้ว) ขอข้อมูล" +
                    "ของรางวัลที่เคยได้ ระบบส่งรายการของรางวัลที่เคยได้ทั้งหมดกลับไป", new string[] {
                        "mock"});
#line 141
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RequestPoints",
                        "ExpiredDate"});
            table32.AddRow(new string[] {
                        "1",
                        "100",
                        "1/1/2015 00:00"});
            table32.AddRow(new string[] {
                        "2",
                        "200",
                        "2/1/2015 00:00"});
#line 142
 testRunner.Given("กลุ่มของรางวัลทั้งหมดในระบบมีดังนี้", ((string)(null)), table32, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RewardGroupId",
                        "Name",
                        "Description",
                        "Amount",
                        "RemainingAmount",
                        "ImagePath"});
            table33.AddRow(new string[] {
                        "1",
                        "1",
                        "iPhone 6S",
                        "iPhone 6S description",
                        "5",
                        "5",
                        "iphone6S.jpg"});
            table33.AddRow(new string[] {
                        "2",
                        "1",
                        "iPhone 6",
                        "iPhone 6 description",
                        "10",
                        "10",
                        "iphone6.jpg"});
            table33.AddRow(new string[] {
                        "3",
                        "1",
                        "iPhone 5S",
                        "iPhone 5S description",
                        "15",
                        "15",
                        "iphone5S.jpg"});
            table33.AddRow(new string[] {
                        "4",
                        "2",
                        "XBox 365",
                        "XBox 365 description",
                        "100",
                        "110",
                        "xbox365.jpg"});
            table33.AddRow(new string[] {
                        "5",
                        "2",
                        "XBoxOne",
                        "XBoxOne description",
                        "200",
                        "120",
                        "xboxone.jpg"});
#line 146
 testRunner.And("ของรางวัลในแต่ละกลุ่มเป็นดังนี้", ((string)(null)), table33, "And ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "AccountSecrectCode",
                        "RewardId",
                        "ReferenceCode"});
            table34.AddRow(new string[] {
                        "1",
                        "s01",
                        "1",
                        "r01"});
            table34.AddRow(new string[] {
                        "2",
                        "s01",
                        "1",
                        "r02"});
            table34.AddRow(new string[] {
                        "3",
                        "s01",
                        "2",
                        "r03"});
            table34.AddRow(new string[] {
                        "4",
                        "s01",
                        "3",
                        "r04"});
            table34.AddRow(new string[] {
                        "5",
                        "s01",
                        "5",
                        "r05"});
#line 153
 testRunner.And("รายชื่อผู้โชคดีทั้งหมดในระบบเป็นดังนี้", ((string)(null)), table34, "And ");
#line 160
 testRunner.When("ผู้ใช้ UserId: \'s01\' ขอข้อมูลของรางวัลที่เคยได้", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
            table35.AddRow(new string[] {
                        "1",
                        "r05",
                        "XBoxOne description",
                        "xboxone.jpg",
                        "2/1/2015 00:00"});
#line 161
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ปัจจุบันกลับมาเป็น", ((string)(null)), table35, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ordering",
                        "ReferenceCode",
                        "Description",
                        "ImagePath",
                        "ExpiredDate"});
            table36.AddRow(new string[] {
                        "1",
                        "r01",
                        "iPhone 6S description",
                        "iphone6S.jpg",
                        "1/1/2015 00:00"});
            table36.AddRow(new string[] {
                        "2",
                        "r02",
                        "iPhone 6S description",
                        "iphone6S.jpg",
                        "1/1/2015 00:00"});
            table36.AddRow(new string[] {
                        "3",
                        "r03",
                        "iPhone 6 description",
                        "iphone6.jpg",
                        "1/1/2015 00:00"});
            table36.AddRow(new string[] {
                        "4",
                        "r04",
                        "iPhone 5S description",
                        "iphone5S.jpg",
                        "1/1/2015 00:00"});
#line 164
 testRunner.Then("ระบบส่งรายการของรางวัลที่เคยได้ที่ผ่านมากลับมาเป็น", ((string)(null)), table36, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
