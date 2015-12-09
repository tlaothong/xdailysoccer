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
    public partial class ConfirmPhoneNumberFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ConfirmPhoneNumber.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ConfirmPhoneNumber", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ConfirmPhoneNumber")))
            {
                DailySoccer.Specs.ConfirmPhoneNumberFeature.FeatureSetup(null);
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
                        "VerifiedPhoneNumber"});
            table1.AddRow(new string[] {
                        "1",
                        "s01",
                        ""});
            table1.AddRow(new string[] {
                        "2",
                        "s02",
                        "+66914185555"});
#line 9
 testRunner.And("ผู้ใช้ในระบบมีดังนี้", ((string)(null)), table1, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลถูกต้อง ระบบทำการบันทึกก" +
            "ารยืนยันเบอร์โทรศัพเสร็จสิ้น")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ConfirmPhoneNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทยงไมเคยยนยนรหสลบขอทำการยนยนรหสลบขอมลถกตองระบบทำการบนทกการยนยนเบอรโทรศพเสรจสน()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลถูกต้อง ระบบทำการบันทึกก" +
                    "ารยืนยันเบอร์โทรศัพเสร็จสิ้น", new string[] {
                        "mock",
                        "mock"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "UserId",
                        "VerificationCode",
                        "PhoneNumber",
                        "CompletedDate"});
            table2.AddRow(new string[] {
                        "1",
                        "s01",
                        "1234567",
                        "+66914185500",
                        ""});
#line 16
 testRunner.Given("ข้อมูลการขอยืนยันเบอร์โทรทั้งหมดในระบบเป็น", ((string)(null)), table2, "Given ");
