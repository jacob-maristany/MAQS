# FluentMobileElement.SendKeys Method 
 

Send keys to the fluent element

**Namespace:**&nbsp;<a href="#/MAQS_4/Appium_AUTOGENERATED/Magenic-MaqsFramework-BaseAppiumTest_Namespace">Magenic.MaqsFramework.BaseAppiumTest</a><br />**Assembly:**&nbsp;Magenic.MaqsFramework.BaseAppiumTest (in Magenic.MaqsFramework.BaseAppiumTest.dll) Version: 4.0.4.0 (4.0.4)

## Syntax

**C#**<br />
``` C#
public void SendKeys(
	string keys
)
```


#### Parameters
&nbsp;<dl><dt>keys</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The keys to send to the fluent element</dd></dl>

## Examples

**C#**<br />
``` C#
[TestMethod]
[TestCategory(TestCategories.Selenium)]
public void FluentElementSendKeys()
{
    this.InputBox.SendKeys("test");
    Assert.AreEqual("test", this.InputBox.GetValue());
}
```


## See Also


#### Reference
<a href="#/MAQS_4/Appium_AUTOGENERATED/FluentMobileElement_Class">FluentMobileElement Class</a><br /><a href="#/MAQS_4/Appium_AUTOGENERATED/Magenic-MaqsFramework-BaseAppiumTest_Namespace">Magenic.MaqsFramework.BaseAppiumTest Namespace</a><br />