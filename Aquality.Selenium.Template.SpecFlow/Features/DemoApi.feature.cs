﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Aquality.Selenium.Template.SpecFlow.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Demo API")]
    [NUnit.Framework.CategoryAttribute("API")]
    [NUnit.Framework.CategoryAttribute("demo")]
    public partial class DemoAPIFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "API",
                "demo"};
        
#line 1 "DemoApi.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Demo API", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET user info")]
        public void GETUserInfo()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET user info", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.When("I send GET \'/users/aqualityAutomation\' request to github with saving the \'respons" +
                        "e\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
 testRunner.Then("the status code of the \'response\' is \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 7
        testRunner.And("the \'response\' matches json schema \'Users/UserResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
        testRunner.And("the \'login\' is \'aqualityAutomation\' in the \'response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
        testRunner.And("the \'type\' is \'User\' in the \'response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
    testRunner.When("I save the user from the \'response\' as \'user1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
        testRunner.And("I send GET \'/users/aquality-automation\' request to github with saving the \'respon" +
                        "se2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
        testRunner.And("I save the user from the \'response2\' as \'user2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
    testRunner.Then("User \'user1\' is different from the user \'user2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET organization info")]
        public void GETOrganizationInfo()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET organization info", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
    testRunner.When("I send GET \'/users/aquality-automation\' request to github with saving the \'respon" +
                        "se\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
    testRunner.Then("the status code of the \'response\' is \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
        testRunner.And("the \'response\' matches json schema \'Users/UserResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
        testRunner.And("the \'login\' is \'aquality-automation\' in the \'response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
        testRunner.And("the \'type\' is \'Organization\' in the \'response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
        testRunner.And("the \'id\' is 50261201 in the \'response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET users info")]
        public void GETUsersInfo()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET users info", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 24
    testRunner.When("I send GET \'/users\' request to github with saving the \'users response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
    testRunner.Then("the status code of the \'users response\' is \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
        testRunner.And("the \'users response\' matches json schema \'Users/UsersResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
        testRunner.And("the \'\' array has size less than or equal to 30 in the \'users response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
        testRunner.And("the \'\' array is ordered ascending by \'id\' in the \'users response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
    testRunner.When("I extract the \'[0].url\' from the \'users response\' with saving it as \'user URL\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
        testRunner.And("I send GET request to github endpoint saved as \'user URL\' with saving the \'respon" +
                        "se\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
    testRunner.Then("the status code of the \'response\' is \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
        testRunner.And("the \'response\' matches json schema \'Users/UserResponse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
        testRunner.And("the \'url\' has the value saved as \'user URL\' in the \'response\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
