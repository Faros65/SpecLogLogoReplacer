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
namespace Aim.SpecLogLogoReplacer.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Replace Logo")]
    public partial class ReplaceLogoFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ReplaceLogo.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Replace Logo", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Replacing the logo")]
        public virtual void ReplacingTheLogo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Replacing the logo", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 4
  testRunner.Given("I have the html file exported from SpecLog contains", "            <div class=\"logo\">\r\n                <a href=\"http://www.speclog.net/\"" +
                    ">\r\n                    <img title=\"Visit SpecLog.net\" alt=\"SpecLog logo\" src=\"da" +
                    "ta:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAO4AAAA9CAIAAAAlJsL0AAAAGXRFWHRTb2Z0" +
                    "d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyBpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBh" +
                    "Y2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEg" +
                    "eG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMC1jMDYwIDYx" +
                    "LjEzNDc3NywgMjAxMC8wMi8xMi0xNzozMjowMCAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJo" +
                    "dHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlv" +
                    "biByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxu" +
                    "czp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6" +
                    "Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0i" +
                    "QWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzIiB4bXBNTTpJbnN0YW5jZUlEPSJ4bXAuaWlkOjVGRTBC" +
                    "RUVGMjQ4OTExRTBBRDg2QzE1OTgxRTMxNzVDIiB4bXBNTTpEb2N1bWVudElEPSJ4bXAuZGlkOjVGRTBC" +
                    "RUYwMjQ4OTExRTBBRDg2QzE1OTgxRTMxNzVDIj4gPHhtcE1NOkRlcml2ZWRGcm9tIHN0UmVmOmluc3Rh" +
                    "bmNlSUQ9InhtcC5paWQ6NUZFMEJFRUQyNDg5MTFFMEFEODZDMTU5ODFFMzE3NUMiIHN0UmVmOmRvY3Vt" +
                    "ZW50SUQ9InhtcC5kaWQ6NUZFMEJFRUUyNDg5MTFFMEFEODZDMTU5ODFFMzE3NUMiLz4gPC9yZGY6RGVz" +
                    "Y3JpcHRpb24+IDwvcmRmOlJERj4gPC94OnhtcG1ldGE+IDw/eHBhY2tldCBlbmQ9InIiPz5+6z/nAAAk" +
                    "gElEQVR42ux9CZhUxbl21dl6n32YAYYdZFVkQEFAYRRXRGMQNQbFuNwoLkQTfslVf6MQ/aMxelXiEjXx" +
                    "Ju4x1x1ZRMCFxYVNdgYYmGE2Zu2e3s5S/3u6hsOhp6enGRY1t79nxF7OqVOn6q33e7+vqk5Txhj5fgzX" +
                    "pWp1dWDdBu/IYjkv13xP0pa2TppwYi5jRML1i96rX7pAa246+BnVm5u33XDzxgsv23LVNf7VX6VxnLaj" +
                    "MXp8WDmeYRs//2T77BsJFd0Dh2aNPjP77As8Jw0te+ChPQ8+JGdm6YEAWLnHf87udvNNVJJiJ6c5Om0/" +
                    "CCgTvcWPP6ooguKkorTnkXtr331d8mXqapRpqpyf7+7Sv+njr/RgC44hjOmhMFHV3Esm93nk987evdId" +
                    "k7bvHcommwKs+577fWDDaikzR8rIooLc+OUqE9mSRBlhFEeQyKZaFiZUkUlrBUDETGtqcvXr0+uB+/Iu" +
                    "/ykV0qyctiMw6ViLChN/Rjgc3LlZbajVA82R/UxrbNFaNEE2UWsQJsiSXh5mEYHKAjk0kBhOlbKzwmX7" +
                    "ts24UWts7PofN6S758SbYRiNjY0ej8fhcPxvhTIjhho2ggE9HAiVbmLRkOjyUFkGBessSgXDRC0jgiwa" +
                    "Taq230/FRBEnY6LPF6kpD27dkUbVibdIJLJ06dK9e/dmZ2eXlJTk5+f/b4SyEQrUfvzfkcoypkW15mYj" +
                    "EhZECVpCD0f1SJTSmFoQCdGoVtZiqgyaWD8YgYB3yPBuN9+YBtaJt40bN27dulVRlPLy8tWrV0+ePLm9" +
                    "bvoB2jFLxsExRav3af56KkjmX0w5CKDklggzYm8Yo4Ko7WthQY0Kia/LNI0JtNf9/+k6qX8aWCfeGhoa" +
                    "hJjJshwIBDRN+xFV/thAmema1lQjOD2C5CJUILrODINQxH+MhUDJMREti6xO1WtD8ASJI01KtSZ/4fUz" +
                    "8q+YytKw+l6SAPRQGsD++sckMGJ5B+KP6i99s98tS9eMKHBKAuk4uWvK30jl7uDOtdED5UwNM1HAR4Ye" +
                    "G80C1YMRpukmuFFY2Iju9TPBTGDQRK2o+/0ZY0b1vu+3JJ1S/l7R/OPOYNDYf0+tLL9n4S5ZFj4prX9w" +
                    "Up+T8twd3jgztJZtX4fLtwveTKo4hZYWfGTqBBPlTA+GITwoFagksoDOwqqZtUgstcOi19v79w9Keblp" +
                    "PKXtqATGsl2Nj39ZnumWMp3iO1sOXPKPDW9sqO7Qw1BRUgp6UIdTMPEqxwiXMlUDGTMd6piwaAQhoB4I" +
                    "Epch98gwR4zB4nnZYEYo1P3Xs7ImnpnukrR1Esocq9WB6N0Ld0VUwy2LiNqynXJVs/of72yf9dHO/c2R" +
                    "gxqEHSYtYm+hK9QD+wVJgawQJAmigjFD9HklnxdlOwtzfcOHOXt0lzOzzBMyI2JPFxWJiexWNMOhCZAW" +
                    "2edP6n7rzen+SFvnBQYH1NxP96yras51KRYNA9OawZ5dXfH1vuZ55/Y5u1/24SLZDOWi1WWB9ctxhuBw" +
                    "G5GgOZlHRSMakjJ8rl4DpKxcT59hcmFvfMWiqtrQ2LBiYdPqZay7RgOu5lXfUMUhOmQ9FFS6FvR99CHR" +
                    "6+FTgeleSVsntfJrG6pf/rYqQ5HscgIvJYHmuOR1lYGfvbF51tgi/HkUsTUW5Glit4/KTqZHBMXBoiEm" +
                    "CFJOLsJHd79h3lNLRJfHfiUXIRkjx6i1Nxt6RPLmVDwxv+KJp6M11VRSev7uXvfgQZZoT1vaOgPlTdUt" +
                    "8z4to0SQ2uR6ef4iyylFDTZ32Z6Ve5vnnddneKH3oNKgIGPRl2nU1wiCaChuFmyWM3MzR1+g5Pdo73py" +
                    "fgF/0fPeu31njK6c/6zvtFFdfn4VSQM5bUcJ5be+q9lc1dI1w9FegIfPZZFmCtKinfWbagIvTR00sY8p" +
                    "NpihB0vXG2pEcHlZOChIspCV7x0yFjhOcYFm9jkT8Xdcb2/Hjh2ff/759u3b9+/fHwwGFUXp2rVrUVFR" +
                    "cXHx6aef7nQ6k5y7d+/eP/3pTzU1NTfeeOPZZ59tfV5eXr506dKtW7eizJaWloyMjB49epx66qkTJkzI" +
                    "zs7uXD2bm5tRz/Xr15eVldXV1YmiiEr269fvzDPPHDZsWOfK3L1792effYZ7r6ioQD1lWe7SpUuvXr1w" +
                    "46NGjUJTHKtGjkQilZWVqDaugteIflwul8/nKywszM/P70R2r76+HnVuaGgIhUKCIKAo1BwNYq/zrl27" +
                    "0BG4osPhQOPn5ORI43pl9s517m+Ogn2F9q4ag3mWS9pdF1qzL8ChjIBNdHo0IgiKZGYrwkFXz0GO7n1J" +
                    "Z1YbH/vVyWvXrp0/f/5777134MCBtql+tPWQIUNuuumm6dOnezyetqejEX/5y19+/PHHeL18+fKPPvpo" +
                    "+PDhwO5TTz31t7/9Dfg2DOMwbyPLffr0ueGGG4B7NGvq9ayqqvrvmGHURaPRuG8xTs4777yZM2eWlJSk" +
                    "XubXX3/93HPPvfvuu4BXXD3NKMjtPvnkk3F3P//5z48S0IFAYNOmTah5U1OTNTXI51bwL0AGCA4dOhRj" +
                    "EoMzlQJRzjfffLNz585wOGzvNZyOVsWoRq/hQsuWLcMxeAGgo9FABFOmTDGvurYycP+S3SvKmhSIXZpg" +
                    "Ks4EGmWBiN472/n21cNi+WbzMz3QECrdoEMlayoVRM+Q0ZLvKLPCxwbTzz777H333QcQd3jkueee++ST" +
                    "Tw4aNKjtSAB7Wd3z8ssv45jrrrtuy5YtyQs87bTTHn30UTB0KvX88MMP77nnHpBx8sOAiVtvvfXee+/t" +
                    "kPUbGxsfe+wx3BF6t8Or/+53v0MrCTZhuWTJEkAT+MaNA4WXXXZZEqzDL61evRrcKcYsbqbQ7EvGeANi" +
                    "kI8dOzY3N7dDNwLWQIG4KK9VbFKiFQ+8KIwKXddxJLiDXxFQzsrKuvrqq80TRnT1vviTgWO6eMwssJHg" +
                    "GihNY0QW6APn9LFwbJburyeiLDp9CN0kX47o8qWMWEZ0P2EqURtYdD8juKpB9OAxwfGLL754xx13xOEY" +
                    "VIQbbtsxixcvvuaaa0C3cZ/zEW8x7ltvvTVt2rQ4HPP+izvxq6++mjp1Ko7vsJ4A3FVXXRWHY1w0MzPT" +
                    "6/XGeXBInRkzZlRXVycpEN9ee+218+bNSwXHsFdffRXk17lGXrVqFXAPEsUwkyTJXIETjQJkHMGqquIt" +
                    "PkTT4Vsw6AcffLBv374kBe7Zs2fhwoUoEKoPrYrT0QU4HQ2ixQzl4C2KggbDRXEM7yP07CmnnGJeqHWE" +
                    "VfrzBDqhwLO+MVwT1gB49JKdIVsi2k0ju/10aL49PFNyuhEtqof8RPCJnkwAumPGZTphYWKEmdZg5kG0" +
                    "FgpA60FmhKneTNwnE8l3NDjetm3b7Nmz0ZT8LWBxxRVXXHjhhSAGCAm01MaNG6E6gGDILMsdP//886Co" +
                    "w0cvtfMBesL6qn///pdccsn48ePBW/gKjQvpvGDBAtAJPwBuHfyNkQPKb6+ef/7zn3/1q1/ZfSi8J6hl" +
                    "3LhxUPOoP9jxnXfewXWBS04/77//PlTB66+/nlDiw9dD29jrCUMfT548eeTIkRAqQC10M/zAypUrOYJH" +
                    "jx7dOYEBMgaUgR7O30Aw3AVUOMQxgIWqop33xQwXwmGoMNwFkHrRRRd169YtoTNBGwK+wCjuHRxx0kkn" +
                    "9e3bF0SOwsFK6FYoY3zOK8z5Hn4SSgndCjHdmowzGFm+o6Elqmc6pbG5rm0Bdac/rDIm0dZlGKpuFLjk" +
                    "7orIDp+now6X4PIxUy5rVFbgD4iQZH0SJUaEGMEYlGPTLqBhZpizg9FK/oKEdjJHIVGrqVJE5LxOtDKU" +
                    "gAUpwBe69qyzzrIfgIjnF7/4BaB8//33o1P5h4hakroQZlH7rFmzQPnoM+tbaAlIZIyHhx9++F//+hf/" +
                    "ECEmkAreAi7bFgg3+tvf/tYqFuPt7rvvvuWWW4B+6xiIQvgBxG1QIPiXfwj5+8gjj0AVtPUGIGM7jhGJ" +
                    "okw4HIDYftidd96Jw9544w2MQ4x5UN2RtjCGLjwP50vADiWgSTEO4zwJQIZWhfBFfIZjAEEMNmjcSy+9" +
                    "tG1w8u2333I+RoH4F00KKFvfFhQUDBw4cN26dRhCYHp+XdQfMbF9VJvI230guL26RZaEiMFUnQ3xKqNz" +
                    "3V5ZMD0EoRpjLkkY4nMaRoJpbNGbJcgKlWTGDCMSTEbJ5lpPP/iYr86geoQwqB+NGKHYalCZ4XW0jDSv" +
                    "oIFvSHATIUe8LAsjGHdrvb3tttvicGzhEnz59ttvX3nllWjlESNGIK7qsHB0BiTBQw89ZMexfYT8/e9/" +
                    "B8qtTzZv3gzYtT0S3mDOnDmWBgCjPP3000C2HceWobcwPMCs1idQGt99913cYRiTTzzxhPV28ODB//zn" +
                    "PyGv43DMBQxcyiuvvPL4448nJMjkhsqvWbMG7Yxy8C/aBC05ZsyYOBxzwzA+//zzES5zJwnGRYwLcMcd" +
                    "BuqB9kVH8GAR7s6O49ZEW2zAoKe4YsaRXCsfdmtmQ5Q2NIY1SSCxHR8kqBp5knRmnqe3V9FiW5gGZSg+" +
                    "kY7um9V2ux11egWXl4iSICmGFiXtLtqAtFApo+YFzUWfIgPlA9wgaWJQBnVRQ/Rak7CBYNHLolVMOxCj" +
                    "auNQDqUjQ/vabw/UmEj3U6uhAT5I1UWLFqG5Oyz817/+Ndg3yQHgbOADPtT6BCiET487DIwI72y9nTt3" +
                    "7vTp05MUm5eXBzVy6qmnWjH+X//617jBiTEGPW0dD72EmPV4JDdByTU1NUAwZwTQJ+RWkuMBOIzGAQMG" +
                    "QDyg5XEipILlNrnxnCbEA2AKZ4Jx2F5p6KacnBzuClANCLl4KPsjeihimJLi4BK5sI4gjI3IdI7OceMv" +
                    "TxTzMpRTinyJEEqkzHw5t6uYkSu6fUnCNkYlQhVCvUTKIUp36uxFnD2JlAv1bKLWCJra3MyU6IxFqNFE" +
                    "Gpey+v8hjYswBlhq4SAaC57IevvMM88gsuGxSHsNDT+Ovu+wZBR7++23pzKWQNsWv+7duxfa1H4AtCP4" +
                    "0np7zjnngDs7LLZnz54YSKitNULsaABJf/LJJ9ZbCBsQ2/HAMTC0Y8cOHkUAmgNjlkqbnHHGGfAPXASD" +
                    "XzAe4rLIPGOI4YE7TVIUlAk8CdcYqEBcZG9CedrIwpkTevTr4jG3cRg89QZdQUKa0dUhdnVIIY3leWS3" +
                    "3G5qUFBcostLRTlJCoKaq5Y9RATcFUplIriJnE/dA4mrr/kWBKzVEbWKaDVUq2V6I4mUktB3LLiB6P7U" +
                    "8xrwnvbhfv3110+dOvUvf/kL+uBoevGyyy5LqHrbGiKtKVOm2GWxFYPCSktLN2zYYA283/zmNymqVehm" +
                    "a66koqIC4tL6asWKFVangtUQGh6n+SY4BBAhKgz6hFoAC6Q4/YGgEMQMTuESAiPcnu22sigAaMIcv90s" +
                    "cYyi4ryu2Y55XuWy4sLT+2Y9t7SsvCkCdtZ0voWJBAFtiAJKvIooHO2i7ERr7kHVDnMgsuZPqdEM4WGO" +
                    "LpCwuUTfQQUnMaJEa2ZSTorXnjRpEuD70ksvWWmsd2OGKAFNj5h93LhxxcXFiCRSj3jQfOCVVG+S0rPP" +
                    "PhvShb/dsmWL3++3Jk0QA0EvWkoAgACn2rHenkGMgrHWrl3LMyoYmWB0S5RbEWRJSUkqTqZzBhyjPeEc" +
                    "wIh8Ji/1c7t3744xjHqCmBsbGxECWjre6gie0evQM1jtbLmpQ1Bu9baUOgShq0eGoIVcblH1oMp0lA9l" +
                    "QEkXr0ORjs9TuRAFOnpSpQdTqykGKwuaMtrc0Qp5LcJPMK2Wkt4pFoaW+uMf/wgCePnll+2f18QMETRe" +
                    "FxUVIRycOHEiQpbevXunAqOEoV571rdvXwRzQDBe19bWgjItKCO+sQQPHCuEddvZuPZGSEImQ9+Xl5db" +
                    "n1uS+niYPV0Noj2iRB6Ai3HLq40626GcmZlppT4rKyuTTNQDx2hPi8LjAuVDUA5G9aC5ecnEdJZD9DnE" +
                    "qG60RA0Qs8sh1geiDS3RHK9y7FuIL7PzjiSRvVAUxGgxpQgBK9OYRKa0cQELrqVKN5IxiQnODukZrYy4" +
                    "B0h94YUXvvjii7YHoO9fjRkijBkzZsycOZMnJtsz0AZCutRvyBUzDmV0HrrNngGw51uS6Pjk1qdPH6t3" +
                    "7dMcnV4EkqJWtuj/SBPSfEYQo5HPYNs3wMJDojQ+n7Jnzx6AtT2+BxFUV1fjYNQEXRbnfw4RbUtEC0a0" +
                    "qGZuLdVNF0+copDnlLp7lVyXXNMY3lcXOn7NRMRMKhcwI2QmN0DJ5lOMdHM6EDGfWk79X5D695hWl6LM" +
                    "wN1ed911CxYsWLhw4R133AH92jYtxb3/nDlzrrjiiuR5ZbTyEe095rNT1jCw97o9D9q5XXQ4a/r06Vae" +
                    "hM+BJU/aHLMusq2jONLN2EbM+C3jX3tRhTEDOkG0qD88J0R52xIQ+Xz++ef8dFAA3CnovC0rm5Fehlvu" +
                    "meMKRIwoqMLcmmfOeBAzf0Z0SiSRVjdGWE9yHHcxKl2JIBG9yRQVCAqpw9zpaibjFCKIBLpZcB7REg0M" +
                    "3PNihgbatGnTmphBbgLB9p74+OOPESq9+eab7S2Uw+lxeZ/kBuawOgNO0E4eCMustQr46pZbbgF/p76x" +
                    "GV0Ixfyzn/3Mgi+8tl38dLhE5GgM7WkNP4gNPpmcekKa5+O4XLaHd3iL6AWuEneH2wFk33///VGjRkFe" +
                    "8x6BW0OMgY5DR+DGcV1IPtBTvPM8mFIjPXJcN5b0Ajcv31y3rbJFEalhJpVbJxUUUdxS4e+d7zqpm+94" +
                    "7fVw9qNiDglvMZWFrpjAFXxmogOhoQluD8R85zazQx6cFrNbb70VTYb445VXXnnrrbesGAJtB/6+9NJL" +
                    "2+sGBGdWmNWhrVy50lIOUAJ2hwAZDWRzwRcKhaZNm3b06ta+Fuqzzz5DZHacnpEFxQ8kAQ6gTwQAGK4d" +
                    "rhCyD29AmQMRDRKn6PjSU55uR+UbGhqWLFmCoY7DcDmEibgWn7U2zIk6hvC97aUPi+R8Tqkw09kr141o" +
                    "yyFRlyS48SdLHkVCyAcxvbasKRTVj9eeJcgJA2QWjcV8eO2nWiXR9hGtxnwtekxYH7Uh5oN3RlD45JNP" +
                    "2rt88eLF7daLsQ8++CDFlTcILq3paxJb52DX2f379x8wYIAVuj322GNHf0djxoyxRsvGjRs/+uij48TK" +
                    "wBZ8OidjRAJx6eEkBjblU0VcG8A1tV3zyVdR41s0C77FaEFYDOlcVlaGa/FlSfgW42HkyJFtKZkkfKRL" +
                    "lsdcuByJiWZTZphdac41O2Wxzq8u2VjjD2mJMxFHaUaEaPVmghk03Fox+CNgup5p1Sy0kTS+RaNlHRaz" +
                    "efPmDrPIaJebb77ZvtwnuVyGgHvnnXdSuYk//OEPVh/DjV588cVxgfwFF1xgvX377bfjFgB1wuBt4KAt" +
                    "STp37lyA4HhAGe4eToY7HDQgnJuVT0hu69evxwgHHLmE6NevX8IYYNy4cegReC2+sI5Lag5insDBKMKd" +
                    "tpcYTQDlHK/icUouWVBEAaB2SiJAjE88DhFvK+rDKzYf2FkVQIzIwWsurQipDf4ouD8566IyLAniWZQZ" +
                    "zUzMYUovJndn1Gku1TC1ukipQtUaUvVfrOwOFliRZNzMnz//opg9//zzHTaxPWCCZk0eyc2ePZundZMY" +
                    "yB4VsN6ef/75bSeQb7jhBisDCI2BqLTDYjmx8ZRIWwM4brrpJustSps1a5Y9VXIMbeDAgda8HSr/ySef" +
                    "JAzR7LZ161ZUiS+ZAEAhsZIkpAcPHvyTn/ykpKQE7is7OxuaGHfHYwlcFFcH3IV2lqyJhy9uNMMql0Mc" +
                    "1M1b3DdbFmlNc8QliyJf2mDOlVCXIoRVo6YpWtccrW9Rm1rUer8aCIHBiSKJcju5Z6huVcd5Yc2ICuYj" +
                    "XhJNHPqXk5aVRPKS0HIwMVF6QxwTFjy4PFpkVAagqXsocZ2cUOKAja6++mqoYbyAn0UTDB8+PCFG8dU/" +
                    "/vEPaAxLLl9//fXw1PZ4+aWXXrInyxDoLFiwgC8+bNuawNkjjzwCuFtJfvhiwNrKmtmDJ/QQ1Dl/CyGI" +
                    "uBNiEcIjYSfhXjAsb7/99meeeQYwSrhcBAhYt26dtd4DfIn4b8SIEQm1bEVFxRNPPPHaa68hroqbwkR0" +
                    "BaLlWTO4FBQbpwR4Y+7evRufgyxReXgzYC5hgghti1p98cUXKA0HQ8Tj3gHT5FN6EMQFBQVgbsQAADSP" +
                    "ofn6DVBDkqxom+eC8UduxdRwYzD6P6srm0OaLAqKTEHSENDmNzHUAt8OSQDQ3Q7zz+eS87MUZ/uT22E1" +
                    "EFb9jBgOye2SM2PJY7u6CJGK+0i0jKnfEb0OgSUTHIJjBBFziVprrm+G6jAiVMwkPR8ljv4J95sAT/A+" +
                    "mzZtsj7hSzohWBHmA0AgV7Q+OuyNN95AX1qpqy5duqxZswZ4sk78+uuvx48fb63RsTtZ0Mbll1/O+QlY" +
                    "r6urQ5yHgYES7EcCLmDH9jJTt912G6B5yDkKwtSpU1HssGHDgAz0HEbO3r17ly5dCmFj5SXQtcuXL0+4" +
                    "og2qBj2NW7NPsF177bUXXnghwgMgABoUsEM4BdfBJRBK+/TTT/GtdUoqu0hwy4sWLUKVOKyBVxyDcYjS" +
                    "+OYG3B2uBQjiGAwb3Bqf6yaxBYmpLNuwjC9i4Vk8DB60PFCeMpQPoy6yamd9eV2oMNNRYSaVzQfTg5nd" +
                    "ADV4lQoeRZREATztc0l5mUqWR06WYNejzSFzwwjI3aVkuJXDN8CpB1jlgyS0imh7zFVHMT1iJi6U/lQe" +
                    "THU/0RuIEWQZk2i3+2JiOrFBfU6fPj0uRIP8QocByhx5CCbsE6RofdDejBkz7KfYoQzniH7CWXCp9vAR" +
                    "PYcC2y7Rgt19993z5s1LkqsC04Borflty3r27Inaoucw5NCRcXPaQAyg3N5qEPAf7h31jMveoEzcOyq/" +
                    "b9++uA0mCxcuPO+88+xQ/u677+DTk2+IAgXgyNLSUr5zCVDjgMZVgG+0CQ7gE0NcwvHtHmeeeWbCcC2J" +
                    "wb1gMKNkHi+iZUBVdsZJPNuXSImT0/tlj+qTBdnwTWnDxr1N2V5FooJumFGgIptPNvK6RKciFOU5nebC" +
                    "fJYk7S8Iom6YwaRABdlwxWf05DwmiDS6jYjegwNJNJk7upNotYarmApdqVpBvWOT4BgGbkM7zpkzx77H" +
                    "6UDMEh4PGfDwww/H4bgtD4FfAWu7fiiPWduD0Z3333//XXfdJSTbhWBe94UXXkAs//jjj9tHyN6YtZcL" +
                    "wwhJsqoJOhIUfuedd4Jr7bCDWk14PIB18sknx7kL+12315sYHvAAq1at2rhxI5oFIxbox7kYnxiBPIbj" +
                    "w5jPFqHmY8eO5amb5CBJmP7j4wSsDPEDjYdGGzp0KMZnXAvHaeU2+AOxxxYp52U4XQ7p1D5Z+RmO5mC0" +
                    "b6G3S5biksSB3b15mQ459gj75FU0jGhzuBb/xhg6jJBSEV0H2Z/SwDJS/RCLzQQRK9dtlikRFiJaGYUj" +
                    "cJ3G8m+KVyZtDGoSjgz4AHzbC5X4HC+cL+Qy0J9wbsnSymj9KVOmzJw5EyXDYwLBCV0ZQHzBBRegQOj1" +
                    "VHoLfXPOOeegjxsaGkDtSZJ9AMGVV1751FNPocLJy4SOgkrBrVVVVaHMJIdNnjz56aefjpPyaC5wLYkt" +
                    "k0Bs2nYJvD0FhANAk4Ayf2YAlwHceLYBrYQ2gWSCPrZE0RHNcfL0M+4F9QFwuYhHt+7YsQN3B69oX/Lf" +
                    "mWfoRlQdlNyqmlPOMQejDVVNW4ELScQIU3I9fZyyr7UEdT/bM42ENzPBh3ZoJ24MEbmXUHAvyZpqifrk" +
                    "V0TM8dlnn0EqwLFiQIOf0AGIhDCsQUgTJkwAjNrjzjitjF7nC4tBPIsXL0bkjtaEHESZaG6oUnTYpEmT" +
                    "Jk6cGLdcK8VJ3S+//BJlguRQVb4WmT9HAiEmhD7i0eQr3BMOxWXLlq1YsQIhGiQyv/f8/HyQWXFxMe4d" +
                    "UUTbs4AYcC1OAR2eddZZcTPD7eV2ADVUGwgDffAkGiIKBBKoP1rmiB6l0J5iRsuAQXjKGcY3WgPH4CxL" +
                    "b6QO5YO/43QQQ0e6zb+6eXt9cJ8sOjEGJEEpyBjglFtbilXeQ2oeI1LeITZOcH1KjBbzornXkYIHqOhL" +
                    "HSigDbQCV2xwhYigOwRce1C2DFoQPcd3BbtjdvSpLnQPZziuMlFm8hRhijPGwDG/dyAM3d/hIylwPFop" +
                    "xSdX2AUJ37Jq5YOP4aOaeZCzffv2bdu2oeW5ekafYpxA0B/appqa0bgXNNURYGrilkhdQ7DC0HWVRKAr" +
                    "IlqwMVRVKGccLEYwIzymUSLH8ieJA1QiuinRWe2T1DWaZF+ZYr35422Sr33rhHljdmzLVGJ2bMv0xOyI" +
                    "TuncsOR8eQzmfBOJaZTcJWZDhgyBq4ET4OuoeHAM6Uw69wMOO2u/2FS5SDMiqY0AGlb9e+u/DWuNsRSI" +
                    "EdVCDsmT7S5qxTGqnj+LFcwxVw6xlqRjBOdrVOlFnYNI2v5dDG6zrKwMsSnPjSbnctAw1BHcC98WhX+t" +
                    "vWFHvHd8e83yd9bfpxqRQQUlZ590GxBpMD3xlEfsB9BqA6UHmkrDml8wf/AsIolug6kiFRXJfYjlpTyh" +
                    "6zzmOYNV/l8a2RrbNCUnmNFjmjm5XTiHuIanEfDvYeBgPo0CcYLQEPFGh0uU4DRAyVYqyYJ+6lA2ZWpj" +
                    "aP/SHX/WmeqQfNtrVtQGdo3qcXlU8zvljB7Zxdnu7oIgm3N5hIaijUG1qSlYXuvfycxQzylQSTc0UdRQ" +
                    "TlO4Jjva6FGyD1MsGZOJ82RSPZc1vEmpRsz8xuFPydX9LGsazb42jYB/G1NVtbS0lG8WRHj64YcflpSU" +
                    "IC5PcgpCQMhl/rABELMVVh6BVgb7Lt/xbH1LmVOCxmUOydscrl6y/b9yXUU+Z15p7ZdgaKfsQzBnfhWq" +
                    "iKotApUdsoeAj81HXjhMXtWjsujK9/V1ST576Ni6NkPpSYueIZ4xpPr/Ea2aiBm2TEuQOAYIhQ8QwWGL" +
                    "QdP24zYgEgq4vLycPy4R2nfBggXDhw8fNGhQ2/wJIj/okA0bNvC8EwZAdna2hfsjEBjryt/dXLXY2Zo6" +
                    "MFMZkuAA4TZFalWm5Ti71fh3gLDNnyQRFDAumJiwkChKiuiJLXo24Ap0I1qUfUqOp5ctK9IqqQ++kmjO" +
                    "DcQ9CmKD+D+JrVd2mr9ciWMLH2TA+okC8Y/3t5J+RAZQFhcX79+/v6qqClBG1MsTglu2bCksLARS+Qrp" +
                    "UCgElNfU1Pj9fqAfUSDfdWJ/mkyqUK5s3vJ56YvQD7ZtJHxzi4j/BSJ1mh7u7husE5UR8xd1oCUUSeRr" +
                    "9znp4k8gomqEwmpTm6xIG3MOJ71eJzWPsbpnqFZjJje6/IZmTjmRsYh9LVGnN+GlrUPz+XyQyJ9++mlF" +
                    "RQVf0gmkQkJs376dZzN4vpg/r4c/TQbIRuQ3fvx4a/F3qlCOaC3LdjwbiNY723k2IcI+3fyBPs2c6TGv" +
                    "LogmYZsTP2ZESM3MBTNwgO6QPLKYUq6HCi5SeC/xjGY1j1CpGyn4P5ZkPwHtC+/Gp0ytt2nMHT/Lz8+/" +
                    "6KKLEP+BjPmTivgiJLtj5PtH+Dx57969R40aFSepU5oiWbHzL6Bkh5xBE8SCXEZreZ5ePiVHMyLmj5iI" +
                    "SoaSzzHnc+RLggKedsi+woxBOd5eUNJHyJABM6FBHSeycUHDd9111/z58/FiwoQJb775JiRdGnPH2w4c" +
                    "OMAf09/c3AzUWs6Q87HH40Ev9O/fv6ioqO0kV8dQ3l235p/r7qZEaCfjZj4ny+fIzff01vRILL1iuOQs" +
                    "t5xpmNtbBZ+ziyTIqh7Ncncf0u38H1dwjYC6vr7+4osvTuP4BPMINDHEsX2OFjok4ROyU4Vyc7j6zbWz" +
                    "DwR2Ke2oAqhYSXR09Q0yn2Vobmw1AzgwsSwqeCNQwS1nmb+AZmiZ7m5Du1/UXgY6bWk72mRIku8QqH25" +
                    "++Wqpi1uJau9Axglue6eIhU0osYUhSGJLiiK2G5AQxSdOZ4+HkeOU/F5HV3SOE7b9wNl3VD94VqNRduL" +
                    "tBjTM52FLilDZWGeTTNnQ6jCYzOc7nXkDiwsgYJPN3Tavk8og1wnDrgZUnhX7UpFcguHTyYbiORET7ar" +
                    "K0I9SvkkBxMF2VTJTDd0TTPCiPAOxzFLz2uk7ThZx2FfVA+t2fPaqrJXVS2oSJ6D7KtBFXfLGGRyNzMk" +
                    "KlNBjKot/fLHn1J0cVQNRvUWVQtle3p4nemAKW0/CCi38ujuujXLtj+zv3mTQ/IJVAqrjaN6XlHc46d7" +
                    "67+uaNroD9WoepgKwrmDZnfNHJxu1rT9EFnZQjN0M6LAdRXvh6KNvXKKp434I6QwPsfbav8OYNqj5Awv" +
                    "ukwSlXSzpu2HCWU7oNnmqiW7DqwZ2XNa14yTDlsPxIzWh2WkLW3fh/1/AQYAq/5GxtEuhlIAAAAASUVO" +
                    "RK5CYII=\" />\r\n                </a>\r\n            </div>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
  testRunner.When("I replace the logo with file \'logo.png\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
  testRunner.Then("the html file should contain", "            <div class=\"logo\">\r\n                <img alt=\"Logo\" src=\"data:image/p" +
                    "ng;base64,iVBORw0KGgoAAAANSUhEUgAAAPAAAAC0CAMAAACdQlHaAAAABGdBTUEAALGPC/xhBQAAAw" +
                    "BQTFRFAAAABAQECAgIDAwMEBAQFBQUGBgYHBwcICAgJCQkKCgoLCwsMDAwNDQ0ODg4PDw8QEBARERESE" +
                    "hITExMUFBQVFRUWFhYXFxcYGBgZGRkaGhobGxscHBwdHR0eHh4fHx8f39/g4ODh4eHi4uLj4+Pk5OTl5" +
                    "eXm5ubn5+fo6Ojp6enq6urr6+vs7Ozt7e3u7u7v7+/w8PDx8fHy8vLz8/P09PT19fX29vb39/f4+Pj5+" +
                    "fn6+vr7+/v8/Pz9/f3+/v7////AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                    "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAxdBzUgAAAA" +
                    "lwSFlzAAAOwwAADsMBx2+oZAAAABZ0RVh0U29mdHdhcmUAcGFpbnQubmV0IDQuMDvo9WkAAAYdSURBVH" +
                    "he7ZrrViI7EEbDRURFBUcPeEFAUFEcRQVE5NLv/1RDvlR3p7v16IKAY03tX1SCrN4kqVSCyvvHEGHuiD" +
                    "B3RJg7IswdEeaOCHNHhLkjwtwRYe6IMHdEmDsizB0R5o4Ic0eEuSPC3BFh7ogwd0SYOyLMHRHmjghzR4" +
                    "S5I8LcEWHuiDB3RJg7IswdEeaOCHNHhLkjwtwRYe6IMHcWEX5tnZ40Xyj4aSwifKzmlCj4aSwiXNHCRQ" +
                    "p+GiL8BUT4JyHCX0CEfxIi/AW+Ivw26Hafh1OKksz6T//T682Gj93uy4gil6xCeNqpbOi3KJU+uHznoa" +
                    "eXRzsp3b1TJEr31AV69V38tVLb1Udqc4Z74dlVDg9LpGtj6vDpbFGXxS71zekfUJuh2KV2RzgXHu3gOS" +
                    "1yA+oC4yI1R8hTr+edY+xtGtTjBtfCg008ZISsPS//o7b9Qtq8AvvU651Rg80Z9TnBsfDY+GbKncFk3L" +
                    "8pIVKb4ay+RUMJg97FUk1dtdtt/7DZQLfavXgazYb3Z5QKrqnXBY6F0aVyTxR6HTNBKxR6r1kd1iia4a" +
                    "DpR3N65u3nM4pHe4gzQ4od4Fa4i+crvFI4p5tBU5/CKx1s+T7eWOe3dHiXUNDdKWtAJ2aOnFDoALfCv3" +
                    "RPJpKW73WTOqXoUAeW0IWOmxR4DzpSFxSBGb6DdDzTL45T4SFmZCzHIGtnqMjY1oE/3HPudHxMgXeko+" +
                    "j3ZeaEuqJoeZwKN3VHKnbbdakb1bMJMMGtCquvY/+jpu99XxP8SZmi5XEqjBE6oMBnjO3n0gRIu8ES9r" +
                    "wnHR/agYrfDp7oxi0KlsepMEooK+kaMKcp7SDrWlMau1SdgpYOMhQEtHWrcraInQrj0RKbJkqrX+Y1hu" +
                    "vGvNaUddyhAJvUDgUBv3WrcrYxuRQe4tEeKAqw344FHdYhZhL7I44ijL6ZEPOeYGdfFpfCyECJNWiqRS" +
                    "qWZ0jTh28mes7rKPgkTAV/AwswX6OzI4RLYVN2WFWH4Vy3blNgttps8/6l36kiK2eDP9jX4TkFAX+x8D" +
                    "MejTagEKxT/+09+8gA/JRFIxxUoT5mSvcoWhr3a/g3RQHwODKvp/HDY5b2Kw0OwonP7eB9f2XSesWjJb" +
                    "I0FiqVEzpLp+vBDUHqhFYzwOf6cz8Am1Xa2ruXw6WwKSvip9cZVuodXr/p1w1venVcym8fVq8jVwPmbJ" +
                    "iN33RVdWtwXl4ap8I4O+Rig3GjG5W52sJrq+6IYs4ZbYqIKaZDIpUtjFPhmu4I6ggCxx26s0LC/rBoGu" +
                    "tetUcRYQotd3d5ToUHeLhoMW32KlrYmJ4f31GZ67voDMD3lSi/FsepsGeO6+FGM8/cqDT8hWl24b3G8/" +
                    "DdJGSqyG37ZtdMGnenQ8fCZhWqSqDTNbdS/rqc4YaH2MznSyfNOytJmdO+ygVjPMGFgSo4y9FLCOcqEW" +
                    "rmmXA4UKp0h/Clhgxt1ce9yJ01yLVCZbrTylyg+prcmF075azqmLOwcBzz28EEM3hONl8s+De29hwdJY" +
                    "1VLizOsOnOSeV39/NUlKViWXA5nAnTrJ0k79n37bTsG0XIhfX3tRljC7e+CwnX6VEi3FLnrB6tlrMNu5" +
                    "LA8XDj0RsPh8PH7l3zyPjthIv0wazjgIMPt+3FWET4rZQYBrUZTtvRGYpJUKjZtaP3oP8wa9dXrzgi0Y" +
                    "IwtIvBx2+UHf+ytJjw5wza9Wql1rqNHxWxwqOniwlWur2TzdvuWvXj00b70WF29lmN8Adg14pVUiYjJA" +
                    "6FK2Otwqgi4oXWqW6sUrB61iqMwbQOwABJKvjxYeWsVRiltH8LTSCPJS/CVsZahfHDSjqStPqoPePreo" +
                    "WsVfhNyyl1Ghz2XioY31TiHmx1rFU4qLM2DyrV83IxTxtui7rXwXqF360s0w4Pf5+zZmHvNvE/IIcOf9" +
                    "7/AusW9qY35fBQnN6trVf3G4Q1o/u25qG3gtLxM75F+DsRYe6IMHdEmDsizB0R5o4Ic0eEuSPC3BFh7o" +
                    "gwd0SYOyLMHRHmjghzR4S5I8LcEWHuiDB3RJg7IswdEeaOCHNHhLkjwtwRYe6IMHdEmDsizJ1/TNjz/g" +
                    "CNSpxm6X45QgAAAABJRU5ErkJggg==\" />\r\n            </div>", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Html file contains a different logo - the html file should not be changed")]
        public virtual void TheHtmlFileContainsADifferentLogo_TheHtmlFileShouldNotBeChanged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Html file contains a different logo - the html file should not be changed", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 21
  testRunner.Given("I have the html file exported from SpecLog contains", "            <div class=\"logo\">\r\n                <a href=\"http://www.speclog.net/\"" +
                    ">\r\n                    <img title=\"Visit SpecLog.net\" alt=\"SpecLog logo\" src=\"da" +
                    "ta:image/png;base64,something else\" />\r\n                </a>\r\n            </div>" +
                    "", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
  testRunner.When("I replace the logo with file \'logo.png\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
  testRunner.Then("the html file should contain", "            <div class=\"logo\">\r\n                <a href=\"http://www.speclog.net/\"" +
                    ">\r\n                    <img title=\"Visit SpecLog.net\" alt=\"SpecLog logo\" src=\"da" +
                    "ta:image/png;base64,something else\" />\r\n                </a>\r\n            </div>" +
                    "", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
  testRunner.And("I should see a message saying", "The SpecLog Exported Html file did not contain the default SpecLog logo. Did you " +
                    "replace it already?", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
