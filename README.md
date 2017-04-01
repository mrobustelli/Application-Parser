# ApplicationParser

This nuget package is used to extract information from Relativity's application for development. To install

```
nuget-install Heretik.ApplicationParser
```
After installing a ObjectTypes.tt will be generated that will output a cs file with all of the information in the application.xml file

## Note:
All template files assume the application file will be in the $(SolutionDir)\application\application.xml if you would like to change the location you will have to edit each file separately.
