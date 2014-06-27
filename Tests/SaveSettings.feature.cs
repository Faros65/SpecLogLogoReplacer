﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecLogLogoReplacer.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Save Settings")]
    public partial class SaveSettingsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SaveSettings.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Save Settings", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Saving Settings")]
        public virtual void SavingSettings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Saving Settings", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Path to SpecLog Html File",
                        "Path to Logo"});
            table1.AddRow(new string[] {
                        "c:\\speclog.html",
                        "c:\\logo.png"});
#line 4
  testRunner.Given("I have these settings", ((string)(null)), table1, "Given ");
#line 7
  testRunner.When("I save the settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
  testRunner.Then("the settings file consists of", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<specLogLogoReplacer xmlns:i=\"http://www." +
                    "w3.org/2001/XMLSchema-instance\">\r\n  <pathToSpecLogHtmlFile>c:\\speclog.html</path" +
                    "ToSpecLogHtmlFile>\r\n  <pathToSpecLogo>c:\\logo.png</pathToSpecLogo>\r\n</specLogLog" +
                    "oReplacer>", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Reading Settings")]
        public virtual void ReadingSettings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reading Settings", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 18
  testRunner.Given("the settings file consists of", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<specLogLogoReplacer xmlns:i=\"http://www." +
                    "w3.org/2001/XMLSchema-instance\">\r\n  <pathToSpecLogHtmlFile>c:\\speclog.html</path" +
                    "ToSpecLogHtmlFile>\r\n  <pathToSpecLogo>c:\\logo.png</pathToSpecLogo>\r\n</specLogLog" +
                    "oReplacer>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
  testRunner.When("I load the settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Path to SpecLog Html File",
                        "Path to Logo"});
            table2.AddRow(new string[] {
                        "c:\\speclog.html",
                        "c:\\logo.png"});
#line 27
  testRunner.Then("I should have these settings", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