#line 19
 testRunner.When("ผู้ใช้ UserId: \'s01\' ยืนยันรหัสลับ VerificationCode: \'1234567\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("ระบบทำการบันทึกการยืนยันเบอร์โทรศัพ \'+66914185500\' และ VerificationCode: \'1234567" +
                    "\' ให้กับผู้ใช้ UserId: \'s01\' เสร็จสิ้น", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลไม่ถูกต้อง (รหัสลับไม่ถู" +
            "ก) ระบบไม่ทำการบันทึกข้อมูลและแจ้งเตือนข้อผิดพลาด")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ConfirmPhoneNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทยงไมเคยยนยนรหสลบขอทำการยนยนรหสลบขอมลไมถกตองรหสลบไมถกระบบไมทำการบนทกขอมลและแจงเตอนขอผดพลาด()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลไม่ถูกต้อง (รหัสลับไม่ถู" +
                    "ก) ระบบไม่ทำการบันทึกข้อมูลและแจ้งเตือนข้อผิดพลาด", new string[] {
                        "mock"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "UserId",
                        "VerificationCode",
                        "PhoneNumber",
                        "CompletedDate"});
            table3.AddRow(new string[] {
                        "1",
                        "s01",
                        "1234567",
                        "+66914185500",
                        ""});
#line 24
 testRunner.Given("ข้อมูลการขอยืนยันเบอร์โทรทั้งหมดในระบบเป็น", ((string)(null)), table3, "Given ");
#line 27
 testRunner.When("ผู้ใช้ UserId: \'s01\' ยืนยันรหัสลับ VerificationCode: \'missMatch\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("ระบบไม่ทำการบันทึกข้อมูลและแจ้งเตือนข้อผิดพลาด", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลไม่ถูกต้อง (ไม่มีรายการข" +
            "อยืนยันเบอร์โทร) ระบบไม่ทำการบันทึกข้อมูลและแจ้งเตือนข้อผิดพลาด")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ConfirmPhoneNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทยงไมเคยยนยนรหสลบขอทำการยนยนรหสลบขอมลไมถกตองไมมรายการขอยนยนเบอรโทรระบบไมทำการบนทกขอมลและแจงเตอนขอผดพลาด()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลไม่ถูกต้อง (ไม่มีรายการข" +
                    "อยืนยันเบอร์โทร) ระบบไม่ทำการบันทึกข้อมูลและแจ้งเตือนข้อผิดพลาด", new string[] {
                        "mock"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "UserId",
                        "VerificationCode",
                        "PhoneNumber",
                        "CompletedDate"});
#line 32
 testRunner.Given("ข้อมูลการขอยืนยันเบอร์โทรทั้งหมดในระบบเป็น", ((string)(null)), table4, "Given ");
#line 34
 testRunner.When("ผู้ใช้ UserId: \'s01\' ยืนยันรหัสลับ VerificationCode: \'1234567\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("ระบบไม่ทำการบันทึกข้อมูลและแจ้งเตือนข้อผิดพลาด", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลถูกต้อง (มีรหัสลับที่ยัง" +
            "ไม่ถูกยืนยันหลายรายการ) ระบบทำการบันทึกการยืนยันเบอร์โทรศัพเสร็จสิ้น")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ConfirmPhoneNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทยงไมเคยยนยนรหสลบขอทำการยนยนรหสลบขอมลถกตองมรหสลบทยงไมถกยนยนหลายรายการระบบทำการบนทกการยนยนเบอรโทรศพเสรจสน()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ยังไม่เคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลถูกต้อง (มีรหัสลับที่ยัง" +
                    "ไม่ถูกยืนยันหลายรายการ) ระบบทำการบันทึกการยืนยันเบอร์โทรศัพเสร็จสิ้น", new string[] {
                        "mock"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "UserId",
                        "VerificationCode",
                        "PhoneNumber",
                        "CompletedDate"});
            table5.AddRow(new string[] {
                        "1",
                        "s01",
                        "1234567",
                        "+66914185500",
                        ""});
            table5.AddRow(new string[] {
                        "2",
                        "s01",
                        "0000001",
                        "+7700000001",
                        "1/1/2015"});
            table5.AddRow(new string[] {
                        "3",
                        "s01",
                        "2222222",
                        "+8800000001",
                        ""});
#line 39
 testRunner.Given("ข้อมูลการขอยืนยันเบอร์โทรทั้งหมดในระบบเป็น", ((string)(null)), table5, "Given ");
#line 44
 testRunner.When("ผู้ใช้ UserId: \'s01\' ยืนยันรหัสลับ VerificationCode: \'2222222\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("ระบบทำการบันทึกการยืนยันเบอร์โทรศัพ \'+8800000001\' และ VerificationCode: \'2222222\'" +
                    " ให้กับผู้ใช้ UserId: \'s01\' เสร็จสิ้น", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ผู้ใช้ที่ยังเคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลถูกต้อง ระบบทำการบันทึกการย" +
            "ืนยันเบอร์โทรศัพเสร็จสิ้น")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ConfirmPhoneNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void ผใชทยงเคยยนยนรหสลบขอทำการยนยนรหสลบขอมลถกตองระบบทำการบนทกการยนยนเบอรโทรศพเสรจสน()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ผู้ใช้ที่ยังเคยยืนยันรหัสลับขอทำการยืนยันรหัสลับข้อมูลถูกต้อง ระบบทำการบันทึกการย" +
                    "ืนยันเบอร์โทรศัพเสร็จสิ้น", new string[] {
                        "mock"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "UserId",
                        "VerificationCode",
                        "PhoneNumber",
                        "CompletedDate"});
            table6.AddRow(new string[] {
                        "1",
                        "s02",
                        "1234567",
                        "+66914185500",
                        ""});
#line 49
 testRunner.Given("ข้อมูลการขอยืนยันเบอร์โทรทั้งหมดในระบบเป็น", ((string)(null)), table6, "Given ");
#line 52
 testRunner.When("ผู้ใช้ UserId: \'s02\' ยืนยันรหัสลับ VerificationCode: \'1234567\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("ระบบทำการบันทึกการยืนยันเบอร์โทรศัพ \'+66914185500\' และ VerificationCode: \'1234567" +
                    "\' ให้กับผู้ใช้ UserId: \'s02\' เสร็จสิ้น", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
