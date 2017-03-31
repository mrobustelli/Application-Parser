<#@ template debug="false" hostspecific="false" language="C#" #>
<#@ assembly name="System.Core" #>
<#@ import namespace="System.Linq" #>
<#@ import namespace="System.Text" #>
<#@ import namespace="System.Collections.Generic" #>
<#@ import namespace="TypeGenerator" #>
<#@ assembly name="$(SolutionDir)\TypeGenerator\bin\Debug\TypeGenerator.dll" #>
<# string filePath = @"C:\SourceCode\contract-analytics-application\application\application.xml"; #>
<# string fileContent = System.IO.File.ReadAllText(filePath); #>
<# var app = new TypeGenerator.Parser().Parse(fileContent); #>
<#@ output extension=".cs" #>

namespace $rootnamespace$
{

	public static class Application 
	{
		public const string Name = "<#= app.Name #>";
		public const string Guid = "<#= app.Guid #>";
	}
<#= app.WriteObjectTypeGuids() #>
<#= app.WriteObjectGuids() #>
<#= app.WriteChoiceGuids() #>
<#= app.WriteTabGuids() #>

}
