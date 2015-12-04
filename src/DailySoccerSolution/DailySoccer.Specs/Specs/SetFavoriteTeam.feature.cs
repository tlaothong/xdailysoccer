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
    public partial class SetFavoriteTeamFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SetFavoriteTeam.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SetFavoriteTeam", "In order to avoid silly mistakes\nAs a math idiot\nI want to be told the sum of two" +
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "SetFavoriteTeam")))
            {
                DailySoccer.Specs.SetFavoriteTeamFeature.FeatureSetup(null);
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
                        "TeamId",
                        "TeamName",
                        "LeagueName"});
            table1.AddRow(new string[] {
                        "TeamId",
                        "TeamName",
                        "LeagueName"});
            table1.AddRow(new string[] {
                        "1",
                        "AS Roma",
                        "EUFA Champions League"});
            table1.AddRow(new string[] {
                        "2",
                        "Bayer Leverkusen",
                        "EUFA Champions League"});
#line 9
 testRunner.And("ข้อมูลทีมทั้งหมดในระบบมีเป็น", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "SecrectCode",
                        "Points",
                        "MaximumGuessAmount",
                        "CurrentOrderedCoupon"});
            table2.AddRow(new string[] {
                        "1",
                        "s01",
                        "0",
                        "5",
                        "0"});
#line 14
 testRunner.And("ผู้ใช้ในระบบมีดังนี้", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้เลือกทีมที่ชอบ ระบบทำการบันทึกข้อมูลทีมที่ชอบ")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SetFavoriteTeam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชเลอกทมทชอบระบบทำการบนทกขอมลทมทชอบ()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้เลือกทีมที่ชอบ ระบบทำการบันทึกข้อมูลทีมที่ชอบ", new string[] {
                        "mock",
                        "mock"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 20
 testRunner.When("ผู้ใช้ UserId: \'s01\' เลือกทีมที่ชอบเป็น SelectedTeamId: \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("ระบบทำการบันทึกข้อมูลทีมที่ชอบ ผู้ใช้ UserId: \'s01\' เลือกทีมที่ชอบเป็น SelectedTe" +
                    "amId: \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ไม่เลือกทีมที่ชอบ ระบบไม่ทำการบันทึกข้อมูล")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SetFavoriteTeam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชไมเลอกทมทชอบระบบไมทำการบนทกขอมล()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ไม่เลือกทีมที่ชอบ ระบบไม่ทำการบันทึกข้อมูล", new string[] {
                        "mock"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 25
 testRunner.When("ผู้ใช้ UserId: \'s01\' เลือกทีมที่ชอบเป็น SelectedTeamId: \'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("ระบบไม่ทำการบันทึกข้อมูลทีมที่ชอบ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้เลือกทีมที่ชอบที่ไม่มีในระบบ ระบบไม่ทำการบันทึกข้อมูล")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SetFavoriteTeam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชเลอกทมทชอบทไมมในระบบระบบไมทำการบนทกขอมล()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้เลือกทีมที่ชอบที่ไม่มีในระบบ ระบบไม่ทำการบันทึกข้อมูล", new string[] {
                        "mock"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 30
 testRunner.When("ผู้ใช้ UserId: \'s01\' เลือกทีมที่ชอบเป็น SelectedTeamId: \'99\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("ระบบไม่ทำการบันทึกข้อมูลทีมที่ชอบ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ข้อมูลไม่ถูกต้องทำการเลือกทีมที่ชอบ ระบบไม่ทำการบันทึกข้อมูล")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SetFavoriteTeam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทขอมลไมถกตองทำการเลอกทมทชอบระบบไมทำการบนทกขอมล()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ข้อมูลไม่ถูกต้องทำการเลือกทีมที่ชอบ ระบบไม่ทำการบันทึกข้อมูล", new string[] {
                        "mock"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 35
 testRunner.When("ผู้ใช้ UserId: \'s02\' เลือกทีมที่ชอบเป็น SelectedTeamId: \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("ระบบไม่ทำการบันทึกข้อมูลทีมที่ชอบ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion