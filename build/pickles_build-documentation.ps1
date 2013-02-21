#Author: tmeinershagen
#Date: 2/6/2013 5:53:04 PM
#Script: BuildDocumentation

# Import the Pickles-comandlet
Import-Module 'C:\Pickles\pickles-0.9.86.0\powershell\PicklesDoc.Pickles.PowerShell.dll'

# Setup variables
$root = "C:\Users\tmeinershagen\Documents\Visual Studio 2010\Projects\Demo.Acceptance2\Bowling.Domain.AcceptanceTests.Specs"
$FeatureDirectory = "$root"
$OutputDirectory = "$root\Documentation"
$DocumentationFormat = "word"
$SystemUnderTestName = "Bowling Game"
$SystemUnderTestVersion = "1.0"
$TestResultsFormat = "nunit"
$TestResultsFile = "$root\bin\Debug\BowlingAGutterGame.xml"
  
# Call pickles
Pickle-Features -FeatureDirectory $FeatureDirectory  `
                -OutputDirectory $OutputDirectory  `
                -DocumentationFormat $DocumentationFormat `
                -SystemUnderTestName $SystemUnderTestName  `
                -SystemUnderTestVersion $SystemUnderTestVersion  `
                -TestResultsFormat $TestResultsFormat  `
                -TestResultsFile $TestResultsFile